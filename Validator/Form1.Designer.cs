namespace Validator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MTBCard = new System.Windows.Forms.MaskedTextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBNum = new System.Windows.Forms.TextBox();
            this.TBMail = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.TBPassReply = new System.Windows.Forms.TextBox();
            this.PBNum = new System.Windows.Forms.PictureBox();
            this.PBCard = new System.Windows.Forms.PictureBox();
            this.PBMail = new System.Windows.Forms.PictureBox();
            this.PBName = new System.Windows.Forms.PictureBox();
            this.PBPass = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPass)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Проверить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(132, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Заполните форму";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя пользователя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Номер карты:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Номер телефона:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Пароль:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Повторить пароль:";
            // 
            // MTBCard
            // 
            this.MTBCard.AsciiOnly = true;
            this.MTBCard.BeepOnError = true;
            this.MTBCard.HideSelection = false;
            this.MTBCard.Location = new System.Drawing.Point(127, 93);
            this.MTBCard.Mask = "0000 0000 0000 0000";
            this.MTBCard.Name = "MTBCard";
            this.MTBCard.Size = new System.Drawing.Size(208, 20);
            this.MTBCard.TabIndex = 9;
            this.MTBCard.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(127, 63);
            this.TBName.MaxLength = 30;
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(208, 20);
            this.TBName.TabIndex = 15;
            // 
            // TBNum
            // 
            this.TBNum.Location = new System.Drawing.Point(127, 153);
            this.TBNum.Name = "TBNum";
            this.TBNum.Size = new System.Drawing.Size(208, 20);
            this.TBNum.TabIndex = 16;
            this.TBNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNum_KeyPress);
            // 
            // TBMail
            // 
            this.TBMail.Location = new System.Drawing.Point(127, 184);
            this.TBMail.Name = "TBMail";
            this.TBMail.Size = new System.Drawing.Size(208, 20);
            this.TBMail.TabIndex = 17;
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(127, 214);
            this.TBPass.MaxLength = 30;
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(208, 20);
            this.TBPass.TabIndex = 18;
            // 
            // TBPassReply
            // 
            this.TBPassReply.Location = new System.Drawing.Point(127, 244);
            this.TBPassReply.MaxLength = 30;
            this.TBPassReply.Name = "TBPassReply";
            this.TBPassReply.Size = new System.Drawing.Size(208, 20);
            this.TBPassReply.TabIndex = 19;
            // 
            // PBNum
            // 
            this.PBNum.Image = ((System.Drawing.Image)(resources.GetObject("PBNum.Image")));
            this.PBNum.Location = new System.Drawing.Point(354, 153);
            this.PBNum.Name = "PBNum";
            this.PBNum.Size = new System.Drawing.Size(38, 20);
            this.PBNum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBNum.TabIndex = 14;
            this.PBNum.TabStop = false;
            this.PBNum.Visible = false;
            // 
            // PBCard
            // 
            this.PBCard.Image = ((System.Drawing.Image)(resources.GetObject("PBCard.Image")));
            this.PBCard.Location = new System.Drawing.Point(354, 93);
            this.PBCard.Name = "PBCard";
            this.PBCard.Size = new System.Drawing.Size(38, 20);
            this.PBCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBCard.TabIndex = 13;
            this.PBCard.TabStop = false;
            this.PBCard.Visible = false;
            // 
            // PBMail
            // 
            this.PBMail.Image = ((System.Drawing.Image)(resources.GetObject("PBMail.Image")));
            this.PBMail.Location = new System.Drawing.Point(354, 184);
            this.PBMail.Name = "PBMail";
            this.PBMail.Size = new System.Drawing.Size(38, 20);
            this.PBMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBMail.TabIndex = 12;
            this.PBMail.TabStop = false;
            this.PBMail.Visible = false;
            // 
            // PBName
            // 
            this.PBName.Image = ((System.Drawing.Image)(resources.GetObject("PBName.Image")));
            this.PBName.Location = new System.Drawing.Point(354, 63);
            this.PBName.Name = "PBName";
            this.PBName.Size = new System.Drawing.Size(38, 20);
            this.PBName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBName.TabIndex = 11;
            this.PBName.TabStop = false;
            this.PBName.Visible = false;
            // 
            // PBPass
            // 
            this.PBPass.Image = global::Validator.Properties.Resources._false;
            this.PBPass.Location = new System.Drawing.Point(354, 214);
            this.PBPass.Name = "PBPass";
            this.PBPass.Size = new System.Drawing.Size(38, 20);
            this.PBPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBPass.TabIndex = 10;
            this.PBPass.TabStop = false;
            this.PBPass.Visible = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Validator.Properties.Resources.показать;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(361, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 20);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(134, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Пароли не совпадают!";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 321);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TBPassReply);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBMail);
            this.Controls.Add(this.TBNum);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.PBNum);
            this.Controls.Add(this.PBCard);
            this.Controls.Add(this.PBMail);
            this.Controls.Add(this.PBName);
            this.Controls.Add(this.PBPass);
            this.Controls.Add(this.MTBCard);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Валидация данных";
            ((System.ComponentModel.ISupportInitialize)(this.PBNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MTBCard;
        private System.Windows.Forms.PictureBox PBPass;
        private System.Windows.Forms.PictureBox PBName;
        private System.Windows.Forms.PictureBox PBMail;
        private System.Windows.Forms.PictureBox PBCard;
        private System.Windows.Forms.PictureBox PBNum;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBNum;
        private System.Windows.Forms.TextBox TBMail;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.TextBox TBPassReply;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

