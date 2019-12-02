namespace QuanLyCuaHangSach
{
    partial class frmSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSach));
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtTimKiemTheoMa = new System.Windows.Forms.TextBox();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSach = new System.Windows.Forms.Panel();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTacGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTacGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTheLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTheLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayXuatBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anhBiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsSach = new System.Windows.Forms.BindingSource(this.components);
            this.panel6.SuspendLayout();
            this.pnlSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGreen;
            this.panel6.Controls.Add(this.comboBox1);
            this.panel6.Controls.Add(this.btnLoc);
            this.panel6.Controls.Add(this.btnTimKiem);
            this.panel6.Controls.Add(this.txtTimKiem);
            this.panel6.Controls.Add(this.txtTimKiemTheoMa);
            this.panel6.Controls.Add(this.cboTimKiem);
            this.panel6.Controls.Add(this.btnXoa);
            this.panel6.Controls.Add(this.btnSua);
            this.panel6.Controls.Add(this.btnThem);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(10, 10);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(997, 54);
            this.panel6.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã NV",
            "Họ Tên"});
            this.comboBox1.Location = new System.Drawing.Point(894, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 29);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Visible = false;
            // 
            // btnLoc
            // 
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLoc.Image")));
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.Location = new System.Drawing.Point(803, 0);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(84, 54);
            this.btnLoc.TabIndex = 14;
            this.btnLoc.Text = "Lọc theo";
            this.btnLoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Visible = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.Location = new System.Drawing.Point(285, 0);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(124, 54);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = " Tìm kiếm theo";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(545, 14);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(235, 29);
            this.txtTimKiem.TabIndex = 12;
            this.txtTimKiem.Visible = false;
            this.txtTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyUp);
            // 
            // txtTimKiemTheoMa
            // 
            this.txtTimKiemTheoMa.Location = new System.Drawing.Point(545, 14);
            this.txtTimKiemTheoMa.Name = "txtTimKiemTheoMa";
            this.txtTimKiemTheoMa.Size = new System.Drawing.Size(235, 29);
            this.txtTimKiemTheoMa.TabIndex = 12;
            this.txtTimKiemTheoMa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiemTheoMa_KeyPress);
            this.txtTimKiemTheoMa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimKiemTheoMa_KeyUp);
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Items.AddRange(new object[] {
            "Mã sách",
            "Tên sách",
            "Tác giả",
            "Thể loại",
            "NXB"});
            this.cboTimKiem.Location = new System.Drawing.Point(416, 14);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(123, 29);
            this.cboTimKiem.TabIndex = 10;
            this.cboTimKiem.SelectedIndexChanged += new System.EventHandler(this.cboTimKiem_SelectedIndexChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(190, 0);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 54);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = " Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(95, 0);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 54);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = " Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 54);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = " Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1007, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 560);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 570);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1007, 10);
            this.panel5.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 10);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 580);
            this.panel1.TabIndex = 11;
            // 
            // pnlSach
            // 
            this.pnlSach.Controls.Add(this.dgvSach);
            this.pnlSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSach.Location = new System.Drawing.Point(10, 64);
            this.pnlSach.Name = "pnlSach";
            this.pnlSach.Size = new System.Drawing.Size(997, 506);
            this.pnlSach.TabIndex = 16;
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.AutoGenerateColumns = false;
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.tenDataGridViewTextBoxColumn,
            this.maTacGiaDataGridViewTextBoxColumn,
            this.tenTacGiaDataGridViewTextBoxColumn,
            this.maTheLoaiDataGridViewTextBoxColumn,
            this.tenTheLoaiDataGridViewTextBoxColumn,
            this.ngayXuatBanDataGridViewTextBoxColumn,
            this.maNXBDataGridViewTextBoxColumn,
            this.tenNXBDataGridViewTextBoxColumn,
            this.giaBiaDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.anhBiaDataGridViewTextBoxColumn,
            this.xoaDataGridViewCheckBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.dgvSach.DataSource = this.bdsSach;
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.Location = new System.Drawing.Point(0, 0);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(997, 506);
            this.dgvSach.TabIndex = 0;
            // 
            // colMaSach
            // 
            this.colMaSach.DataPropertyName = "MaSach";
            this.colMaSach.HeaderText = "Mã sách";
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.ReadOnly = true;
            this.colMaSach.Width = 92;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tên sách";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenDataGridViewTextBoxColumn.Width = 93;
            // 
            // maTacGiaDataGridViewTextBoxColumn
            // 
            this.maTacGiaDataGridViewTextBoxColumn.DataPropertyName = "MaTacGia";
            this.maTacGiaDataGridViewTextBoxColumn.HeaderText = "MaTacGia";
            this.maTacGiaDataGridViewTextBoxColumn.Name = "maTacGiaDataGridViewTextBoxColumn";
            this.maTacGiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.maTacGiaDataGridViewTextBoxColumn.Visible = false;
            this.maTacGiaDataGridViewTextBoxColumn.Width = 82;
            // 
            // tenTacGiaDataGridViewTextBoxColumn
            // 
            this.tenTacGiaDataGridViewTextBoxColumn.DataPropertyName = "TenTacGia";
            this.tenTacGiaDataGridViewTextBoxColumn.HeaderText = "Tác giả";
            this.tenTacGiaDataGridViewTextBoxColumn.Name = "tenTacGiaDataGridViewTextBoxColumn";
            this.tenTacGiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenTacGiaDataGridViewTextBoxColumn.Width = 81;
            // 
            // maTheLoaiDataGridViewTextBoxColumn
            // 
            this.maTheLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaTheLoai";
            this.maTheLoaiDataGridViewTextBoxColumn.HeaderText = "MaTheLoai";
            this.maTheLoaiDataGridViewTextBoxColumn.Name = "maTheLoaiDataGridViewTextBoxColumn";
            this.maTheLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.maTheLoaiDataGridViewTextBoxColumn.Visible = false;
            this.maTheLoaiDataGridViewTextBoxColumn.Width = 86;
            // 
            // tenTheLoaiDataGridViewTextBoxColumn
            // 
            this.tenTheLoaiDataGridViewTextBoxColumn.DataPropertyName = "TenTheLoai";
            this.tenTheLoaiDataGridViewTextBoxColumn.HeaderText = "Thể loại";
            this.tenTheLoaiDataGridViewTextBoxColumn.Name = "tenTheLoaiDataGridViewTextBoxColumn";
            this.tenTheLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenTheLoaiDataGridViewTextBoxColumn.Width = 89;
            // 
            // ngayXuatBanDataGridViewTextBoxColumn
            // 
            this.ngayXuatBanDataGridViewTextBoxColumn.DataPropertyName = "NgayXuatBan";
            this.ngayXuatBanDataGridViewTextBoxColumn.HeaderText = "Ngày xuất bản";
            this.ngayXuatBanDataGridViewTextBoxColumn.Name = "ngayXuatBanDataGridViewTextBoxColumn";
            this.ngayXuatBanDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayXuatBanDataGridViewTextBoxColumn.Width = 135;
            // 
            // maNXBDataGridViewTextBoxColumn
            // 
            this.maNXBDataGridViewTextBoxColumn.DataPropertyName = "MaNXB";
            this.maNXBDataGridViewTextBoxColumn.HeaderText = "MaNXB";
            this.maNXBDataGridViewTextBoxColumn.Name = "maNXBDataGridViewTextBoxColumn";
            this.maNXBDataGridViewTextBoxColumn.ReadOnly = true;
            this.maNXBDataGridViewTextBoxColumn.Visible = false;
            this.maNXBDataGridViewTextBoxColumn.Width = 69;
            // 
            // tenNXBDataGridViewTextBoxColumn
            // 
            this.tenNXBDataGridViewTextBoxColumn.DataPropertyName = "TenNXB";
            this.tenNXBDataGridViewTextBoxColumn.HeaderText = "Nhà xuất bản";
            this.tenNXBDataGridViewTextBoxColumn.Name = "tenNXBDataGridViewTextBoxColumn";
            this.tenNXBDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenNXBDataGridViewTextBoxColumn.Width = 127;
            // 
            // giaBiaDataGridViewTextBoxColumn
            // 
            this.giaBiaDataGridViewTextBoxColumn.DataPropertyName = "GiaBia";
            this.giaBiaDataGridViewTextBoxColumn.HeaderText = "Giá bìa";
            this.giaBiaDataGridViewTextBoxColumn.Name = "giaBiaDataGridViewTextBoxColumn";
            this.giaBiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.giaBiaDataGridViewTextBoxColumn.Width = 83;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            this.soLuongDataGridViewTextBoxColumn.Width = 98;
            // 
            // anhBiaDataGridViewTextBoxColumn
            // 
            this.anhBiaDataGridViewTextBoxColumn.DataPropertyName = "AnhBia";
            this.anhBiaDataGridViewTextBoxColumn.HeaderText = "AnhBia";
            this.anhBiaDataGridViewTextBoxColumn.Name = "anhBiaDataGridViewTextBoxColumn";
            this.anhBiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.anhBiaDataGridViewTextBoxColumn.Visible = false;
            this.anhBiaDataGridViewTextBoxColumn.Width = 66;
            // 
            // xoaDataGridViewCheckBoxColumn
            // 
            this.xoaDataGridViewCheckBoxColumn.DataPropertyName = "Xoa";
            this.xoaDataGridViewCheckBoxColumn.HeaderText = "Xoa";
            this.xoaDataGridViewCheckBoxColumn.Name = "xoaDataGridViewCheckBoxColumn";
            this.xoaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.xoaDataGridViewCheckBoxColumn.Visible = false;
            this.xoaDataGridViewCheckBoxColumn.Width = 32;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.ReadOnly = true;
            this.ghiChuDataGridViewTextBoxColumn.Width = 88;
            // 
            // bdsSach
            // 
            this.bdsSach.DataSource = typeof(DTO.SachDTO);
            // 
            // frmSach
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1017, 580);
            this.Controls.Add(this.pnlSach);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSach";
            this.Text = "frmSach";
            this.Load += new System.EventHandler(this.frmSach_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnlSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSach;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTacGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTacGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTheLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTheLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayXuatBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNXBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNXBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anhBiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xoaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsSach;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemTheoMa;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}