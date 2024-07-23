namespace KCorrespondence
{
    partial class Mesages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mesages));
            this.TextFromWhom = new System.Windows.Forms.Label();
            this.TextMessage = new System.Windows.Forms.Label();
            this.NameUser = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.messageBeingSent = new System.Windows.Forms.TextBox();
            this.TextYourQuait = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textInfoYouHaveNoMessages = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextFromWhom
            // 
            this.TextFromWhom.AutoSize = true;
            this.TextFromWhom.BackColor = System.Drawing.Color.Transparent;
            this.TextFromWhom.ForeColor = System.Drawing.Color.White;
            this.TextFromWhom.Location = new System.Drawing.Point(36, 125);
            this.TextFromWhom.Name = "TextFromWhom";
            this.TextFromWhom.Size = new System.Drawing.Size(70, 16);
            this.TextFromWhom.TabIndex = 0;
            this.TextFromWhom.Text = "ОТ КОГО: ";
            // 
            // TextMessage
            // 
            this.TextMessage.AutoSize = true;
            this.TextMessage.BackColor = System.Drawing.Color.Transparent;
            this.TextMessage.ForeColor = System.Drawing.Color.White;
            this.TextMessage.Location = new System.Drawing.Point(36, 153);
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(84, 16);
            this.TextMessage.TabIndex = 1;
            this.TextMessage.Text = "Сообщение:";
            // 
            // NameUser
            // 
            this.NameUser.AutoSize = true;
            this.NameUser.BackColor = System.Drawing.Color.Transparent;
            this.NameUser.ForeColor = System.Drawing.Color.White;
            this.NameUser.Location = new System.Drawing.Point(126, 125);
            this.NameUser.Name = "NameUser";
            this.NameUser.Size = new System.Drawing.Size(44, 16);
            this.NameUser.TabIndex = 2;
            this.NameUser.Text = "Name";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.BackColor = System.Drawing.Color.Transparent;
            this.Message.ForeColor = System.Drawing.Color.White;
            this.Message.Location = new System.Drawing.Point(126, 153);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(64, 16);
            this.Message.TabIndex = 3;
            this.Message.Text = "Message";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Black;
            this.CloseButton.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(768, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(33, 30);
            this.CloseButton.TabIndex = 55;
            this.CloseButton.Text = "❌";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // messageBeingSent
            // 
            this.messageBeingSent.Location = new System.Drawing.Point(39, 306);
            this.messageBeingSent.Multiline = true;
            this.messageBeingSent.Name = "messageBeingSent";
            this.messageBeingSent.Size = new System.Drawing.Size(241, 103);
            this.messageBeingSent.TabIndex = 56;
            this.messageBeingSent.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextYourQuait
            // 
            this.TextYourQuait.AutoSize = true;
            this.TextYourQuait.BackColor = System.Drawing.Color.Transparent;
            this.TextYourQuait.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TextYourQuait.Location = new System.Drawing.Point(36, 287);
            this.TextYourQuait.Name = "TextYourQuait";
            this.TextYourQuait.Size = new System.Drawing.Size(90, 16);
            this.TextYourQuait.TabIndex = 57;
            this.TextYourQuait.Text = "ВАШ ОТВЕТ:";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(286, 364);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(104, 45);
            this.buttonSend.TabIndex = 58;
            this.buttonSend.Text = "ОТПРАВИТЬ";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // textInfoYouHaveNoMessages
            // 
            this.textInfoYouHaveNoMessages.AutoSize = true;
            this.textInfoYouHaveNoMessages.BackColor = System.Drawing.Color.Transparent;
            this.textInfoYouHaveNoMessages.ForeColor = System.Drawing.Color.White;
            this.textInfoYouHaveNoMessages.Location = new System.Drawing.Point(314, 221);
            this.textInfoYouHaveNoMessages.Name = "textInfoYouHaveNoMessages";
            this.textInfoYouHaveNoMessages.Size = new System.Drawing.Size(215, 16);
            this.textInfoYouHaveNoMessages.TabIndex = 59;
            this.textInfoYouHaveNoMessages.Text = "У ВАС ПОКА НЕТ СООБЩЕНИЙ!";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(709, 472);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(92, 40);
            this.buttonBack.TabIndex = 60;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ToReturn);
            // 
            // Mesages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GettingDataSqlLibrary.Properties.Resources.FonFormMesagesNew;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textInfoYouHaveNoMessages);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.TextYourQuait);
            this.Controls.Add(this.messageBeingSent);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.NameUser);
            this.Controls.Add(this.TextMessage);
            this.Controls.Add(this.TextFromWhom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mesages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesages";
            this.Load += new System.EventHandler(this.Mesages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextFromWhom;
        private System.Windows.Forms.Label TextMessage;
        private System.Windows.Forms.Label NameUser;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox messageBeingSent;
        private System.Windows.Forms.Label TextYourQuait;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label textInfoYouHaveNoMessages;
        private System.Windows.Forms.Button buttonBack;
    }
}