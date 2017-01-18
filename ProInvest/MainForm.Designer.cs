namespace ProInvest
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ExitFromAccLab = new System.Windows.Forms.Label();
            this.UserNSLab = new System.Windows.Forms.Label();
            this.MainPan = new System.Windows.Forms.Panel();
            this.NewProjPan = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Y5Lab = new System.Windows.Forms.Label();
            this.Y4Lab = new System.Windows.Forms.Label();
            this.Y3Lab = new System.Windows.Forms.Label();
            this.Y2Lab = new System.Windows.Forms.Label();
            this.Y1Lab = new System.Windows.Forms.Label();
            this.Income5YTB = new System.Windows.Forms.TextBox();
            this.Income5YLab = new System.Windows.Forms.Label();
            this.Income4YTB = new System.Windows.Forms.TextBox();
            this.Income4YLab = new System.Windows.Forms.Label();
            this.Income3YTB = new System.Windows.Forms.TextBox();
            this.Income3YLab = new System.Windows.Forms.Label();
            this.Income2YTB = new System.Windows.Forms.TextBox();
            this.Income2YLab = new System.Windows.Forms.Label();
            this.Income1YTB = new System.Windows.Forms.TextBox();
            this.Income1YLab = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CurrCB = new System.Windows.Forms.ComboBox();
            this.DiscRateTB = new System.Windows.Forms.TextBox();
            this.DiscRateLab = new System.Windows.Forms.Label();
            this.InvestTB = new System.Windows.Forms.TextBox();
            this.InvestLab = new System.Windows.Forms.Label();
            this.AuthProjTB2 = new System.Windows.Forms.TextBox();
            this.AuthProjLab2 = new System.Windows.Forms.Label();
            this.NameProjTB2 = new System.Windows.Forms.TextBox();
            this.NameProjLab2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelLab = new System.Windows.Forms.Label();
            this.SaveBut = new System.Windows.Forms.Button();
            this.PrAvGB = new System.Windows.Forms.GroupBox();
            this.ChangeProjBut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CompareProjBut = new System.Windows.Forms.Button();
            this.DeleteProjBut = new System.Windows.Forms.Button();
            this.OpenProjBut = new System.Windows.Forms.Button();
            this.CreateProjBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AboutProjAuthBut = new System.Windows.Forms.Button();
            this.HelpBut = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MainPan.SuspendLayout();
            this.NewProjPan.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PrAvGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitFromAccLab
            // 
            this.ExitFromAccLab.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitFromAccLab.Location = new System.Drawing.Point(668, 526);
            this.ExitFromAccLab.Name = "ExitFromAccLab";
            this.ExitFromAccLab.Size = new System.Drawing.Size(72, 23);
            this.ExitFromAccLab.TabIndex = 0;
            this.ExitFromAccLab.Text = "(Выход)";
            this.ExitFromAccLab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitFromAccLab.Click += new System.EventHandler(this.ExitFromAccLab_Click);
            this.ExitFromAccLab.MouseEnter += new System.EventHandler(this.ExitFromAcc_MouseEnter);
            this.ExitFromAccLab.MouseLeave += new System.EventHandler(this.ExitFromAccLab_MouseLeave);
            // 
            // UserNSLab
            // 
            this.UserNSLab.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNSLab.Location = new System.Drawing.Point(349, 526);
            this.UserNSLab.Name = "UserNSLab";
            this.UserNSLab.Size = new System.Drawing.Size(326, 23);
            this.UserNSLab.TabIndex = 1;
            this.UserNSLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainPan
            // 
            this.MainPan.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.MainPan.Controls.Add(this.NewProjPan);
            this.MainPan.Controls.Add(this.PrAvGB);
            this.MainPan.Controls.Add(this.ExitFromAccLab);
            this.MainPan.Controls.Add(this.UserNSLab);
            this.MainPan.Controls.Add(this.label1);
            this.MainPan.Controls.Add(this.AboutProjAuthBut);
            this.MainPan.Controls.Add(this.HelpBut);
            this.MainPan.Location = new System.Drawing.Point(1, 0);
            this.MainPan.Name = "MainPan";
            this.MainPan.Size = new System.Drawing.Size(781, 554);
            this.MainPan.TabIndex = 2;
            // 
            // NewProjPan
            // 
            this.NewProjPan.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.NewProjPan.Controls.Add(this.groupBox2);
            this.NewProjPan.Controls.Add(this.groupBox1);
            this.NewProjPan.Controls.Add(this.label2);
            this.NewProjPan.Controls.Add(this.CancelLab);
            this.NewProjPan.Controls.Add(this.SaveBut);
            this.NewProjPan.Location = new System.Drawing.Point(0, 0);
            this.NewProjPan.Name = "NewProjPan";
            this.NewProjPan.Size = new System.Drawing.Size(781, 554);
            this.NewProjPan.TabIndex = 3;
            this.NewProjPan.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Y5Lab);
            this.groupBox2.Controls.Add(this.Y4Lab);
            this.groupBox2.Controls.Add(this.Y3Lab);
            this.groupBox2.Controls.Add(this.Y2Lab);
            this.groupBox2.Controls.Add(this.Y1Lab);
            this.groupBox2.Controls.Add(this.Income5YTB);
            this.groupBox2.Controls.Add(this.Income5YLab);
            this.groupBox2.Controls.Add(this.Income4YTB);
            this.groupBox2.Controls.Add(this.Income4YLab);
            this.groupBox2.Controls.Add(this.Income3YTB);
            this.groupBox2.Controls.Add(this.Income3YLab);
            this.groupBox2.Controls.Add(this.Income2YTB);
            this.groupBox2.Controls.Add(this.Income2YLab);
            this.groupBox2.Controls.Add(this.Income1YTB);
            this.groupBox2.Controls.Add(this.Income1YLab);
            this.groupBox2.Location = new System.Drawing.Point(69, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 273);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            // 
            // Y5Lab
            // 
            this.Y5Lab.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y5Lab.Location = new System.Drawing.Point(564, 155);
            this.Y5Lab.Name = "Y5Lab";
            this.Y5Lab.Size = new System.Drawing.Size(37, 25);
            this.Y5Lab.TabIndex = 61;
            this.Y5Lab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Y4Lab
            // 
            this.Y4Lab.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y4Lab.Location = new System.Drawing.Point(564, 67);
            this.Y4Lab.Name = "Y4Lab";
            this.Y4Lab.Size = new System.Drawing.Size(37, 25);
            this.Y4Lab.TabIndex = 60;
            this.Y4Lab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Y3Lab
            // 
            this.Y3Lab.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y3Lab.Location = new System.Drawing.Point(263, 239);
            this.Y3Lab.Name = "Y3Lab";
            this.Y3Lab.Size = new System.Drawing.Size(37, 25);
            this.Y3Lab.TabIndex = 59;
            this.Y3Lab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Y2Lab
            // 
            this.Y2Lab.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y2Lab.Location = new System.Drawing.Point(263, 155);
            this.Y2Lab.Name = "Y2Lab";
            this.Y2Lab.Size = new System.Drawing.Size(37, 25);
            this.Y2Lab.TabIndex = 58;
            this.Y2Lab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Y1Lab
            // 
            this.Y1Lab.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y1Lab.Location = new System.Drawing.Point(263, 67);
            this.Y1Lab.Name = "Y1Lab";
            this.Y1Lab.Size = new System.Drawing.Size(37, 25);
            this.Y1Lab.TabIndex = 57;
            this.Y1Lab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Income5YTB
            // 
            this.Income5YTB.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Income5YTB.Location = new System.Drawing.Point(306, 155);
            this.Income5YTB.Name = "Income5YTB";
            this.Income5YTB.Size = new System.Drawing.Size(254, 25);
            this.Income5YTB.TabIndex = 60;
            this.Income5YTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Income5YTB_KeyPress);
            // 
            // Income5YLab
            // 
            this.Income5YLab.AutoSize = true;
            this.Income5YLab.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Income5YLab.Location = new System.Drawing.Point(302, 103);
            this.Income5YLab.Name = "Income5YLab";
            this.Income5YLab.Size = new System.Drawing.Size(182, 40);
            this.Income5YLab.TabIndex = 59;
            this.Income5YLab.Text = "Прогнозируемый поток\r\nдоходов в 5-ый год:";
            // 
            // Income4YTB
            // 
            this.Income4YTB.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Income4YTB.Location = new System.Drawing.Point(306, 67);
            this.Income4YTB.Name = "Income4YTB";
            this.Income4YTB.Size = new System.Drawing.Size(254, 25);
            this.Income4YTB.TabIndex = 58;
            this.Income4YTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Income4YTB_KeyPress);
            // 
            // Income4YLab
            // 
            this.Income4YLab.AutoSize = true;
            this.Income4YLab.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Income4YLab.Location = new System.Drawing.Point(302, 16);
            this.Income4YLab.Name = "Income4YLab";
            this.Income4YLab.Size = new System.Drawing.Size(182, 40);
            this.Income4YLab.TabIndex = 57;
            this.Income4YLab.Text = "Прогнозируемый поток\r\nдоходов в 4-ый год:";
            // 
            // Income3YTB
            // 
            this.Income3YTB.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Income3YTB.Location = new System.Drawing.Point(4, 239);
            this.Income3YTB.Name = "Income3YTB";
            this.Income3YTB.Size = new System.Drawing.Size(254, 25);
            this.Income3YTB.TabIndex = 56;
            this.Income3YTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Income3YTB_KeyPress);
            // 
            // Income3YLab
            // 
            this.Income3YLab.AutoSize = true;
            this.Income3YLab.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Income3YLab.Location = new System.Drawing.Point(1, 187);
            this.Income3YLab.Name = "Income3YLab";
            this.Income3YLab.Size = new System.Drawing.Size(182, 40);
            this.Income3YLab.TabIndex = 55;
            this.Income3YLab.Text = "Прогнозируемый поток\r\nдоходов в 3-ий год:";
            // 
            // Income2YTB
            // 
            this.Income2YTB.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Income2YTB.Location = new System.Drawing.Point(4, 155);
            this.Income2YTB.Name = "Income2YTB";
            this.Income2YTB.Size = new System.Drawing.Size(254, 25);
            this.Income2YTB.TabIndex = 54;
            this.Income2YTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Income2YTB_KeyPress);
            // 
            // Income2YLab
            // 
            this.Income2YLab.AutoSize = true;
            this.Income2YLab.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Income2YLab.Location = new System.Drawing.Point(1, 103);
            this.Income2YLab.Name = "Income2YLab";
            this.Income2YLab.Size = new System.Drawing.Size(182, 40);
            this.Income2YLab.TabIndex = 53;
            this.Income2YLab.Text = "Прогнозируемый поток\r\nдоходов во 2-ой год:";
            // 
            // Income1YTB
            // 
            this.Income1YTB.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Income1YTB.Location = new System.Drawing.Point(5, 67);
            this.Income1YTB.Name = "Income1YTB";
            this.Income1YTB.Size = new System.Drawing.Size(254, 25);
            this.Income1YTB.TabIndex = 52;
            this.Income1YTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Income1YTB_KeyPress);
            // 
            // Income1YLab
            // 
            this.Income1YLab.AutoSize = true;
            this.Income1YLab.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Income1YLab.Location = new System.Drawing.Point(1, 16);
            this.Income1YLab.Name = "Income1YLab";
            this.Income1YLab.Size = new System.Drawing.Size(182, 40);
            this.Income1YLab.TabIndex = 51;
            this.Income1YLab.Text = "Прогнозируемый поток\r\nдоходов в 1-ый год:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CurrCB);
            this.groupBox1.Controls.Add(this.DiscRateTB);
            this.groupBox1.Controls.Add(this.DiscRateLab);
            this.groupBox1.Controls.Add(this.InvestTB);
            this.groupBox1.Controls.Add(this.InvestLab);
            this.groupBox1.Controls.Add(this.AuthProjTB2);
            this.groupBox1.Controls.Add(this.AuthProjLab2);
            this.groupBox1.Controls.Add(this.NameProjTB2);
            this.groupBox1.Controls.Add(this.NameProjLab2);
            this.groupBox1.Location = new System.Drawing.Point(69, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 138);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // CurrCB
            // 
            this.CurrCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CurrCB.FormattingEnabled = true;
            this.CurrCB.Items.AddRange(new object[] {
            "₸",
            "₽",
            "$"});
            this.CurrCB.Location = new System.Drawing.Point(566, 43);
            this.CurrCB.Name = "CurrCB";
            this.CurrCB.Size = new System.Drawing.Size(69, 25);
            this.CurrCB.TabIndex = 48;
            this.CurrCB.SelectedIndexChanged += new System.EventHandler(this.CurrCB_SelectedIndexChanged);
            this.CurrCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurrCB_KeyPress);
            // 
            // DiscRateTB
            // 
            this.DiscRateTB.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscRateTB.Location = new System.Drawing.Point(306, 106);
            this.DiscRateTB.Name = "DiscRateTB";
            this.DiscRateTB.Size = new System.Drawing.Size(254, 25);
            this.DiscRateTB.TabIndex = 50;
            this.DiscRateTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DiscRateTB_KeyPress);
            // 
            // DiscRateLab
            // 
            this.DiscRateLab.AutoSize = true;
            this.DiscRateLab.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscRateLab.Location = new System.Drawing.Point(302, 78);
            this.DiscRateLab.Name = "DiscRateLab";
            this.DiscRateLab.Size = new System.Drawing.Size(151, 20);
            this.DiscRateLab.TabIndex = 49;
            this.DiscRateLab.Text = "Ставка дисконта(%)";
            // 
            // InvestTB
            // 
            this.InvestTB.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvestTB.Location = new System.Drawing.Point(306, 44);
            this.InvestTB.Name = "InvestTB";
            this.InvestTB.Size = new System.Drawing.Size(254, 25);
            this.InvestTB.TabIndex = 47;
            this.InvestTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InvestTB_KeyPress);
            // 
            // InvestLab
            // 
            this.InvestLab.AutoSize = true;
            this.InvestLab.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvestLab.Location = new System.Drawing.Point(302, 16);
            this.InvestLab.Name = "InvestLab";
            this.InvestLab.Size = new System.Drawing.Size(258, 20);
            this.InvestLab.TabIndex = 46;
            this.InvestLab.Text = "Вложения, требуемые проектом:";
            // 
            // AuthProjTB2
            // 
            this.AuthProjTB2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthProjTB2.Location = new System.Drawing.Point(5, 106);
            this.AuthProjTB2.Name = "AuthProjTB2";
            this.AuthProjTB2.Size = new System.Drawing.Size(254, 25);
            this.AuthProjTB2.TabIndex = 45;
            // 
            // AuthProjLab2
            // 
            this.AuthProjLab2.AutoSize = true;
            this.AuthProjLab2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthProjLab2.Location = new System.Drawing.Point(1, 78);
            this.AuthProjLab2.Name = "AuthProjLab2";
            this.AuthProjLab2.Size = new System.Drawing.Size(158, 20);
            this.AuthProjLab2.TabIndex = 44;
            this.AuthProjLab2.Text = "Инициатор проекта:";
            // 
            // NameProjTB2
            // 
            this.NameProjTB2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameProjTB2.Location = new System.Drawing.Point(5, 44);
            this.NameProjTB2.Name = "NameProjTB2";
            this.NameProjTB2.Size = new System.Drawing.Size(254, 25);
            this.NameProjTB2.TabIndex = 43;
            // 
            // NameProjLab2
            // 
            this.NameProjLab2.AutoSize = true;
            this.NameProjLab2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameProjLab2.Location = new System.Drawing.Point(1, 16);
            this.NameProjLab2.Name = "NameProjLab2";
            this.NameProjLab2.Size = new System.Drawing.Size(147, 20);
            this.NameProjLab2.TabIndex = 42;
            this.NameProjLab2.Text = "Название проекта:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(104, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(560, 62);
            this.label2.TabIndex = 20;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancelLab
            // 
            this.CancelLab.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelLab.Location = new System.Drawing.Point(277, 520);
            this.CancelLab.Name = "CancelLab";
            this.CancelLab.Size = new System.Drawing.Size(225, 23);
            this.CancelLab.TabIndex = 62;
            this.CancelLab.Text = "Отмена";
            this.CancelLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelLab.Click += new System.EventHandler(this.CancelLab_Click);
            this.CancelLab.MouseEnter += new System.EventHandler(this.CancelLab_MouseEnter);
            this.CancelLab.MouseLeave += new System.EventHandler(this.CancelLab_MouseLeave);
            // 
            // SaveBut
            // 
            this.SaveBut.BackColor = System.Drawing.Color.DodgerBlue;
            this.SaveBut.FlatAppearance.BorderSize = 0;
            this.SaveBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBut.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveBut.Location = new System.Drawing.Point(277, 475);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(225, 32);
            this.SaveBut.TabIndex = 61;
            this.SaveBut.Text = "Создать";
            this.SaveBut.UseVisualStyleBackColor = false;
            this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click);
            // 
            // PrAvGB
            // 
            this.PrAvGB.Controls.Add(this.ChangeProjBut);
            this.PrAvGB.Controls.Add(this.dataGridView1);
            this.PrAvGB.Controls.Add(this.CompareProjBut);
            this.PrAvGB.Controls.Add(this.DeleteProjBut);
            this.PrAvGB.Controls.Add(this.OpenProjBut);
            this.PrAvGB.Controls.Add(this.CreateProjBut);
            this.PrAvGB.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrAvGB.Location = new System.Drawing.Point(32, 124);
            this.PrAvGB.Name = "PrAvGB";
            this.PrAvGB.Size = new System.Drawing.Size(713, 369);
            this.PrAvGB.TabIndex = 3;
            this.PrAvGB.TabStop = false;
            this.PrAvGB.Text = "Ваши проекты:";
            // 
            // ChangeProjBut
            // 
            this.ChangeProjBut.BackColor = System.Drawing.Color.DodgerBlue;
            this.ChangeProjBut.FlatAppearance.BorderSize = 0;
            this.ChangeProjBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeProjBut.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeProjBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChangeProjBut.Location = new System.Drawing.Point(602, 327);
            this.ChangeProjBut.Name = "ChangeProjBut";
            this.ChangeProjBut.Size = new System.Drawing.Size(104, 30);
            this.ChangeProjBut.TabIndex = 4;
            this.ChangeProjBut.Text = "Изменить";
            this.ChangeProjBut.UseVisualStyleBackColor = false;
            this.ChangeProjBut.Click += new System.EventHandler(this.ChangeProjBut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(9, 33);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(697, 260);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // CompareProjBut
            // 
            this.CompareProjBut.BackColor = System.Drawing.Color.DodgerBlue;
            this.CompareProjBut.FlatAppearance.BorderSize = 0;
            this.CompareProjBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompareProjBut.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompareProjBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CompareProjBut.Location = new System.Drawing.Point(447, 327);
            this.CompareProjBut.Name = "CompareProjBut";
            this.CompareProjBut.Size = new System.Drawing.Size(104, 30);
            this.CompareProjBut.TabIndex = 3;
            this.CompareProjBut.Text = "Сравнить";
            this.CompareProjBut.UseVisualStyleBackColor = false;
            this.CompareProjBut.Click += new System.EventHandler(this.CompareProjBut_Click);
            // 
            // DeleteProjBut
            // 
            this.DeleteProjBut.BackColor = System.Drawing.Color.DodgerBlue;
            this.DeleteProjBut.FlatAppearance.BorderSize = 0;
            this.DeleteProjBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProjBut.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteProjBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteProjBut.Location = new System.Drawing.Point(296, 327);
            this.DeleteProjBut.Name = "DeleteProjBut";
            this.DeleteProjBut.Size = new System.Drawing.Size(104, 30);
            this.DeleteProjBut.TabIndex = 2;
            this.DeleteProjBut.Text = "Удалить";
            this.DeleteProjBut.UseVisualStyleBackColor = false;
            this.DeleteProjBut.Click += new System.EventHandler(this.DeleteProjBut_Click);
            // 
            // OpenProjBut
            // 
            this.OpenProjBut.BackColor = System.Drawing.Color.DodgerBlue;
            this.OpenProjBut.FlatAppearance.BorderSize = 0;
            this.OpenProjBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenProjBut.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenProjBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OpenProjBut.Location = new System.Drawing.Point(150, 327);
            this.OpenProjBut.Name = "OpenProjBut";
            this.OpenProjBut.Size = new System.Drawing.Size(104, 30);
            this.OpenProjBut.TabIndex = 1;
            this.OpenProjBut.Text = "Открыть";
            this.OpenProjBut.UseVisualStyleBackColor = false;
            this.OpenProjBut.Click += new System.EventHandler(this.OpenProjBut_Click);
            // 
            // CreateProjBut
            // 
            this.CreateProjBut.BackColor = System.Drawing.Color.DodgerBlue;
            this.CreateProjBut.FlatAppearance.BorderSize = 0;
            this.CreateProjBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateProjBut.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateProjBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateProjBut.Location = new System.Drawing.Point(9, 327);
            this.CreateProjBut.Name = "CreateProjBut";
            this.CreateProjBut.Size = new System.Drawing.Size(104, 30);
            this.CreateProjBut.TabIndex = 0;
            this.CreateProjBut.Text = "Создать";
            this.CreateProjBut.UseVisualStyleBackColor = false;
            this.CreateProjBut.Click += new System.EventHandler(this.CreateProjBut_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 94);
            this.label1.TabIndex = 14;
            this.label1.Text = "Программное обеспечение \"ProInvest\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutProjAuthBut
            // 
            this.AboutProjAuthBut.BackColor = System.Drawing.Color.DodgerBlue;
            this.AboutProjAuthBut.FlatAppearance.BorderSize = 0;
            this.AboutProjAuthBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutProjAuthBut.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutProjAuthBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AboutProjAuthBut.Location = new System.Drawing.Point(34, 519);
            this.AboutProjAuthBut.Name = "AboutProjAuthBut";
            this.AboutProjAuthBut.Size = new System.Drawing.Size(140, 30);
            this.AboutProjAuthBut.TabIndex = 5;
            this.AboutProjAuthBut.Text = "О программе";
            this.AboutProjAuthBut.UseVisualStyleBackColor = false;
            this.AboutProjAuthBut.Click += new System.EventHandler(this.AboutProjAuthBut_Click);
            // 
            // HelpBut
            // 
            this.HelpBut.BackColor = System.Drawing.Color.DodgerBlue;
            this.HelpBut.FlatAppearance.BorderSize = 0;
            this.HelpBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpBut.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HelpBut.Location = new System.Drawing.Point(209, 519);
            this.HelpBut.Name = "HelpBut";
            this.HelpBut.Size = new System.Drawing.Size(140, 30);
            this.HelpBut.TabIndex = 6;
            this.HelpBut.Text = "Справка";
            this.HelpBut.UseVisualStyleBackColor = false;
            this.HelpBut.Click += new System.EventHandler(this.HelpBut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.MainPan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProInvest";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPan.ResumeLayout(false);
            this.NewProjPan.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PrAvGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ExitFromAccLab;
        private System.Windows.Forms.Label UserNSLab;
        private System.Windows.Forms.Panel MainPan;
        private System.Windows.Forms.GroupBox PrAvGB;
        private System.Windows.Forms.Button CompareProjBut;
        private System.Windows.Forms.Button DeleteProjBut;
        private System.Windows.Forms.Button OpenProjBut;
        private System.Windows.Forms.Button CreateProjBut;
        private System.Windows.Forms.Button ChangeProjBut;
        private System.Windows.Forms.Panel NewProjPan;
        private System.Windows.Forms.Label CancelLab;
        private System.Windows.Forms.Button SaveBut;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HelpBut;
        private System.Windows.Forms.Button AboutProjAuthBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CurrCB;
        private System.Windows.Forms.TextBox DiscRateTB;
        private System.Windows.Forms.Label DiscRateLab;
        private System.Windows.Forms.TextBox InvestTB;
        private System.Windows.Forms.Label InvestLab;
        private System.Windows.Forms.TextBox AuthProjTB2;
        private System.Windows.Forms.Label AuthProjLab2;
        private System.Windows.Forms.TextBox NameProjTB2;
        private System.Windows.Forms.Label NameProjLab2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Y5Lab;
        private System.Windows.Forms.Label Y4Lab;
        private System.Windows.Forms.Label Y3Lab;
        private System.Windows.Forms.Label Y2Lab;
        private System.Windows.Forms.Label Y1Lab;
        private System.Windows.Forms.TextBox Income5YTB;
        private System.Windows.Forms.Label Income5YLab;
        private System.Windows.Forms.TextBox Income4YTB;
        private System.Windows.Forms.Label Income4YLab;
        private System.Windows.Forms.TextBox Income3YTB;
        private System.Windows.Forms.Label Income3YLab;
        private System.Windows.Forms.TextBox Income2YTB;
        private System.Windows.Forms.Label Income2YLab;
        private System.Windows.Forms.TextBox Income1YTB;
        private System.Windows.Forms.Label Income1YLab;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}