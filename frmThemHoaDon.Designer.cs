namespace NhanVien
{
    partial class frmThemHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemHoaDon));
            this.dtpNgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBanSo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btLuu = new System.Windows.Forms.Button();
            this.imlLuu = new System.Windows.Forms.ImageList(this.components);
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtpNgayLapHD
            // 
            this.dtpNgayLapHD.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtpNgayLapHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLapHD.Location = new System.Drawing.Point(101, 66);
            this.dtpNgayLapHD.Name = "dtpNgayLapHD";
            this.dtpNgayLapHD.Size = new System.Drawing.Size(193, 20);
            this.dtpNgayLapHD.TabIndex = 3;
            this.dtpNgayLapHD.Value = new System.DateTime(2018, 4, 26, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày lập HD";
            // 
            // txtBanSo
            // 
            this.txtBanSo.Location = new System.Drawing.Point(101, 92);
            this.txtBanSo.Name = "txtBanSo";
            this.txtBanSo.Size = new System.Drawing.Size(193, 20);
            this.txtBanSo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "Khách hàng";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "Bàn số";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(7, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 26);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nhân viên";
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.ImageIndex = 0;
            this.btLuu.ImageList = this.imlLuu;
            this.btLuu.Location = new System.Drawing.Point(101, 118);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(60, 25);
            this.btLuu.TabIndex = 5;
            this.btLuu.Text = "Lưu";
            this.btLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // imlLuu
            // 
            this.imlLuu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlLuu.ImageStream")));
            this.imlLuu.TransparentColor = System.Drawing.Color.Transparent;
            this.imlLuu.Images.SetKeyName(0, "save.png");
            // 
            // cbMaKH
            // 
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(101, 12);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(193, 21);
            this.cbMaKH.TabIndex = 1;
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(101, 39);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(193, 21);
            this.cbMaNV.TabIndex = 2;
            // 
            // frmThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 150);
            this.Controls.Add(this.cbMaNV);
            this.Controls.Add(this.cbMaKH);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBanSo);
            this.Controls.Add(this.dtpNgayLapHD);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThemHoaDon";
            this.Text = "Tạo mới hóa đơn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmThemHoaDon_FormClosed);
            this.Load += new System.EventHandler(this.frmThemHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayLapHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBanSo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.ComboBox cbMaKH;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.ImageList imlLuu;
    }
}