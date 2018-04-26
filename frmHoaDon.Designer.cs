namespace NhanVien
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMaHD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTongCong = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBanSo = new System.Windows.Forms.TextBox();
            this.btThemMon = new System.Windows.Forms.Button();
            this.imlTaoMoi = new System.Windows.Forms.ImageList(this.components);
            this.btXoaMon = new System.Windows.Forms.Button();
            this.imlXoa = new System.Windows.Forms.ImageList(this.components);
            this.btTinhTien = new System.Windows.Forms.Button();
            this.imlTinhTien = new System.Windows.Forms.ImageList(this.components);
            this.btTaoMoiHD = new System.Windows.Forms.Button();
            this.btXoaHD = new System.Windows.Forms.Button();
            this.btSuaHD = new System.Windows.Forms.Button();
            this.imlCapNhat = new System.Windows.Forms.ImageList(this.components);
            this.btSuaMon = new System.Windows.Forms.Button();
            this.cbKH = new System.Windows.Forms.ComboBox();
            this.cbNV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 95);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(763, 400);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(269, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(269, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhân viên";
            // 
            // cbMaHD
            // 
            this.cbMaHD.FormattingEnabled = true;
            this.cbMaHD.Location = new System.Drawing.Point(102, 5);
            this.cbMaHD.Name = "cbMaHD";
            this.cbMaHD.Size = new System.Drawing.Size(131, 21);
            this.cbMaHD.TabIndex = 1;
            this.cbMaHD.SelectedIndexChanged += new System.EventHandler(this.cbMaHD_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày lập HD";
            // 
            // dtpNgayLapHD
            // 
            this.dtpNgayLapHD.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtpNgayLapHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLapHD.Location = new System.Drawing.Point(102, 32);
            this.dtpNgayLapHD.Name = "dtpNgayLapHD";
            this.dtpNgayLapHD.Size = new System.Drawing.Size(131, 20);
            this.dtpNgayLapHD.TabIndex = 2;
            this.dtpNgayLapHD.Value = new System.DateTime(2018, 4, 26, 21, 12, 52, 0);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(544, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng cộng:";
            // 
            // lbTongCong
            // 
            this.lbTongCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTongCong.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lbTongCong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongCong.Location = new System.Drawing.Point(631, 500);
            this.lbTongCong.Name = "lbTongCong";
            this.lbTongCong.Size = new System.Drawing.Size(124, 44);
            this.lbTongCong.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(606, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bàn số";
            // 
            // txtBanSo
            // 
            this.txtBanSo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBanSo.Location = new System.Drawing.Point(662, 6);
            this.txtBanSo.Name = "txtBanSo";
            this.txtBanSo.Size = new System.Drawing.Size(89, 20);
            this.txtBanSo.TabIndex = 4;
            // 
            // btThemMon
            // 
            this.btThemMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemMon.ImageIndex = 0;
            this.btThemMon.ImageList = this.imlTaoMoi;
            this.btThemMon.Location = new System.Drawing.Point(468, 61);
            this.btThemMon.Name = "btThemMon";
            this.btThemMon.Size = new System.Drawing.Size(90, 28);
            this.btThemMon.TabIndex = 9;
            this.btThemMon.Text = "Thêm món";
            this.btThemMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThemMon.UseVisualStyleBackColor = true;
            this.btThemMon.Click += new System.EventHandler(this.btThemMon_Click);
            // 
            // imlTaoMoi
            // 
            this.imlTaoMoi.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlTaoMoi.ImageStream")));
            this.imlTaoMoi.TransparentColor = System.Drawing.Color.Transparent;
            this.imlTaoMoi.Images.SetKeyName(0, "add (1).png");
            // 
            // btXoaMon
            // 
            this.btXoaMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoaMon.ImageIndex = 0;
            this.btXoaMon.ImageList = this.imlXoa;
            this.btXoaMon.Location = new System.Drawing.Point(675, 61);
            this.btXoaMon.Name = "btXoaMon";
            this.btXoaMon.Size = new System.Drawing.Size(80, 28);
            this.btXoaMon.TabIndex = 10;
            this.btXoaMon.Text = "Xóa món";
            this.btXoaMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoaMon.UseVisualStyleBackColor = true;
            this.btXoaMon.Click += new System.EventHandler(this.btXoaMon_Click);
            // 
            // imlXoa
            // 
            this.imlXoa.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlXoa.ImageStream")));
            this.imlXoa.TransparentColor = System.Drawing.Color.Transparent;
            this.imlXoa.Images.SetKeyName(0, "test-copy-141299972284ngk.png");
            // 
            // btTinhTien
            // 
            this.btTinhTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTinhTien.ImageIndex = 0;
            this.btTinhTien.ImageList = this.imlTinhTien;
            this.btTinhTien.Location = new System.Drawing.Point(456, 500);
            this.btTinhTien.Name = "btTinhTien";
            this.btTinhTien.Size = new System.Drawing.Size(82, 28);
            this.btTinhTien.TabIndex = 9;
            this.btTinhTien.Text = "Tính tiền";
            this.btTinhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTinhTien.UseVisualStyleBackColor = true;
            this.btTinhTien.Click += new System.EventHandler(this.btTinhTien_Click);
            // 
            // imlTinhTien
            // 
            this.imlTinhTien.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlTinhTien.ImageStream")));
            this.imlTinhTien.TransparentColor = System.Drawing.Color.Transparent;
            this.imlTinhTien.Images.SetKeyName(0, "dollar.png");
            // 
            // btTaoMoiHD
            // 
            this.btTaoMoiHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTaoMoiHD.ImageIndex = 0;
            this.btTaoMoiHD.ImageList = this.imlTaoMoi;
            this.btTaoMoiHD.Location = new System.Drawing.Point(3, 61);
            this.btTaoMoiHD.Name = "btTaoMoiHD";
            this.btTaoMoiHD.Size = new System.Drawing.Size(94, 28);
            this.btTaoMoiHD.TabIndex = 7;
            this.btTaoMoiHD.Text = "Tạo mới HĐ";
            this.btTaoMoiHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTaoMoiHD.UseVisualStyleBackColor = true;
            this.btTaoMoiHD.Click += new System.EventHandler(this.btTaoMoiHD_Click);
            // 
            // btXoaHD
            // 
            this.btXoaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoaHD.ImageIndex = 0;
            this.btXoaHD.ImageList = this.imlXoa;
            this.btXoaHD.Location = new System.Drawing.Point(207, 61);
            this.btXoaHD.Name = "btXoaHD";
            this.btXoaHD.Size = new System.Drawing.Size(75, 28);
            this.btXoaHD.TabIndex = 8;
            this.btXoaHD.Text = "Xóa HĐ";
            this.btXoaHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoaHD.UseVisualStyleBackColor = true;
            this.btXoaHD.Click += new System.EventHandler(this.btXoaHD_Click);
            // 
            // btSuaHD
            // 
            this.btSuaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSuaHD.ImageIndex = 0;
            this.btSuaHD.ImageList = this.imlCapNhat;
            this.btSuaHD.Location = new System.Drawing.Point(103, 61);
            this.btSuaHD.Name = "btSuaHD";
            this.btSuaHD.Size = new System.Drawing.Size(98, 28);
            this.btSuaHD.TabIndex = 6;
            this.btSuaHD.Text = "Cập nhật HĐ";
            this.btSuaHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSuaHD.UseVisualStyleBackColor = true;
            this.btSuaHD.Click += new System.EventHandler(this.btSuaHD_Click);
            // 
            // imlCapNhat
            // 
            this.imlCapNhat.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlCapNhat.ImageStream")));
            this.imlCapNhat.TransparentColor = System.Drawing.Color.Transparent;
            this.imlCapNhat.Images.SetKeyName(0, "create-a-documents-icon-63285.png");
            // 
            // btSuaMon
            // 
            this.btSuaMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSuaMon.ImageIndex = 0;
            this.btSuaMon.ImageList = this.imlCapNhat;
            this.btSuaMon.Location = new System.Drawing.Point(564, 61);
            this.btSuaMon.Name = "btSuaMon";
            this.btSuaMon.Size = new System.Drawing.Size(105, 28);
            this.btSuaMon.TabIndex = 11;
            this.btSuaMon.Text = "Cập nhật món";
            this.btSuaMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSuaMon.UseVisualStyleBackColor = true;
            this.btSuaMon.Click += new System.EventHandler(this.btSuaMon_Click);
            // 
            // cbKH
            // 
            this.cbKH.FormattingEnabled = true;
            this.cbKH.Location = new System.Drawing.Point(368, 7);
            this.cbKH.Name = "cbKH";
            this.cbKH.Size = new System.Drawing.Size(190, 21);
            this.cbKH.TabIndex = 12;
            // 
            // cbNV
            // 
            this.cbNV.FormattingEnabled = true;
            this.cbNV.Location = new System.Drawing.Point(368, 35);
            this.cbNV.Name = "cbNV";
            this.cbNV.Size = new System.Drawing.Size(190, 21);
            this.cbNV.TabIndex = 13;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(763, 553);
            this.Controls.Add(this.cbNV);
            this.Controls.Add(this.cbKH);
            this.Controls.Add(this.btSuaMon);
            this.Controls.Add(this.btSuaHD);
            this.Controls.Add(this.btXoaHD);
            this.Controls.Add(this.btTaoMoiHD);
            this.Controls.Add(this.btTinhTien);
            this.Controls.Add(this.btXoaMon);
            this.Controls.Add(this.btThemMon);
            this.Controls.Add(this.txtBanSo);
            this.Controls.Add(this.lbTongCong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpNgayLapHD);
            this.Controls.Add(this.cbMaHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hóa đơn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHoaDon_FormClosed);
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayLapHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTongCong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBanSo;
        private System.Windows.Forms.Button btThemMon;
        private System.Windows.Forms.Button btXoaMon;
        private System.Windows.Forms.Button btTinhTien;
        private System.Windows.Forms.Button btTaoMoiHD;
        private System.Windows.Forms.Button btXoaHD;
        private System.Windows.Forms.Button btSuaHD;
        private System.Windows.Forms.Button btSuaMon;
        private System.Windows.Forms.ImageList imlTaoMoi;
        private System.Windows.Forms.ImageList imlXoa;
        private System.Windows.Forms.ImageList imlCapNhat;
        private System.Windows.Forms.ComboBox cbKH;
        private System.Windows.Forms.ComboBox cbNV;
        private System.Windows.Forms.ImageList imlTinhTien;
    }
}