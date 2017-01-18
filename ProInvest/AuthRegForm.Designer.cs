namespace ProInvest
{
    partial class AuthRegForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthRegForm));
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.RegPan = new System.Windows.Forms.Panel();
            this.CancelLab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RegBut = new System.Windows.Forms.Button();
            this.Pass2TB = new System.Windows.Forms.TextBox();
            this.Pass2Lab = new System.Windows.Forms.Label();
            this.Login2TB = new System.Windows.Forms.TextBox();
            this.Login2Lab = new System.Windows.Forms.Label();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.EmailLab = new System.Windows.Forms.Label();
            this.SurNTB = new System.Windows.Forms.TextBox();
            this.SurNLab = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.NameLab = new System.Windows.Forms.Label();
            this.RegLab = new System.Windows.Forms.Label();
            this.SignInBut = new System.Windows.Forms.Button();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.PassLab = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.LoginLab = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AuthPanel.SuspendLayout();
            this.RegPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthPanel
            // 
            this.AuthPanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.AuthPanel.Controls.Add(this.RegPan);
            this.AuthPanel.Controls.Add(this.RegLab);
            this.AuthPanel.Controls.Add(this.SignInBut);
            this.AuthPanel.Controls.Add(this.PassTB);
            this.AuthPanel.Controls.Add(this.PassLab);
            this.AuthPanel.Controls.Add(this.LoginTB);
            this.AuthPanel.Controls.Add(this.LoginLab);
            this.AuthPanel.Controls.Add(this.pictureBox1);
            this.AuthPanel.Controls.Add(this.label1);
            this.AuthPanel.Location = new System.Drawing.Point(0, 0);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(582, 452);
            this.AuthPanel.TabIndex = 0;
            // 
            // RegPan
            // 
            this.RegPan.Controls.Add(this.CancelLab);
            this.RegPan.Controls.Add(this.label2);
            this.RegPan.Controls.Add(this.pictureBox2);
            this.RegPan.Controls.Add(this.RegBut);
            this.RegPan.Controls.Add(this.Pass2TB);
            this.RegPan.Controls.Add(this.Pass2Lab);
            this.RegPan.Controls.Add(this.Login2TB);
            this.RegPan.Controls.Add(this.Login2Lab);
            this.RegPan.Controls.Add(this.EmailTB);
            this.RegPan.Controls.Add(this.EmailLab);
            this.RegPan.Controls.Add(this.SurNTB);
            this.RegPan.Controls.Add(this.SurNLab);
            this.RegPan.Controls.Add(this.NameTB);
            this.RegPan.Controls.Add(this.NameLab);
            this.RegPan.Location = new System.Drawing.Point(0, 0);
            this.RegPan.Name = "RegPan";
            this.RegPan.Size = new System.Drawing.Size(582, 452);
            this.RegPan.TabIndex = 6;
            this.RegPan.Visible = false;
            // 
            // CancelLab
            // 
            this.CancelLab.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelLab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CancelLab.Location = new System.Drawing.Point(123, 421);
            this.CancelLab.Name = "CancelLab";
            this.CancelLab.Size = new System.Drawing.Size(333, 23);
            this.CancelLab.TabIndex = 14;
            this.CancelLab.Text = "Отмена";
            this.CancelLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelLab.Click += new System.EventHandler(this.CancelLab_Click);
            this.CancelLab.MouseEnter += new System.EventHandler(this.CancelLab_MouseEnter);
            this.CancelLab.MouseLeave += new System.EventHandler(this.CancelLab_MouseLeave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(3, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(579, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Зарегистрируйтесь, чтобы перейти к ProInvest";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(582, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // RegBut
            // 
            this.RegBut.BackColor = System.Drawing.Color.DodgerBlue;
            this.RegBut.FlatAppearance.BorderSize = 0;
            this.RegBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegBut.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegBut.Location = new System.Drawing.Point(123, 369);
            this.RegBut.Name = "RegBut";
            this.RegBut.Size = new System.Drawing.Size(333, 38);
            this.RegBut.TabIndex = 10;
            this.RegBut.Text = "Зарегистрироваться";
            this.RegBut.UseVisualStyleBackColor = false;
            this.RegBut.Click += new System.EventHandler(this.RegBut_Click);
            // 
            // Pass2TB
            // 
            this.Pass2TB.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pass2TB.Location = new System.Drawing.Point(236, 310);
            this.Pass2TB.Name = "Pass2TB";
            this.Pass2TB.PasswordChar = '*';
            this.Pass2TB.Size = new System.Drawing.Size(220, 27);
            this.Pass2TB.TabIndex = 9;
            // 
            // Pass2Lab
            // 
            this.Pass2Lab.AutoSize = true;
            this.Pass2Lab.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pass2Lab.Location = new System.Drawing.Point(118, 311);
            this.Pass2Lab.Name = "Pass2Lab";
            this.Pass2Lab.Size = new System.Drawing.Size(89, 26);
            this.Pass2Lab.TabIndex = 8;
            this.Pass2Lab.Text = "Пароль:";
            // 
            // Login2TB
            // 
            this.Login2TB.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login2TB.Location = new System.Drawing.Point(236, 272);
            this.Login2TB.Name = "Login2TB";
            this.Login2TB.Size = new System.Drawing.Size(220, 27);
            this.Login2TB.TabIndex = 7;
            // 
            // Login2Lab
            // 
            this.Login2Lab.AutoSize = true;
            this.Login2Lab.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login2Lab.Location = new System.Drawing.Point(118, 273);
            this.Login2Lab.Name = "Login2Lab";
            this.Login2Lab.Size = new System.Drawing.Size(77, 26);
            this.Login2Lab.TabIndex = 6;
            this.Login2Lab.Text = "Логин:";
            // 
            // EmailTB
            // 
            this.EmailTB.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTB.Location = new System.Drawing.Point(236, 233);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(220, 27);
            this.EmailTB.TabIndex = 5;
            // 
            // EmailLab
            // 
            this.EmailLab.AutoSize = true;
            this.EmailLab.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLab.Location = new System.Drawing.Point(118, 234);
            this.EmailLab.Name = "EmailLab";
            this.EmailLab.Size = new System.Drawing.Size(70, 26);
            this.EmailLab.TabIndex = 4;
            this.EmailLab.Text = "Email:";
            // 
            // SurNTB
            // 
            this.SurNTB.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurNTB.Location = new System.Drawing.Point(236, 195);
            this.SurNTB.Name = "SurNTB";
            this.SurNTB.Size = new System.Drawing.Size(220, 27);
            this.SurNTB.TabIndex = 3;
            // 
            // SurNLab
            // 
            this.SurNLab.AutoSize = true;
            this.SurNLab.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurNLab.Location = new System.Drawing.Point(118, 196);
            this.SurNLab.Name = "SurNLab";
            this.SurNLab.Size = new System.Drawing.Size(107, 26);
            this.SurNLab.TabIndex = 2;
            this.SurNLab.Text = "Фамилия:";
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTB.Location = new System.Drawing.Point(236, 157);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(220, 27);
            this.NameTB.TabIndex = 1;
            // 
            // NameLab
            // 
            this.NameLab.AutoSize = true;
            this.NameLab.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLab.Location = new System.Drawing.Point(118, 158);
            this.NameLab.Name = "NameLab";
            this.NameLab.Size = new System.Drawing.Size(58, 26);
            this.NameLab.TabIndex = 0;
            this.NameLab.Text = "Имя:";
            // 
            // RegLab
            // 
            this.RegLab.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegLab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RegLab.Location = new System.Drawing.Point(131, 374);
            this.RegLab.Name = "RegLab";
            this.RegLab.Size = new System.Drawing.Size(312, 23);
            this.RegLab.TabIndex = 5;
            this.RegLab.Text = "Зарегистрироваться";
            this.RegLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegLab.Click += new System.EventHandler(this.RegLab_Click);
            this.RegLab.MouseEnter += new System.EventHandler(this.RegLab_MouseEnter);
            this.RegLab.MouseLeave += new System.EventHandler(this.RegLab_MouseLeave);
            // 
            // SignInBut
            // 
            this.SignInBut.BackColor = System.Drawing.Color.DodgerBlue;
            this.SignInBut.FlatAppearance.BorderSize = 0;
            this.SignInBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInBut.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignInBut.Location = new System.Drawing.Point(131, 308);
            this.SignInBut.Name = "SignInBut";
            this.SignInBut.Size = new System.Drawing.Size(312, 38);
            this.SignInBut.TabIndex = 4;
            this.SignInBut.Text = "Войти";
            this.SignInBut.UseVisualStyleBackColor = false;
            this.SignInBut.Click += new System.EventHandler(this.SignInBut_Click);
            // 
            // PassTB
            // 
            this.PassTB.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassTB.Location = new System.Drawing.Point(223, 259);
            this.PassTB.Name = "PassTB";
            this.PassTB.PasswordChar = '*';
            this.PassTB.Size = new System.Drawing.Size(220, 27);
            this.PassTB.TabIndex = 3;
            // 
            // PassLab
            // 
            this.PassLab.AutoSize = true;
            this.PassLab.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassLab.Location = new System.Drawing.Point(126, 260);
            this.PassLab.Name = "PassLab";
            this.PassLab.Size = new System.Drawing.Size(89, 26);
            this.PassLab.TabIndex = 2;
            this.PassLab.Text = "Пароль:";
            // 
            // LoginTB
            // 
            this.LoginTB.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTB.Location = new System.Drawing.Point(223, 193);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(220, 27);
            this.LoginTB.TabIndex = 1;
            // 
            // LoginLab
            // 
            this.LoginLab.AutoSize = true;
            this.LoginLab.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLab.Location = new System.Drawing.Point(126, 194);
            this.LoginLab.Name = "LoginLab";
            this.LoginLab.Size = new System.Drawing.Size(77, 26);
            this.LoginLab.TabIndex = 0;
            this.LoginLab.Text = "Логин:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(582, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(3, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Войдите, чтобы перейти к ProInvest";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.AuthPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AuthRegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аутентификация/Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthRegForm_FormClosed);
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.RegPan.ResumeLayout(false);
            this.RegPan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.Panel RegPan;
        private System.Windows.Forms.Button RegBut;
        private System.Windows.Forms.TextBox Pass2TB;
        private System.Windows.Forms.Label Pass2Lab;
        private System.Windows.Forms.TextBox Login2TB;
        private System.Windows.Forms.Label Login2Lab;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Label EmailLab;
        private System.Windows.Forms.TextBox SurNTB;
        private System.Windows.Forms.Label SurNLab;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label NameLab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CancelLab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label RegLab;
        private System.Windows.Forms.Button SignInBut;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.Label PassLab;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.Label LoginLab;
    }
}

