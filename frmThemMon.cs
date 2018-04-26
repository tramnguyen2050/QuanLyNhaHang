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
    public partial class frmThemMon : Form
    {
        string cnStr = "";
        SqlConnection cn;
        DataSet ds;
        DataTable dt = new DataTable();

        public delegate void loadHoaDon(string sql);
        public event loadHoaDon HoaDon;

        public frmThemMon()
        {
            InitializeComponent();
        }

        private void frmThemMon_Load(object sender, EventArgs e)
        {
            cnStr = "Server = .; Database = QuanLyATC_HueTam; Integrated security = true;";
            cn = new SqlConnection(cnStr);

            string sqlMaHD = "SELECT * FROM ORDERS";
            dt = ThemMon(sqlMaHD).Tables[0];
            cbMaHD.DataSource = dt;
            cbMaHD.DisplayMember = "ID_Orders";
            cbMaHD.ValueMember = "ID_Orders";

            string sqlMonAn = "SELECT * FROM MON";
            dt = ThemMon(sqlMonAn).Tables[0];
            cbMonAn.ValueMember = dt.Columns["ID_Mon"].ColumnName;
            cbMonAn.DisplayMember = dt.Columns["Ten_Mon"].ColumnName;
            cbMonAn.DataSource = dt;
        }

        public DataSet ThemMon(string sql)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                cn.Close();
            }
        }

        public void loadThemMon()
        {
           // cn.Open();
            try
            {
                string sql = "SELECT Ten_Mon, mord.SoLuong, mord.DonGia, (mon.DonGia*SoLuong) AS ThanhTien FROM MON_ORDERS mord JOIN ORDERS ord ON ord.ID_Orders = mord.ID_Orders JOIN MON mon ON mon.ID_Mon = mord.ID_Mon WHERE ord.ID_Orders = '" + cbMaHD.Text + "'";
                dgvThemMon.DataSource = ThemMon(sql).Tables[0];
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

            finally
            {
                //cn.Close();
            }
        }

        private void cbMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadThemMon();
            dgvThemMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btLuuThemMon_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                string sql = "INSERT INTO MON_ORDERS(ID_Orders, ID_Mon, SoLuong, DonGia) VALUES ('" + cbMaHD.Text + "', '" + cbMonAn.SelectedValue.ToString() + "', '" + nudSoLuongMon.Value + "', '" + txtDonGia.Text + "')";

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;

                if (MessageBox.Show("Bạn muốn lưu thêm món?", "Xác nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    loadThemMon();
                    MessageBox.Show("Thêm món thành công.");
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

            finally
            {
                cn.Close();
            }
        }

        private void cbMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string sql = "SELECT DonGia FROM MON WHERE ID_Mon = '" + cbMonAn.SelectedValue.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sql, cn);
                int DonGia = (int)cmd.ExecuteScalar();

                txtDonGia.Text = Convert.ToString(DonGia);
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void frmThemMon_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            frmHoaDon f = new frmHoaDon();
            f.Show();
        }

        

    }
}
