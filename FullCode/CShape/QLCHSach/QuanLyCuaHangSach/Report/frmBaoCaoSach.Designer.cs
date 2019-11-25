namespace QuanLyCuaHangSach
{
    partial class frmBaoCaoSach
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoSach));
            this.bdsTheLoai = new System.Windows.Forms.BindingSource(this.components);
            this.bdsNXB = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXem = new System.Windows.Forms.Button();
            this.cboNXB = new System.Windows.Forms.ComboBox();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.radTheoNXB = new System.Windows.Forms.RadioButton();
            this.radTheoTheLoai = new System.Windows.Forms.RadioButton();
            this.radNhomNXB = new System.Windows.Forms.RadioButton();
            this.radNhomTheLoai = new System.Windows.Forms.RadioButton();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.pnlReport = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTheLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNXB)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdsTheLoai
            // 
            this.bdsTheLoai.DataSource = typeof(DTO.TheLoaiDTO);
            // 
            // bdsNXB
            // 
            this.bdsNXB.DataSource = typeof(DTO.NhaXuatBanDTO);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.cboNXB);
            this.panel1.Controls.Add(this.cboTheLoai);
            this.panel1.Controls.Add(this.radTheoNXB);
            this.panel1.Controls.Add(this.radTheoTheLoai);
            this.panel1.Controls.Add(this.radNhomNXB);
            this.panel1.Controls.Add(this.radNhomTheLoai);
            this.panel1.Controls.Add(this.radTatCa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 71);
            this.panel1.TabIndex = 0;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.DarkGreen;
            this.btnXem.FlatAppearance.BorderSize = 0;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem.Location = new System.Drawing.Point(595, 23);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(92, 43);
            this.btnXem.TabIndex = 12;
            this.btnXem.Text = "Xem";
            this.btnXem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cboNXB
            // 
            this.cboNXB.DataSource = this.bdsNXB;
            this.cboNXB.DisplayMember = "Ten";
            this.cboNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNXB.DropDownWidth = 200;
            this.cboNXB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNXB.FormattingEnabled = true;
            this.cboNXB.Location = new System.Drawing.Point(415, 5);
            this.cboNXB.Name = "cboNXB";
            this.cboNXB.Size = new System.Drawing.Size(162, 29);
            this.cboNXB.TabIndex = 10;
            this.cboNXB.ValueMember = "MaNXB";
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.DataSource = this.bdsTheLoai;
            this.cboTheLoai.DisplayMember = "Ten";
            this.cboTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(415, 37);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(162, 29);
            this.cboTheLoai.TabIndex = 11;
            this.cboTheLoai.ValueMember = "MaTheLoai";
            // 
            // radTheoNXB
            // 
            this.radTheoNXB.AutoSize = true;
            this.radTheoNXB.Location = new System.Drawing.Point(289, 6);
            this.radTheoNXB.Name = "radTheoNXB";
            this.radTheoNXB.Size = new System.Drawing.Size(96, 25);
            this.radTheoNXB.TabIndex = 5;
            this.radTheoNXB.TabStop = true;
            this.radTheoNXB.Text = "Theo NXB";
            this.radTheoNXB.UseVisualStyleBackColor = true;
            // 
            // radTheoTheLoai
            // 
            this.radTheoTheLoai.AutoSize = true;
            this.radTheoTheLoai.Location = new System.Drawing.Point(289, 38);
            this.radTheoTheLoai.Name = "radTheoTheLoai";
            this.radTheoTheLoai.Size = new System.Drawing.Size(117, 25);
            this.radTheoTheLoai.TabIndex = 6;
            this.radTheoTheLoai.TabStop = true;
            this.radTheoTheLoai.Text = "Theo thể loại";
            this.radTheoTheLoai.UseVisualStyleBackColor = true;
            // 
            // radNhomNXB
            // 
            this.radNhomNXB.AutoSize = true;
            this.radNhomNXB.Location = new System.Drawing.Point(121, 6);
            this.radNhomNXB.Name = "radNhomNXB";
            this.radNhomNXB.Size = new System.Drawing.Size(141, 25);
            this.radNhomNXB.TabIndex = 7;
            this.radNhomNXB.TabStop = true;
            this.radNhomNXB.Text = "Nhóm theo NXB";
            this.radNhomNXB.UseVisualStyleBackColor = true;
            // 
            // radNhomTheLoai
            // 
            this.radNhomTheLoai.AutoSize = true;
            this.radNhomTheLoai.Location = new System.Drawing.Point(121, 38);
            this.radNhomTheLoai.Name = "radNhomTheLoai";
            this.radNhomTheLoai.Size = new System.Drawing.Size(162, 25);
            this.radNhomTheLoai.TabIndex = 8;
            this.radNhomTheLoai.TabStop = true;
            this.radNhomTheLoai.Text = "Nhóm theo thể loại";
            this.radNhomTheLoai.UseVisualStyleBackColor = true;
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Checked = true;
            this.radTatCa.Location = new System.Drawing.Point(12, 6);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(103, 25);
            this.radTatCa.TabIndex = 9;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất cả sách";
            this.radTatCa.UseVisualStyleBackColor = true;
            // 
            // pnlReport
            // 
            this.pnlReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReport.Location = new System.Drawing.Point(0, 71);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(830, 565);
            this.pnlReport.TabIndex = 1;
            // 
            // frmBaoCaoSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(830, 636);
            this.Controls.Add(this.pnlReport);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBaoCaoSach";
            this.Text = "`";
            this.Load += new System.EventHandler(this.frmBaoCaoSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsTheLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNXB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bdsNXB;
        private System.Windows.Forms.BindingSource bdsTheLoai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cboNXB;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.RadioButton radTheoNXB;
        private System.Windows.Forms.RadioButton radTheoTheLoai;
        private System.Windows.Forms.RadioButton radNhomNXB;
        private System.Windows.Forms.RadioButton radNhomTheLoai;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.Panel pnlReport;
    }
}