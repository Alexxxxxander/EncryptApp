namespace EncryptApp
{
    partial class FormHelp
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
            this.labelHelp = new System.Windows.Forms.Label();
            this.buttonHelpExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHelp
            // 
            this.labelHelp.AutoSize = true;
            this.labelHelp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHelp.Location = new System.Drawing.Point(70, 9);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(232, 102);
            this.labelHelp.TabIndex = 0;
            this.labelHelp.Text = "Программа разработана\r\nНазаренко А.И. \r\nв качестве задания на практикум\r\nпо основ" +
    "ам разработки оконных\r\nприложений средствами технологии\r\nWindows Forms";
            this.labelHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonHelpExit
            // 
            this.buttonHelpExit.Location = new System.Drawing.Point(149, 124);
            this.buttonHelpExit.Name = "buttonHelpExit";
            this.buttonHelpExit.Size = new System.Drawing.Size(75, 23);
            this.buttonHelpExit.TabIndex = 1;
            this.buttonHelpExit.Text = "Выход";
            this.buttonHelpExit.UseVisualStyleBackColor = true;
            this.buttonHelpExit.Click += new System.EventHandler(this.buttonHelpExit_Click);
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 168);
            this.Controls.Add(this.buttonHelpExit);
            this.Controls.Add(this.labelHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(392, 207);
            this.MinimumSize = new System.Drawing.Size(392, 207);
            this.Name = "FormHelp";
            this.Text = "Справка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Button buttonHelpExit;
    }
}