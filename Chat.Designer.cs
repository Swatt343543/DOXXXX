namespace KCorrespondence
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.WriteToWhom = new System.Windows.Forms.Label();
            this.TextYourMessage = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.TextBox();
            this.TextReceivingUserName = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.SendingUserName = new System.Windows.Forms.Label();
            this.SendingUserLogin = new System.Windows.Forms.Label();
            this.RecipientingUserLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WriteToWhom
            // 
            this.WriteToWhom.AutoSize = true;
            this.WriteToWhom.BackColor = System.Drawing.Color.Transparent;
            this.WriteToWhom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WriteToWhom.Location = new System.Drawing.Point(28, 26);
            this.WriteToWhom.Name = "WriteToWhom";
            this.WriteToWhom.Size = new System.Drawing.Size(108, 16);
            this.WriteToWhom.TabIndex = 0;
            this.WriteToWhom.Text = "Написать кому:";
            // 
            // TextYourMessage
            // 
            this.TextYourMessage.AutoSize = true;
            this.TextYourMessage.BackColor = System.Drawing.Color.Transparent;
            this.TextYourMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextYourMessage.Location = new System.Drawing.Point(28, 85);
            this.TextYourMessage.Name = "TextYourMessage";
            this.TextYourMessage.Size = new System.Drawing.Size(118, 16);
            this.TextYourMessage.TabIndex = 1;
            this.TextYourMessage.Text = "ВашеСообщение:";
            this.TextYourMessage.Click += new System.EventHandler(this.TextYourMessage_Click);
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(169, 64);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(210, 129);
            this.Message.TabIndex = 2;
            this.Message.TextChanged += new System.EventHandler(this.Message_TextChanged);
            // 
            // TextReceivingUserName
            // 
            this.TextReceivingUserName.AutoSize = true;
            this.TextReceivingUserName.BackColor = System.Drawing.Color.Transparent;
            this.TextReceivingUserName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TextReceivingUserName.Location = new System.Drawing.Point(142, 26);
            this.TextReceivingUserName.Name = "TextReceivingUserName";
            this.TextReceivingUserName.Size = new System.Drawing.Size(33, 16);
            this.TextReceivingUserName.TabIndex = 3;
            this.TextReceivingUserName.Text = "Text";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(293, 208);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(86, 23);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // SendingUserName
            // 
            this.SendingUserName.AutoSize = true;
            this.SendingUserName.BackColor = System.Drawing.Color.Transparent;
            this.SendingUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SendingUserName.Location = new System.Drawing.Point(108, 306);
            this.SendingUserName.Name = "SendingUserName";
            this.SendingUserName.Size = new System.Drawing.Size(70, 16);
            this.SendingUserName.TabIndex = 5;
            this.SendingUserName.Text = "TextName";
            // 
            // SendingUserLogin
            // 
            this.SendingUserLogin.AutoSize = true;
            this.SendingUserLogin.BackColor = System.Drawing.Color.Transparent;
            this.SendingUserLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SendingUserLogin.Location = new System.Drawing.Point(114, 346);
            this.SendingUserLogin.Name = "SendingUserLogin";
            this.SendingUserLogin.Size = new System.Drawing.Size(69, 16);
            this.SendingUserLogin.TabIndex = 6;
            this.SendingUserLogin.Text = "TextLogin ";
            // 
            // RecipientingUserLogin
            // 
            this.RecipientingUserLogin.AutoSize = true;
            this.RecipientingUserLogin.BackColor = System.Drawing.Color.Transparent;
            this.RecipientingUserLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RecipientingUserLogin.Location = new System.Drawing.Point(209, 255);
            this.RecipientingUserLogin.Name = "RecipientingUserLogin";
            this.RecipientingUserLogin.Size = new System.Drawing.Size(108, 16);
            this.RecipientingUserLogin.TabIndex = 7;
            this.RecipientingUserLogin.Text = "TextLoginResize";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Логин пользователя\r\nполучаещего сообщение: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ваше имя: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ваш логин: ";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Black;
            this.CloseButton.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(360, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(33, 30);
            this.CloseButton.TabIndex = 54;
            this.CloseButton.Text = "❌";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Red;
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(301, 396);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(92, 26);
            this.buttonBack.TabIndex = 80;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImage = global::GettingDataSqlLibrary.Properties.Resources.Новый_проект__1_;
            this.ClientSize = new System.Drawing.Size(391, 420);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecipientingUserLogin);
            this.Controls.Add(this.SendingUserLogin);
            this.Controls.Add(this.SendingUserName);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.TextReceivingUserName);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.TextYourMessage);
            this.Controls.Add(this.WriteToWhom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WriteToWhom;
        private System.Windows.Forms.Label TextYourMessage;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.Label TextReceivingUserName;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label SendingUserName;
        private System.Windows.Forms.Label SendingUserLogin;
        private System.Windows.Forms.Label RecipientingUserLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button buttonBack;
    }
}