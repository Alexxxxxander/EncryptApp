using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EncryptApp
{
    public partial class FormStart : Form
    {
        /// <summary>
        /// Открывает окно открытия файла
        /// </summary>
        void OpenFileDialog()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        textBoxInputText.Text = fileContent;
                    }
                }
            }
        }

        /// <summary>
        /// Открывает окно сохранения файла
        /// </summary>
        void OpenSaveFileDialog()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Текстовый файл (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.DefaultExt = "exe";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBoxOutputText.Text);
                MessageBox.Show("Файл сохранен");
            }
        }
        /// <summary>
        /// Инициализация формы
        /// </summary>
        public FormStart()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonCloseDecrypt_Click(object sender, EventArgs e)
        {
            Close();

        }

      
        /// <summary>
        /// Нажатие кнопки Файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFileDecrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog();
        }

        /// <summary>
        /// Нажатие кнопки Шифровать или расшифровать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDecode_Click(object sender, EventArgs e)
        {
            if(textBoxInputText.Text != "Введите текст")
            {
                textBoxOutputText.ForeColor = Color.Black;
                textBoxOutputText.Text = Program.EncodeDecrypt(textBoxInputText.Text.ToString(), Program.secretKey);
                textBoxOutputText.Enabled = true;
            }
        }

        /// <summary>
        /// Изменение текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxInputText_TextChanged(object sender, EventArgs e)
        {
            this.textBoxInputText.ForeColor = Color.Black;
        }

        /// <summary>
        /// Покинул текстовое поле для ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxInputText_Leave(object sender, EventArgs e)
        {
            if (textBoxInputText.Text == "" || textBoxInputText.Text == " ")
            {
                this.textBoxInputText.ForeColor = Color.Gray ;
                textBoxInputText.Text = "Введите текст, который хотите расшифровать";
                this.textBoxInputText.ForeColor = Color.Gray;
            }
        }
        /// <summary>
        /// Выбрал текстовое поле для ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxInputText_Enter(object sender, EventArgs e)
        {
            if(textBoxInputText.Text == "Введите текст" || textBoxInputText.Text == "Введите текст, который хотите расшифровать")
            {
                textBoxInputText.Text = "";
            }
        }

        /// <summary>
        /// Нажатие на кнопку Помощь
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
                if (frm is FormHelp)
                {
                    frm.Activate();
                    return;
                }
            FormHelp form = new FormHelp();
            form.Show();
            return;
        }

        private void buttonCopyDecoding_Click(object sender, EventArgs e)
        {
            if(textBoxOutputText.Text != "Расшифрованный текст")             
                Clipboard.SetText(textBoxOutputText.Text);
        }
        /// <summary>
        /// Нажатие на кнопку вставить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPaste_Click(object sender, EventArgs e)
        {
            if(Clipboard.ContainsText())
            {
                textBoxInputText.Text =  Clipboard.GetText();
            }
        }
        /// <summary>
        /// Нажатие на кнопку сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            OpenSaveFileDialog();

        }
    }
}
