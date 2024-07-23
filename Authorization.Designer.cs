namespace KCorrespondence
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.TextLogin = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.Label();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.ButtonRegistrtion = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextLogin
            // 
            this.TextLogin.AutoSize = true;
            this.TextLogin.BackColor = System.Drawing.Color.Transparent;
            this.TextLogin.ForeColor = System.Drawing.Color.Black;
            this.TextLogin.Location = new System.Drawing.Point(222, 85);
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(53, 16);
            this.TextLogin.TabIndex = 0;
            this.TextLogin.Text = "ЛОГИН";
            // 
            // TextPassword
            // 
            this.TextPassword.AutoSize = true;
            this.TextPassword.BackColor = System.Drawing.Color.Transparent;
            this.TextPassword.ForeColor = System.Drawing.Color.Black;
            this.TextPassword.Location = new System.Drawing.Point(678, 85);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(63, 16);
            this.TextPassword.TabIndex = 1;
            this.TextPassword.Text = "ПАРОЛЬ";
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(112, 110);
            this.TextBoxLogin.MaxLength = 29;
            this.TextBoxLogin.Multiline = true;
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(263, 35);
            this.TextBoxLogin.TabIndex = 2;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(581, 110);
            this.TextBoxPassword.MaxLength = 29;
            this.TextBoxPassword.Multiline = true;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(263, 35);
            this.TextBoxPassword.TabIndex = 3;
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.Location = new System.Drawing.Point(744, 276);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(100, 36);
            this.ButtonEnter.TabIndex = 4;
            this.ButtonEnter.Text = "Войти";
            this.ButtonEnter.UseVisualStyleBackColor = true;
            this.ButtonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // ButtonRegistrtion
            // 
            this.ButtonRegistrtion.Location = new System.Drawing.Point(12, 499);
            this.ButtonRegistrtion.Name = "ButtonRegistrtion";
            this.ButtonRegistrtion.Size = new System.Drawing.Size(163, 23);
            this.ButtonRegistrtion.TabIndex = 5;
            this.ButtonRegistrtion.Text = "Зарегистрироваться";
            this.ButtonRegistrtion.UseVisualStyleBackColor = true;
            this.ButtonRegistrtion.Click += new System.EventHandler(this.ButtonRegistrtion_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Black;
            this.CloseButton.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(919, -1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(33, 30);
            this.CloseButton.TabIndex = 55;
            this.CloseButton.Text = "❌";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GettingDataSqlLibrary.Properties.Resources.AutorizationWindowFonNew;
            this.ClientSize = new System.Drawing.Size(952, 534);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ButtonRegistrtion);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextLogin;
        private System.Windows.Forms.Label TextPassword;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button ButtonEnter;
        private System.Windows.Forms.Button ButtonRegistrtion;
        private System.Windows.Forms.Button CloseButton;
    }
}