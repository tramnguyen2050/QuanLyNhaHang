namespace NhanVien
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHoNV = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btLuuNV = new System.Windows.Forms.Button();
            this.imlTaoMoi = new System.Windows.Forms.ImageList(this.components);
            this.btSuaNV = new System.Windows.Forms.Button();
            this.imlCapNhat = new System.Windows.Forms.ImageList(this.components);
            this.btXoaNV = new System.Windows.Forms.Button();
            this.imlXoa = new System.Windows.Forms.ImageList(this.components);
            this.btTinhLuong = new System.Windows.Forms.Button();
            this.imlXembangLuong = new System.Windows.Forms.ImageList(this.components);
            this.cbGioiTinhNV = new System.Windows.Forms.ComboBox();
            this.lb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDTNV = new System.Windows.Forms.TextBox();
            this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoCaLam = new System.Windows.Forms.TextBox();
            this.cbMaChucVu = new System.Windows.Forms.ComboBox();
            this.btTaiLai = new System.Windows.Forms.Button();
            this.imlTaiLai = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 141);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(971, 466);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ NV";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(339, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(339, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Địa chỉ";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(114, 12);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(160, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // txtHoNV
            // 
            this.txtHoNV.Location = new System.Drawing.Point(114, 44);
            this.txtHoNV.Name = "txtHoNV";
            this.txtHoNV.Size = new System.Drawing.Size(160, 20);
            this.txtHoNV.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.Location = new System.Drawing.Point(410, 78);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(234, 20);
            this.txtDiaChi.TabIndex = 6;
            // 
            // btLuuNV
            // 
            this.btLuuNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuuNV.ImageIndex = 0;
            this.btLuuNV.ImageList = this.imlTaoMoi;
            this.btLuuNV.Location = new System.Drawing.Point(9, 107);
            this.btLuuNV.Name = "btLuuNV";
            this.btLuuNV.Size = new System.Drawing.Size(93, 28);
            this.btLuuNV.TabIndex = 10;
            this.btLuuNV.Text = "Tạo mới NV";
            this.btLuuNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLuuNV.UseVisualStyleBackColor = true;
            this.btLuuNV.Click += new System.EventHandler(this.btLuuNV_Click);
            // 
            // imlTaoMoi
            // 
            this.imlTaoMoi.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlTaoMoi.ImageStream")));
            this.imlTaoMoi.TransparentColor = System.Drawing.Color.Transparent;
            this.imlTaoMoi.Images.SetKeyName(0, "add (1).png");
            // 
            // btSuaNV
            // 
            this.btSuaNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btSuaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSuaNV.ImageIndex = 0;
            this.btSuaNV.ImageList = this.imlCapNhat;
            this.btSuaNV.Location = new System.Drawing.Point(108, 108);
            this.btSuaNV.Name = "btSuaNV";
            this.btSuaNV.Size = new System.Drawing.Size(98, 27);
            this.btSuaNV.TabIndex = 11;
            this.btSuaNV.Text = "Cập nhật NV";
            this.btSuaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSuaNV.UseVisualStyleBackColor = true;
            this.btSuaNV.Click += new System.EventHandler(this.btSuaNV_Click);
            // 
            // imlCapNhat
            // 
            this.imlCapNhat.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlCapNhat.ImageStream")));
            this.imlCapNhat.TransparentColor = System.Drawing.Color.Transparent;
            this.imlCapNhat.Images.SetKeyName(0, "create-a-documents-icon-63285.png");
            // 
            // btXoaNV
            // 
            this.btXoaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btXoaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoaNV.ImageIndex = 0;
            this.btXoaNV.ImageList = this.imlXoa;
            this.btXoaNV.Location = new System.Drawing.Point(212, 108);
            this.btXoaNV.Name = "btXoaNV";
            this.btXoaNV.Size = new System.Drawing.Size(56, 27);
            this.btXoaNV.TabIndex = 12;
            this.btXoaNV.Text = "Xóa";
            this.btXoaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoaNV.UseVisualStyleBackColor = true;
            this.btXoaNV.Click += new System.EventHandler(this.btXoaNV_Click);
            // 
            // imlXoa
            // 
            this.imlXoa.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlXoa.ImageStream")));
            this.imlXoa.TransparentColor = System.Drawing.Color.Transparent;
            this.imlXoa.Images.SetKeyName(0, "test-copy-141299972284ngk.png");
            // 
            // btTinhLuong
            // 
            this.btTinhLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTinhLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTinhLuong.ImageIndex = 0;
            this.btTinhLuong.ImageList = this.imlXembangLuong;
            this.btTinhLuong.Location = new System.Drawing.Point(842, 108);
            this.btTinhLuong.Name = "btTinhLuong";
            this.btTinhLuong.Size = new System.Drawing.Size(117, 28);
            this.btTinhLuong.TabIndex = 13;
            this.btTinhLuong.Text = "Xem bảng lương";
            this.btTinhLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTinhLuong.UseVisualStyleBackColor = true;
            this.btTinhLuong.Click += new System.EventHandler(this.btTinhLuong_Click);
            // 
            // imlXembangLuong
            // 
            this.imlXembangLuong.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlXembangLuong.ImageStream")));
            this.imlXembangLuong.TransparentColor = System.Drawing.Color.Transparent;
            this.imlXembangLuong.Images.SetKeyName(0, "next.png");
            // 
            // cbGioiTinhNV
            // 
            this.cbGioiTinhNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGioiTinhNV.FormattingEnabled = true;
            this.cbGioiTinhNV.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinhNV.Location = new System.Drawing.Point(410, 11);
            this.cbGioiTinhNV.Name = "cbGioiTinhNV";
            this.cbGioiTinhNV.Size = new System.Drawing.Size(121, 21);
            this.cbGioiTinhNV.TabIndex = 4;
            // 
            // lb
            // 
            this.lb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb.Location = new System.Drawing.Point(339, 47);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(73, 23);
            this.lb.TabIndex = 1;
            this.lb.Text = "Chức vụ";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(692, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày vào làm";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(692, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số điện thoại";
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDTNV.Location = new System.Drawing.Point(773, 79);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(186, 20);
            this.txtSDTNV.TabIndex = 9;
            // 
            // dtpNgayVaoLam
            // 
            this.dtpNgayVaoLam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayVaoLam.CustomFormat = "yyyy/mm/dd";
            this.dtpNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(773, 12);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(186, 20);
            this.dtpNgayVaoLam.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên NV";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(115, 78);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(160, 20);
            this.txtTenNV.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(692, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Số ca làm";
            // 
            // txtSoCaLam
            // 
            this.txtSoCaLam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoCaLam.Location = new System.Drawing.Point(773, 44);
            this.txtSoCaLam.Name = "txtSoCaLam";
            this.txtSoCaLam.Size = new System.Drawing.Size(186, 20);
            this.txtSoCaLam.TabIndex = 8;
            // 
            // cbMaChucVu
            // 
            this.cbMaChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMaChucVu.FormattingEnabled = true;
            this.cbMaChucVu.Location = new System.Drawing.Point(410, 43);
            this.cbMaChucVu.Name = "cbMaChucVu";
            this.cbMaChucVu.Size = new System.Drawing.Size(121, 21);
            this.cbMaChucVu.TabIndex = 5;
            // 
            // btTaiLai
            // 
            this.btTaiLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTaiLai.ImageIndex = 1;
            this.btTaiLai.ImageList = this.imlTaiLai;
            this.btTaiLai.Location = new System.Drawing.Point(274, 108);
            this.btTaiLai.Name = "btTaiLai";
            this.btTaiLai.Size = new System.Drawing.Size(61, 27);
            this.btTaiLai.TabIndex = 14;
            this.btTaiLai.Text = "Tải lại";
            this.btTaiLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTaiLai.UseVisualStyleBackColor = true;
            this.btTaiLai.Click += new System.EventHandler(this.btTaiLai_Click);
            // 
            // imlTaiLai
            // 
            this.imlTaiLai.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlTaiLai.ImageStream")));
            this.imlTaiLai.TransparentColor = System.Drawing.Color.Transparent;
            this.imlTaiLai.Images.SetKeyName(0, "icon-refresh-128.png");
            this.imlTaiLai.Images.SetKeyName(1, "refresh.png");
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(971, 607);
            this.Controls.Add(this.btTaiLai);
            this.Controls.Add(this.dtpNgayVaoLam);
            this.Controls.Add(this.cbMaChucVu);
            this.Controls.Add(this.cbGioiTinhNV);
            this.Controls.Add(this.btTinhLuong);
            this.Controls.Add(this.btXoaNV);
            this.Controls.Add(this.btSuaNV);
            this.Controls.Add(this.btLuuNV);
            this.Controls.Add(this.txtSoCaLam);
            this.Controls.Add(this.txtSDTNV);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtHoNV);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNhanVien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NhanVien_FormClosed);
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtHoNV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btLuuNV;
        private System.Windows.Forms.Button btSuaNV;
        private System.Windows.Forms.Button btXoaNV;
        private System.Windows.Forms.Button btTinhLuong;
        private System.Windows.Forms.ComboBox cbGioiTinhNV;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDTNV;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoCaLam;
        private System.Windows.Forms.ComboBox cbMaChucVu;
        private System.Windows.Forms.ImageList imlTaoMoi;
        private System.Windows.Forms.ImageList imlCapNhat;
        private System.Windows.Forms.ImageList imlXoa;
        private System.Windows.Forms.ImageList imlXembangLuong;
        private System.Windows.Forms.Button btTaiLai;
        private System.Windows.Forms.ImageList imlTaiLai;
    }
}

