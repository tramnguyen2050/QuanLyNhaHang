using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NhanVien
{
    public partial class frmBangLuong : Form
    {
        string cnStr;
        SqlConnection cn;
        public frmBangLuong()
        {
            InitializeComponent();
        }

        private void frmBangLuong_Load(object sender, EventArgs e)
        {
            cnStr = "Server = .; Database = QuanLyATC_HueTam; Integrated security = true;";
            cn = new SqlConnection(cnStr);
            List<PayChecks> lst = GetPayCheck();
            dgvBangLuong.DataSource = lst;
        }

        public List<PayChecks> GetPayCheck()
        {
            cn.Open();
            List<PayChecks> list = new List<PayChecks>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "uspTinhLuongNV";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                int maNV, socalam, hesoluong, luong;
                string hoten, chucvu, sdt;
                Boolean gioitinh;
                while (dr.Read())
                {
                    maNV = dr.GetInt32(0);
                    hoten = dr.GetString(1);
                    gioitinh = dr.GetBoolean(2);
                    chucvu = dr.GetString(3);
                    socalam = dr.GetInt32(4);
                    hesoluong = dr.GetInt32(5);
                    luong = dr.GetInt32(6);
                    sdt = dr.GetString(7);
                    PayChecks luongNV = new PayChecks(maNV, hoten, gioitinh, chucvu, socalam, hesoluong, luong, sdt);
                    list.Add(luongNV);
                    dgvBangLuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return list;
        }

        private void dgvBangLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dgvBangLuong.Rows[e.RowIndex];
                txtMaNV.Text = rows.Cells[0].Value.ToString();
                txtHoTenNV.Text = rows.Cells[1].Value.ToString();
                txtGioiTinhNV.Text = rows.Cells[2].Value.ToString();
                txtChucVu.Text = rows.Cells[3].Value.ToString();
                txtSDT.Text = rows.Cells[7].Value.ToString();
                txtSoCaLam.Text = rows.Cells[4].Value.ToString();
                txtHeSoLuong.Text = rows.Cells[5].Value.ToString();
                txtLuongThang.Text = rows.Cells[6].Value.ToString();
            }
        }

        private void frmBangLuong_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainFrm f = new MainFrm();
            f.Show();
        }

        private void btQLNV_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien f = new NhanVien();
            f.ShowDialog();
        }
    }
}
