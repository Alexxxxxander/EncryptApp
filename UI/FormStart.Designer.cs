namespace EncryptApp
{
    partial class FormStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxOutputText = new System.Windows.Forms.TextBox();
            this.textBoxInputText = new System.Windows.Forms.TextBox();
            this.buttonCloseDecrypt = new System.Windows.Forms.Button();
            this.buttonFileDecrypt = new System.Windows.Forms.Button();
            this.buttonCopyDecoding = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOutputText
            // 
            this.textBoxOutputText.BackColor = System.Drawing.Color.White;
            this.textBoxOutputText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOutputText.Enabled = false;
            this.textBoxOutputText.ForeColor = System.Drawing.Color.Gray;
            this.textBoxOutputText.Location = new System.Drawing.Point(374, 35);
            this.textBoxOutputText.Multiline = true;
            this.textBoxOutputText.Name = "textBoxOutputText";
            this.textBoxOutputText.ReadOnly = true;
            this.textBoxOutputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutputText.Size = new System.Drawing.Size(250, 150);
            this.textBoxOutputText.TabIndex = 3;
            this.textBoxOutputText.Text = "Расшифрованный текст";
            // 
            // textBoxInputText
            // 
            this.textBoxInputText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputText.ForeColor = System.Drawing.Color.Gray;
            this.textBoxInputText.Location = new System.Drawing.Point(14, 35);
            this.textBoxInputText.Multiline = true;
            this.textBoxInputText.Name = "textBoxInputText";
            this.textBoxInputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInputText.Size = new System.Drawing.Size(250, 150);
            this.textBoxInputText.TabIndex = 2;
            this.textBoxInputText.Text = "Введите текст";
            this.textBoxInputText.TextChanged += new System.EventHandler(this.textBoxInputText_TextChanged);
            this.textBoxInputText.Enter += new System.EventHandler(this.textBoxInputText_Enter);
            this.textBoxInputText.Leave += new System.EventHandler(this.textBoxInputText_Leave);
            // 
            // buttonCloseDecrypt
            // 
            this.buttonCloseDecrypt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCloseDecrypt.Location = new System.Drawing.Point(12, 255);
            this.buttonCloseDecrypt.Name = "buttonCloseDecrypt";
            this.buttonCloseDecrypt.Size = new System.Drawing.Size(75, 26);
            this.buttonCloseDecrypt.TabIndex = 4;
            this.buttonCloseDecrypt.Text = "Закрыть";
            this.buttonCloseDecrypt.UseVisualStyleBackColor = true;
            this.buttonCloseDecrypt.Click += new System.EventHandler(this.buttonCloseDecrypt_Click);
            // 
            // buttonFileDecrypt
            // 
            this.buttonFileDecrypt.Location = new System.Drawing.Point(173, 190);
            this.buttonFileDecrypt.Name = "buttonFileDecrypt";
            this.buttonFileDecrypt.Size = new System.Drawing.Size(75, 26);
            this.buttonFileDecrypt.TabIndex = 5;
            this.buttonFileDecrypt.Text = "Файл";
            this.buttonFileDecrypt.UseVisualStyleBackColor = true;
            this.buttonFileDecrypt.Click += new System.EventHandler(this.buttonFileDecrypt_Click);
            // 
            // buttonCopyDecoding
            // 
            this.buttonCopyDecoding.Location = new System.Drawing.Point(374, 190);
            this.buttonCopyDecoding.Name = "buttonCopyDecoding";
            this.buttonCopyDecoding.Size = new System.Drawing.Size(75, 26);
            this.buttonCopyDecoding.TabIndex = 6;
            this.buttonCopyDecoding.Text = "Копировать";
            this.buttonCopyDecoding.UseVisualStyleBackColor = true;
            this.buttonCopyDecoding.Click += new System.EventHandler(this.buttonCopyDecoding_Click);
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(270, 88);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(98, 47);
            this.buttonDecode.TabIndex = 7;
            this.buttonDecode.Text = "Расшировать\r\nили\r\nЗашифровать\r\n";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(547, 255);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 26);
            this.buttonHelp.TabIndex = 8;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonPaste
            // 
            this.buttonPaste.Location = new System.Drawing.Point(92, 190);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(75, 26);
            this.buttonPaste.TabIndex = 9;
            this.buttonPaste.Text = "Вставить";
            this.buttonPaste.UseVisualStyleBackColor = true;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(455, 190);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 26);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(634, 290);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonPaste);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.buttonCopyDecoding);
            this.Controls.Add(this.buttonFileDecrypt);
            this.Controls.Add(this.buttonCloseDecrypt);
            this.Controls.Add(this.textBoxOutputText);
            this.Controls.Add(this.textBoxInputText);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Шифратор";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOutputText;
        private System.Windows.Forms.TextBox textBoxInputText;
        private System.Windows.Forms.Button buttonCloseDecrypt;
        private System.Windows.Forms.Button buttonFileDecrypt;
        private System.Windows.Forms.Button buttonCopyDecoding;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonPaste;
        private System.Windows.Forms.Button buttonSave;
    }
}