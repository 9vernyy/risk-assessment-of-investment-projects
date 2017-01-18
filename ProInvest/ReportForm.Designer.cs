namespace ProInvest
{
    partial class ReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVFC = new System.Windows.Forms.DataGridView();
            this.PsrCB = new System.Windows.Forms.CheckBox();
            this.DGVFM = new System.Windows.Forms.DataGridView();
            this.PeCB = new System.Windows.Forms.CheckBox();
            this.PdpCB = new System.Windows.Forms.CheckBox();
            this.OkBut = new System.Windows.Forms.Button();
            this.CancelBut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVFC);
            this.groupBox1.Controls.Add(this.PsrCB);
            this.groupBox1.Controls.Add(this.DGVFM);
            this.groupBox1.Controls.Add(this.PeCB);
            this.groupBox1.Controls.Add(this.PdpCB);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Что включить в отчет?";
            // 
            // DGVFC
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DGVFC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVFC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVFC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVFC.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVFC.EnableHeadersVisualStyles = false;
            this.DGVFC.Location = new System.Drawing.Point(151, 62);
            this.DGVFC.Name = "DGVFC";
            this.DGVFC.RowHeadersVisible = false;
            this.DGVFC.RowTemplate.Height = 24;
            this.DGVFC.Size = new System.Drawing.Size(146, 72);
            this.DGVFC.TabIndex = 7;
            this.DGVFC.Visible = false;
            // 
            // PsrCB
            // 
            this.PsrCB.AutoSize = true;
            this.PsrCB.Location = new System.Drawing.Point(15, 92);
            this.PsrCB.Name = "PsrCB";
            this.PsrCB.Size = new System.Drawing.Size(254, 24);
            this.PsrCB.TabIndex = 2;
            this.PsrCB.Text = "Показатели скрытых расчетов";
            this.PsrCB.UseVisualStyleBackColor = true;
            // 
            // DGVFM
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DGVFM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVFM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVFM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVFM.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVFM.EnableHeadersVisualStyles = false;
            this.DGVFM.Location = new System.Drawing.Point(0, 62);
            this.DGVFM.Name = "DGVFM";
            this.DGVFM.RowHeadersVisible = false;
            this.DGVFM.RowTemplate.Height = 24;
            this.DGVFM.Size = new System.Drawing.Size(145, 72);
            this.DGVFM.TabIndex = 6;
            this.DGVFM.Visible = false;
            // 
            // PeCB
            // 
            this.PeCB.AutoSize = true;
            this.PeCB.Location = new System.Drawing.Point(15, 62);
            this.PeCB.Name = "PeCB";
            this.PeCB.Size = new System.Drawing.Size(235, 24);
            this.PeCB.TabIndex = 1;
            this.PeCB.Text = "Показатели эффективности";
            this.PeCB.UseVisualStyleBackColor = true;
            // 
            // PdpCB
            // 
            this.PdpCB.AutoSize = true;
            this.PdpCB.Location = new System.Drawing.Point(15, 32);
            this.PdpCB.Name = "PdpCB";
            this.PdpCB.Size = new System.Drawing.Size(238, 24);
            this.PdpCB.TabIndex = 0;
            this.PdpCB.Text = "Первичные данные проекта";
            this.PdpCB.UseVisualStyleBackColor = true;
            // 
            // OkBut
            // 
            this.OkBut.BackColor = System.Drawing.Color.DodgerBlue;
            this.OkBut.FlatAppearance.BorderSize = 0;
            this.OkBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkBut.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OkBut.Location = new System.Drawing.Point(326, 38);
            this.OkBut.Name = "OkBut";
            this.OkBut.Size = new System.Drawing.Size(120, 33);
            this.OkBut.TabIndex = 1;
            this.OkBut.Text = "Ok";
            this.OkBut.UseVisualStyleBackColor = false;
            this.OkBut.Click += new System.EventHandler(this.OkBut_Click);
            // 
            // CancelBut
            // 
            this.CancelBut.BackColor = System.Drawing.Color.DodgerBlue;
            this.CancelBut.FlatAppearance.BorderSize = 0;
            this.CancelBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBut.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelBut.Location = new System.Drawing.Point(326, 85);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(120, 33);
            this.CancelBut.TabIndex = 2;
            this.CancelBut.Text = "Отмена";
            this.CancelBut.UseVisualStyleBackColor = false;
            this.CancelBut.Click += new System.EventHandler(this.CancelBut_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(452, 153);
            this.Controls.Add(this.CancelBut);
            this.Controls.Add(this.OkBut);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Содержание отчета";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox PeCB;
        private System.Windows.Forms.CheckBox PdpCB;
        private System.Windows.Forms.Button OkBut;
        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.CheckBox PsrCB;
        private System.Windows.Forms.DataGridView DGVFC;
        private System.Windows.Forms.DataGridView DGVFM;
    }
}