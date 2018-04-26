namespace NhanVien
{
    partial class frmThemMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemMon));
            this.cbMaHD = new System.Windows.Forms.ComboBox();
            this.cbMonAn = new System.Windows.Forms.ComboBox();
            this.nudSoLuongMon = new System.Windows.Forms.NumericUpDown();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvThemMon = new System.Windows.Forms.DataGridView();
            this.btLuuThemMon = new System.Windows.Forms.Button();
            this.imlLuu = new System.Windows.Forms.ImageList(this.components);
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemMon)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMaHD
            // 
            this.cbMaHD.FormattingEnabled = true;
            this.cbMaHD.Location = new System.Drawing.Point(52, 18);
            this.cbMaHD.Name = "cbMaHD";
            this.cbMaHD.Size = new System.Drawing.Size(78, 21);
            this.cbMaHD.TabIndex = 0;
            this.cbMaHD.SelectedIndexChanged += new System.EventHandler(this.cbMaHD_SelectedIndexChanged);
            // 
            // cbMonAn
            // 
            this.cbMonAn.FormattingEnabled = true;
            this.cbMonAn.Location = new System.Drawing.Point(196, 18);
            this.cbMonAn.Name = "cbMonAn";
            this.cbMonAn.Size = new System.Drawing.Size(219, 21);
            this.cbMonAn.TabIndex = 1;
            this.cbMonAn.SelectedIndexChanged += new System.EventHandler(this.cbMonAn_SelectedIndexChanged);
            // 
            // nudSoLuongMon
            // 
            this.nudSoLuongMon.Location = new System.Drawing.Point(669, 19);
            this.nudSoLuongMon.Name = "nudSoLuongMon";
            this.nudSoLuongMon.Size = new System.Drawing.Size(56, 20);
            this.nudSoLuongMon.TabIndex = 3;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(807, 18);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(100, 20);
            this.txtThanhTien.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(908, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "VNĐ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã HĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Món ăn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(748, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thành tiền";
            // 
            // dgvThemMon
            // 
            this.dgvThemMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThemMon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvThemMon.Location = new System.Drawing.Point(0, 83);
            this.dgvThemMon.Name = "dgvThemMon";
            this.dgvThemMon.Size = new System.Drawing.Size(948, 319);
            this.dgvThemMon.TabIndex = 9;
            // 
            // btLuuThemMon
            // 
            this.btLuuThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuuThemMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuuThemMon.ImageIndex = 0;
            this.btLuuThemMon.ImageList = this.imlLuu;
            this.btLuuThemMon.Location = new System.Drawing.Point(11, 48);
            this.btLuuThemMon.Name = "btLuuThemMon";
            this.btLuuThemMon.Size = new System.Drawing.Size(65, 27);
            this.btLuuThemMon.TabIndex = 5;
            this.btLuuThemMon.Text = "Lưu";
            this.btLuuThemMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLuuThemMon.UseVisualStyleBackColor = true;
            this.btLuuThemMon.Click += new System.EventHandler(this.btLuuThemMon_Click);
            // 
            // imlLuu
            // 
            this.imlLuu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlLuu.ImageStream")));
            this.imlLuu.TransparentColor = System.Drawing.Color.Transparent;
            this.imlLuu.Images.SetKeyName(0, "save.png");
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(499, 18);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Đơn giá";
            // 
            // frmThemMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 402);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.btLuuThemMon);
            this.Controls.Add(this.dgvThemMon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.nudSoLuongMon);
            this.Controls.Add(this.cbMonAn);
            this.Controls.Add(this.cbMaHD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThemMon";
            this.Text = "Thêm món";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmThemMon_FormClosed);
            this.Load += new System.EventHandler(this.frmThemMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMaHD;
        private System.Windows.Forms.ComboBox cbMonAn;
        private System.Windows.Forms.NumericUpDown nudSoLuongMon;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvThemMon;
        private System.Windows.Forms.Button btLuuThemMon;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList imlLuu;
    }
}