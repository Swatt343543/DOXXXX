namespace KCorrespondence
{
    partial class Registation
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registation));
            this.BoxNameReg = new System.Windows.Forms.TextBox();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.BoxLastNameReg = new System.Windows.Forms.TextBox();
            this.BoxAgeReg = new System.Windows.Forms.TextBox();
            this.BoxLengthReg = new System.Windows.Forms.TextBox();
            this.BoxColorReg = new System.Windows.Forms.TextBox();
            this.BoxPreferColorReg = new System.Windows.Forms.TextBox();
            this.TextNameReg = new System.Windows.Forms.Label();
            this.TextLastNameReg = new System.Windows.Forms.Label();
            this.TextAgeReg = new System.Windows.Forms.Label();
            this.TextLengthReg = new System.Windows.Forms.Label();
            this.TextColorReg = new System.Windows.Forms.Label();
            this.TextUser = new System.Windows.Forms.Label();
            this.TextPrefer = new System.Windows.Forms.Label();
            this.TextPreferColorReg = new System.Windows.Forms.Label();
            this.BoxPreferMaxAgeReg = new System.Windows.Forms.TextBox();
            this.BoxPreferMinAgeReg = new System.Windows.Forms.TextBox();
            this.TextPreferMaksAgeReg = new System.Windows.Forms.Label();
            this.TextPreferMinAgeReg = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.BoxPreferMaxLengthReg = new System.Windows.Forms.TextBox();
            this.BoxPreferMinLengthReg = new System.Windows.Forms.TextBox();
            this.TextPreferMaxLengthReg = new System.Windows.Forms.Label();
            this.TextPreferMinLengthReg = new System.Windows.Forms.Label();
            this.TextLoginReg = new System.Windows.Forms.Label();
            this.BoxLoginReg = new System.Windows.Forms.TextBox();
            this.BoxPasswordReg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BoxNameReg
            // 
            this.BoxNameReg.Location = new System.Drawing.Point(120, 108);
            this.BoxNameReg.Name = "BoxNameReg";
            this.BoxNameReg.Size = new System.Drawing.Size(119, 22);
            this.BoxNameReg.TabIndex = 0;
            this.BoxNameReg.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ButtonCreate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonCreate.Location = new System.Drawing.Point(430, 276);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(119, 22);
            this.ButtonCreate.TabIndex = 1;
            this.ButtonCreate.Text = "Создать";
            this.ButtonCreate.UseVisualStyleBackColor = false;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // BoxLastNameReg
            // 
            this.BoxLastNameReg.Location = new System.Drawing.Point(120, 136);
            this.BoxLastNameReg.Name = "BoxLastNameReg";
            this.BoxLastNameReg.Size = new System.Drawing.Size(119, 22);
            this.BoxLastNameReg.TabIndex = 2;
            // 
            // BoxAgeReg
            // 
            this.BoxAgeReg.Location = new System.Drawing.Point(120, 164);
            this.BoxAgeReg.Name = "BoxAgeReg";
            this.BoxAgeReg.Size = new System.Drawing.Size(119, 22);
            this.BoxAgeReg.TabIndex = 3;
            // 
            // BoxLengthReg
            // 
            this.BoxLengthReg.Location = new System.Drawing.Point(120, 192);
            this.BoxLengthReg.Name = "BoxLengthReg";
            this.BoxLengthReg.Size = new System.Drawing.Size(119, 22);
            this.BoxLengthReg.TabIndex = 4;
            // 
            // BoxColorReg
            // 
            this.BoxColorReg.Location = new System.Drawing.Point(120, 220);
            this.BoxColorReg.Name = "BoxColorReg";
            this.BoxColorReg.Size = new System.Drawing.Size(119, 22);
            this.BoxColorReg.TabIndex = 5;
            // 
            // BoxPreferColorReg
            // 
            this.BoxPreferColorReg.Location = new System.Drawing.Point(430, 220);
            this.BoxPreferColorReg.Name = "BoxPreferColorReg";
            this.BoxPreferColorReg.Size = new System.Drawing.Size(119, 22);
            this.BoxPreferColorReg.TabIndex = 8;
            // 
            // TextNameReg
            // 
            this.TextNameReg.AutoSize = true;
            this.TextNameReg.BackColor = System.Drawing.Color.Transparent;
            this.TextNameReg.ForeColor = System.Drawing.SystemColors.Window;
            this.TextNameReg.Location = new System.Drawing.Point(81, 108);
            this.TextNameReg.Name = "TextNameReg";
            this.TextNameReg.Size = new System.Drawing.Size(33, 16);
            this.TextNameReg.TabIndex = 9;
            this.TextNameReg.Text = "Имя";
            this.TextNameReg.Click += new System.EventHandler(this.TextName_Click);
            // 
            // TextLastNameReg
            // 
            this.TextLastNameReg.AutoSize = true;
            this.TextLastNameReg.BackColor = System.Drawing.Color.Transparent;
            this.TextLastNameReg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextLastNameReg.Location = new System.Drawing.Point(48, 136);
            this.TextLastNameReg.Name = "TextLastNameReg";
            this.TextLastNameReg.Size = new System.Drawing.Size(66, 16);
            this.TextLastNameReg.TabIndex = 10;
            this.TextLastNameReg.Text = "Фамилия";
            // 
            // TextAgeReg
            // 
            this.TextAgeReg.AutoSize = true;
            this.TextAgeReg.BackColor = System.Drawing.Color.Transparent;
            this.TextAgeReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextAgeReg.Location = new System.Drawing.Point(44, 164);
            this.TextAgeReg.Name = "TextAgeReg";
            this.TextAgeReg.Size = new System.Drawing.Size(70, 16);
            this.TextAgeReg.TabIndex = 11;
            this.TextAgeReg.Text = "Возвраст";
            // 
            // TextLengthReg
            // 
            this.TextLengthReg.AutoSize = true;
            this.TextLengthReg.BackColor = System.Drawing.Color.Transparent;
            this.TextLengthReg.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TextLengthReg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextLengthReg.Location = new System.Drawing.Point(76, 192);
            this.TextLengthReg.Name = "TextLengthReg";
            this.TextLengthReg.Size = new System.Drawing.Size(38, 16);
            this.TextLengthReg.TabIndex = 12;
            this.TextLengthReg.Text = "Рост";
            // 
            // TextColorReg
            // 
            this.TextColorReg.AutoSize = true;
            this.TextColorReg.BackColor = System.Drawing.Color.Transparent;
            this.TextColorReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextColorReg.Location = new System.Drawing.Point(75, 220);
            this.TextColorReg.Name = "TextColorReg";
            this.TextColorReg.Size = new System.Drawing.Size(39, 16);
            this.TextColorReg.TabIndex = 13;
            this.TextColorReg.Text = "Цвет";
            // 
            // TextUser
            // 
            this.TextUser.AutoSize = true;
            this.TextUser.BackColor = System.Drawing.Color.Transparent;
            this.TextUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextUser.Location = new System.Drawing.Point(132, 52);
            this.TextUser.Name = "TextUser";
            this.TextUser.Size = new System.Drawing.Size(93, 16);
            this.TextUser.TabIndex = 14;
            this.TextUser.Text = "Ваши данные";
            // 
            // TextPrefer
            // 
            this.TextPrefer.AutoSize = true;
            this.TextPrefer.BackColor = System.Drawing.Color.Transparent;
            this.TextPrefer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TextPrefer.Location = new System.Drawing.Point(449, 52);
            this.TextPrefer.Name = "TextPrefer";
            this.TextPrefer.Size = new System.Drawing.Size(80, 16);
            this.TextPrefer.TabIndex = 15;
            this.TextPrefer.Text = "Кого ищети";
            // 
            // TextPreferColorReg
            // 
            this.TextPreferColorReg.AutoSize = true;
            this.TextPreferColorReg.BackColor = System.Drawing.Color.Transparent;
            this.TextPreferColorReg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextPreferColorReg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextPreferColorReg.Location = new System.Drawing.Point(385, 220);
            this.TextPreferColorReg.Name = "TextPreferColorReg";
            this.TextPreferColorReg.Size = new System.Drawing.Size(39, 16);
            this.TextPreferColorReg.TabIndex = 18;
            this.TextPreferColorReg.Text = "Цвет";
            // 
            // BoxPreferMaxAgeReg
            // 
            this.BoxPreferMaxAgeReg.Location = new System.Drawing.Point(430, 108);
            this.BoxPreferMaxAgeReg.Name = "BoxPreferMaxAgeReg";
            this.BoxPreferMaxAgeReg.Size = new System.Drawing.Size(119, 22);
            this.BoxPreferMaxAgeReg.TabIndex = 19;
            // 
            // BoxPreferMinAgeReg
            // 
            this.BoxPreferMinAgeReg.Location = new System.Drawing.Point(430, 136);
            this.BoxPreferMinAgeReg.Name = "BoxPreferMinAgeReg";
            this.BoxPreferMinAgeReg.Size = new System.Drawing.Size(119, 22);
            this.BoxPreferMinAgeReg.TabIndex = 20;
            // 
            // TextPreferMaksAgeReg
            // 
            this.TextPreferMaksAgeReg.AutoSize = true;
            this.TextPreferMaksAgeReg.BackColor = System.Drawing.Color.Transparent;
            this.TextPreferMaksAgeReg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextPreferMaksAgeReg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextPreferMaksAgeReg.Location = new System.Drawing.Point(319, 108);
            this.TextPreferMaksAgeReg.Name = "TextPreferMaksAgeReg";
            this.TextPreferMaksAgeReg.Size = new System.Drawing.Size(105, 16);
            this.TextPreferMaksAgeReg.TabIndex = 21;
            this.TextPreferMaksAgeReg.Text = "Макс возвраст";
            // 
            // TextPreferMinAgeReg
            // 
            this.TextPreferMinAgeReg.AutoSize = true;
            this.TextPreferMinAgeReg.BackColor = System.Drawing.Color.Transparent;
            this.TextPreferMinAgeReg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextPreferMinAgeReg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextPreferMinAgeReg.Location = new System.Drawing.Point(325, 136);
            this.TextPreferMinAgeReg.Name = "TextPreferMinAgeReg";
            this.TextPreferMinAgeReg.Size = new System.Drawing.Size(99, 16);
            this.TextPreferMinAgeReg.TabIndex = 22;
            this.TextPreferMinAgeReg.Text = "Мин возвраст";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CloseButton.Location = new System.Drawing.Point(659, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(23, 22);
            this.CloseButton.TabIndex = 39;
            this.CloseButton.Text = "❌";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BoxPreferMaxLengthReg
            // 
            this.BoxPreferMaxLengthReg.Location = new System.Drawing.Point(430, 164);
            this.BoxPreferMaxLengthReg.Name = "BoxPreferMaxLengthReg";
            this.BoxPreferMaxLengthReg.Size = new System.Drawing.Size(119, 22);
            this.BoxPreferMaxLengthReg.TabIndex = 40;
            // 
            // BoxPreferMinLengthReg
            // 
            this.BoxPreferMinLengthReg.Location = new System.Drawing.Point(430, 192);
            this.BoxPreferMinLengthReg.Name = "BoxPreferMinLengthReg";
            this.BoxPreferMinLengthReg.Size = new System.Drawing.Size(119, 22);
            this.BoxPreferMinLengthReg.TabIndex = 41;
            // 
            // TextPreferMaxLengthReg
            // 
            this.TextPreferMaxLengthReg.AutoSize = true;
            this.TextPreferMaxLengthReg.BackColor = System.Drawing.Color.Transparent;
            this.TextPreferMaxLengthReg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextPreferMaxLengthReg.Location = new System.Drawing.Point(351, 164);
            this.TextPreferMaxLengthReg.Name = "TextPreferMaxLengthReg";
            this.TextPreferMaxLengthReg.Size = new System.Drawing.Size(73, 16);
            this.TextPreferMaxLengthReg.TabIndex = 42;
            this.TextPreferMaxLengthReg.Text = "Макс рост";
            // 
            // TextPreferMinLengthReg
            // 
            this.TextPreferMinLengthReg.AutoSize = true;
            this.TextPreferMinLengthReg.BackColor = System.Drawing.Color.Transparent;
            this.TextPreferMinLengthReg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextPreferMinLengthReg.Location = new System.Drawing.Point(357, 192);
            this.TextPreferMinLengthReg.Name = "TextPreferMinLengthReg";
            this.TextPreferMinLengthReg.Size = new System.Drawing.Size(67, 16);
            this.TextPreferMinLengthReg.TabIndex = 43;
            this.TextPreferMinLengthReg.Text = "Мин рост";
            // 
            // TextLoginReg
            // 
            this.TextLoginReg.AutoSize = true;
            this.TextLoginReg.BackColor = System.Drawing.Color.Transparent;
            this.TextLoginReg.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TextLoginReg.Location = new System.Drawing.Point(68, 248);
            this.TextLoginReg.Name = "TextLoginReg";
            this.TextLoginReg.Size = new System.Drawing.Size(46, 16);
            this.TextLoginReg.TabIndex = 44;
            this.TextLoginReg.Text = "Логин";
            // 
            // BoxLoginReg
            // 
            this.BoxLoginReg.Location = new System.Drawing.Point(120, 248);
            this.BoxLoginReg.MaxLength = 29;
            this.BoxLoginReg.Multiline = true;
            this.BoxLoginReg.Name = "BoxLoginReg";
            this.BoxLoginReg.Size = new System.Drawing.Size(119, 22);
            this.BoxLoginReg.TabIndex = 45;
            this.BoxLoginReg.TextChanged += new System.EventHandler(this.BoxLoginReg_TextChanged);
            // 
            // BoxPasswordReg
            // 
            this.BoxPasswordReg.Location = new System.Drawing.Point(120, 276);
            this.BoxPasswordReg.MaxLength = 29;
            this.BoxPasswordReg.Multiline = true;
            this.BoxPasswordReg.Name = "BoxPasswordReg";
            this.BoxPasswordReg.Size = new System.Drawing.Size(119, 22);
            this.BoxPasswordReg.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(58, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Пароль";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Yellow;
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonBack.Location = new System.Drawing.Point(-4, 397);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(92, 33);
            this.buttonBack.TabIndex = 80;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 16);
            this.label2.TabIndex = 81;
            this.label2.Text = "ЕСЛИ ВАМ ПРЕДПОЧТИТЕЛЕН ЛЮБОЙ ЦВЕТ, МОЖЕТЕ ПРОПУСТИТЬ ЭТО ПОЛЕ";
            // 
            // Registation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::GettingDataSqlLibrary.Properties.Resources.RegistrationWindowFon;
            this.ClientSize = new System.Drawing.Size(681, 428);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxPasswordReg);
            this.Controls.Add(this.BoxLoginReg);
            this.Controls.Add(this.TextLoginReg);
            this.Controls.Add(this.TextPreferMinLengthReg);
            this.Controls.Add(this.TextPreferMaxLengthReg);
            this.Controls.Add(this.BoxPreferMinLengthReg);
            this.Controls.Add(this.BoxPreferMaxLengthReg);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TextPreferMinAgeReg);
            this.Controls.Add(this.TextPreferMaksAgeReg);
            this.Controls.Add(this.BoxPreferMinAgeReg);
            this.Controls.Add(this.BoxPreferMaxAgeReg);
            this.Controls.Add(this.TextPreferColorReg);
            this.Controls.Add(this.TextPrefer);
            this.Controls.Add(this.TextUser);
            this.Controls.Add(this.TextColorReg);
            this.Controls.Add(this.TextLengthReg);
            this.Controls.Add(this.TextAgeReg);
            this.Controls.Add(this.TextLastNameReg);
            this.Controls.Add(this.TextNameReg);
            this.Controls.Add(this.BoxPreferColorReg);
            this.Controls.Add(this.BoxColorReg);
            this.Controls.Add(this.BoxLengthReg);
            this.Controls.Add(this.BoxAgeReg);
            this.Controls.Add(this.BoxLastNameReg);
            this.Controls.Add(this.BoxNameReg);
            this.Controls.Add(this.ButtonCreate);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(681, 428);
            this.MinimumSize = new System.Drawing.Size(681, 428);
            this.Name = "Registation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск Знакомств-Регистрация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxNameReg;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.TextBox BoxLastNameReg;
        private System.Windows.Forms.TextBox BoxAgeReg;
        private System.Windows.Forms.TextBox BoxLengthReg;
        private System.Windows.Forms.TextBox BoxColorReg;
        private System.Windows.Forms.TextBox BoxPreferColorReg;
        private System.Windows.Forms.Label TextNameReg;
        private System.Windows.Forms.Label TextLastNameReg;
        private System.Windows.Forms.Label TextAgeReg;
        private System.Windows.Forms.Label TextLengthReg;
        private System.Windows.Forms.Label TextColorReg;
        private System.Windows.Forms.Label TextUser;
        private System.Windows.Forms.Label TextPrefer;
        private System.Windows.Forms.Label TextPreferColorReg;
        private System.Windows.Forms.TextBox BoxPreferMaxAgeReg;
        private System.Windows.Forms.TextBox BoxPreferMinAgeReg;
        private System.Windows.Forms.Label TextPreferMaksAgeReg;
        private System.Windows.Forms.Label TextPreferMinAgeReg;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox BoxPreferMaxLengthReg;
        private System.Windows.Forms.TextBox BoxPreferMinLengthReg;
        private System.Windows.Forms.Label TextPreferMaxLengthReg;
        private System.Windows.Forms.Label TextPreferMinLengthReg;
        private System.Windows.Forms.Label TextLoginReg;
        private System.Windows.Forms.TextBox BoxLoginReg;
        private System.Windows.Forms.TextBox BoxPasswordReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label2;
    }
}

