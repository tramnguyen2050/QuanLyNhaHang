namespace NhanVien
{
    partial class frmBangLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangLuong));
            this.dgvBangLuong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGioiTinhNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoCaLam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHeSoLuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLuongThang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btQLNV = new System.Windows.Forms.Button();
            this.imlForButton = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBangLuong
            // 
            this.dgvBangLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBangLuong.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangLuong.Location = new System.Drawing.Point(0, 191);
            this.dgvBangLuong.Name = "dgvBangLuong";
            this.dgvBangLuong.Size = new System.Drawing.Size(770, 337);
            this.dgvBangLuong.TabIndex = 0;
            this.dgvBangLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangLuong_CellClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(87, 4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(63, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Location = new System.Drawing.Point(87, 45);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.ReadOnly = true;
            this.txtHoTenNV.Size = new System.Drawing.Size(185, 20);
            this.txtHoTenNV.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giới tính";
            // 
            // txtGioiTinhNV
            // 
            this.txtGioiTinhNV.Location = new System.Drawing.Point(86, 94);
            this.txtGioiTinhNV.Name = "txtGioiTinhNV";
            this.txtGioiTinhNV.ReadOnly = true;
            this.txtGioiTinhNV.Size = new System.Drawing.Size(63, 20);
            this.txtGioiTinhNV.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Location = new System.Drawing.Point(323, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chức vụ";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtChucVu.Location = new System.Drawing.Point(375, 4);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.ReadOnly = true;
            this.txtChucVu.Size = new System.Drawing.Size(100, 20);
            this.txtChucVu.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.Location = new System.Drawing.Point(323, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "SDT";
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSDT.Location = new System.Drawing.Point(375, 45);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(100, 20);
            this.txtSDT.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(549, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số ca làm (tháng)";
            // 
            // txtSoCaLam
            // 
            this.txtSoCaLam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoCaLam.Location = new System.Drawing.Point(649, 4);
            this.txtSoCaLam.Name = "txtSoCaLam";
            this.txtSoCaLam.ReadOnly = true;
            this.txtSoCaLam.Size = new System.Drawing.Size(109, 20);
            this.txtSoCaLam.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(544, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hệ số theo chức vụ";
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeSoLuong.Location = new System.Drawing.Point(649, 45);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.ReadOnly = true;
            this.txtHeSoLuong.Size = new System.Drawing.Size(109, 20);
            this.txtHeSoLuong.TabIndex = 7;
            this.txtHeSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(556, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "Lương tháng";
            // 
            // txtLuongThang
            // 
            this.txtLuongThang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLuongThang.BackColor = System.Drawing.Color.Coral;
            this.txtLuongThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongThang.ForeColor = System.Drawing.Color.Purple;
            this.txtLuongThang.Location = new System.Drawing.Point(649, 94);
            this.txtLuongThang.Name = "txtLuongThang";
            this.txtLuongThang.ReadOnly = true;
            this.txtLuongThang.Size = new System.Drawing.Size(109, 22);
            this.txtLuongThang.TabIndex = 2;
            this.txtLuongThang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(551, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "x";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(550, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "=";
            // 
            // btQLNV
            // 
            this.btQLNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btQLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQLNV.ImageIndex = 0;
            this.btQLNV.ImageList = this.imlForButton;
            this.btQLNV.Location = new System.Drawing.Point(612, 148);
            this.btQLNV.Name = "btQLNV";
            this.btQLNV.Size = new System.Drawing.Size(146, 32);
            this.btQLNV.TabIndex = 8;
            this.btQLNV.Text = "Quản lý nhân viên";
            this.btQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btQLNV.UseVisualStyleBackColor = true;
            this.btQLNV.Click += new System.EventHandler(this.btQLNV_Click);
            // 
            // imlForButton
            // 
            this.imlForButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlForButton.ImageStream")));
            this.imlForButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlForButton.Images.SetKeyName(0, "back.png");
            // 
            // frmBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(770, 528);
            this.Controls.Add(this.btQLNV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtGioiTinhNV);
            this.Controls.Add(this.txtHoTenNV);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtLuongThang);
            this.Controls.Add(this.txtHeSoLuong);
            this.Controls.Add(this.txtSoCaLam);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBangLuong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBangLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng lương nhân viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBangLuong_FormClosed);
            this.Load += new System.EventHandler(this.frmBangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBangLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGioiTinhNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoCaLam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLuongThang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btQLNV;
        private System.Windows.Forms.ImageList imlForButton;
    }
}