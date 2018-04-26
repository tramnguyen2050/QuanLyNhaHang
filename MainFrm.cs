using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NhanVien
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            
            InitializeComponent();
            //frmDelay f = new frmDelay();
            //f.ShowDialog();
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void btQLNV_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien f = new NhanVien();
            f.Show();
        }

        private void btQLHD_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmHoaDon f = new frmHoaDon();
            f.Show();
        }

        private void btQLNVL_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDatHang f = new frmDatHang();
            f.Show();
        }

        private void btDanhMuc_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDanhMuc fDanhMuc = new frmDanhMuc();
            fDanhMuc.ShowDialog();
        }
    }
}
