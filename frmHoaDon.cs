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
    public partial class frmHoaDon : Form
    {
        string cnStr = "";
        SqlConnection cn;
        DataSet ds;
        DataTable orders = new DataTable();
        private string mahd;

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            cnStr = "Server = .; Database = QuanLyATC_HueTam; Integrated security = true;";
            cn = new SqlConnection(cnStr);

            string sql = "SELECT od.ID_Orders, od.ID_KH, (kh.Ho_KH + ' ' + kh.Ten_KH) AS 'TenKH', od.ID_NV, (nv.Ho_NV + ' ' + nv.Ten_NV) AS 'TenNV', od.NgayGioDat, od.BanSo FROM dbo.ORDERS od JOIN dbo.KHACHHANG kh ON od.ID_KH = kh.ID_KH JOIN dbo.NHANVIEN nv ON od.ID_NV = nv.ID_NV";
            orders = GetOrders(sql).Tables[0];
            cbMaHD.DataSource = orders;
            cbMaHD.DisplayMember = "ID_Orders";
            cbMaHD.ValueMember = "ID_Orders";

            cbKH.DataBindings.Add("Text", orders, "TenKH");
            cbNV.DataBindings.Add("Text", orders, "TenNV");
            dtpNgayLapHD.DataBindings.Add("Text", orders, "NgayGioDat");
            txtBanSo.DataBindings.Add("Text", orders, "BanSo");

            //load dữ liệu lên cbKH
            string sqlKH = "SELECT ID_KH, (Ho_KH + ' ' + Ten_KH) AS TenDayDu FROM KHACHHANG";
            orders = GetOrders(sqlKH).Tables[0];
            cbKH.DataSource = orders;
            cbKH.DisplayMember = orders.Columns["TenDayDu"].ColumnName;
            cbKH.ValueMember = orders.Columns["ID_KH"].ColumnName;

            //load dữ liệu lên cbNV
            string sqlNV = "SELECT ID_NV, (Ho_NV + ' ' + Ten_NV) AS TenDayDu FROM NHANVIEN";
            orders = GetOrders(sqlNV).Tables[0];
            cbNV.DataSource = orders;
            cbNV.DisplayMember = orders.Columns["TenDayDu"].ColumnName;
            cbNV.ValueMember = orders.Columns["ID_NV"].ColumnName;
        }

        public DataSet GetOrders(string sql)
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

        

        public void load(string sql)
        {
            dgvHoaDon.DataSource = GetOrders(sql).Tables[0];
        }

        private void cbMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT mord.ID_Mon, Ten_Mon, mord.SoLuong, mord.DonGia, (mon.DonGia*SoLuong) AS ThanhTien FROM MON_ORDERS mord JOIN ORDERS ord ON ord.ID_Orders = mord.ID_Orders JOIN MON mon ON mon.ID_Mon = mord.ID_Mon WHERE ord.ID_Orders = '" + cbMaHD.Text + "'";
                dgvHoaDon.DataSource = GetOrders(sql).Tables[0];
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

        private void frmHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainFrm f = new MainFrm();
            f.Show();
        }

        private void btThemMon_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThemMon frmthemmon = new frmThemMon();
            frmthemmon.ShowDialog();
        }

        void frmthemmon_HoaDon(string mahoadon)
        {
            try
            {
                string sql = "SELECT mord.ID_Mon, Ten_Mon, mord.SoLuong, mord.DonGia, (mon.DonGia*SoLuong) AS ThanhTien FROM MON_ORDERS mord JOIN ORDERS ord ON ord.ID_Orders = mord.ID_Orders JOIN MON mon ON mon.ID_Mon = mord.ID_Mon WHERE ord.ID_Orders = '" + mahoadon + "'";
                dgvHoaDon.DataSource = GetOrders(sql).Tables[0];
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvHoaDon.Rows[e.RowIndex];
            }
        }

        private void btXoaMon_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {

                int CurrentIndex = dgvHoaDon.CurrentCell.RowIndex;
                string MaMon = Convert.ToString(dgvHoaDon.Rows[CurrentIndex].Cells[0].Value.ToString());

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "uspXoaMonHoaDon";
                cmd.Parameters.Add(new SqlParameter("@MaHD", cbMaHD.Text));
                cmd.Parameters.Add(new SqlParameter("@MaMon", MaMon));
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
     
                if (MessageBox.Show("Bạn muốn xóa món này?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    lbTongCong.Text = "";
                    dgvHoaDon.DataSource = GetOrder();
                    MessageBox.Show("Xóa món thành công.");
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

        public void SetNull()
        {
            cbMaHD.Text = "";
            dtpNgayLapHD.Text = "";
            cbKH.Text = "";
            txtBanSo.Text = "";
            cbNV.Text = "";
        }

        public List<Orders> GetOrder()
        {
            List<Orders> listorder = new List<Orders>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "uspXemChitietHoaDon";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHD", cbMaHD.Text));
                SqlDataReader dr = cmd.ExecuteReader();

                string mamon, tenmon;
                int soluong, dongia, thanhtien;
                while(dr.Read())
                {
                    mamon = dr.GetString(0);
                    tenmon = dr.GetString(1);
                    soluong = dr.GetInt32(2);
                    dongia = dr.GetInt32(3);
                    thanhtien = dr.GetInt32(4);
                    Orders cthd = new Orders(mamon, tenmon, soluong, dongia, thanhtien);
                    listorder.Add(cthd);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            return listorder;
        }

         public void TinhTien()
         {
             try
             {
                 cn.Open();
                 string sqlTotal = "SELECT (SUM(DonGia*SoLuong)) AS TongTien FROM MON_ORDERS WHERE ID_Orders = '" + cbMaHD.Text + "'";
                 SqlCommand cmd = new SqlCommand(sqlTotal, cn);
                 int TongTien = (int)cmd.ExecuteScalar();
                 lbTongCong.Text = Convert.ToString(TongTien);
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

         private void btTinhTien_Click(object sender, EventArgs e)
         {
             TinhTien();
         }

         public string goiform
         {
             get { return mahd; }
             set { mahd = value; }
         }

         private void btSuaHD_Click(object sender, EventArgs e)
         {
             cn.Open();
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.CommandText = "uspSuaHoaDon";
                 cmd.Connection = cn;
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add(new SqlParameter("@MaHoaDon", cbMaHD.Text));
                 cmd.Parameters.Add(new SqlParameter("@MaKH", cbKH.SelectedValue.ToString()));
                 cmd.Parameters.Add(new SqlParameter("@MaNV", cbNV.SelectedValue.ToString()));
                 cmd.Parameters.Add(new SqlParameter("@NgayGioDat", dtpNgayLapHD.Text));
                 cmd.Parameters.Add(new SqlParameter("@BanSo", txtBanSo.Text));

                 if (MessageBox.Show("Bạn muốn cập nhật?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                 {
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("Cập nhật thành công.");
                     string sql = "SELECT mord.ID_Mon, Ten_Mon, mord.SoLuong, mord.DonGia, (mon.DonGia*SoLuong) AS ThanhTien FROM MON_ORDERS mord JOIN ORDERS ord ON ord.ID_Orders = mord.ID_Orders JOIN MON mon ON mon.ID_Mon = mord.ID_Mon WHERE ord.ID_Orders = '" + cbMaHD.Text + "'";
                     dgvHoaDon.DataSource = GetOrders(sql).Tables[0];
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

         private void btTaoMoiHD_Click(object sender, EventArgs e)
         {
             this.Hide();
             frmThemHoaDon fThemMoiHD = new frmThemHoaDon();
             fThemMoiHD.ShowDialog();
         }

         private void btXoaHD_Click(object sender, EventArgs e)
         {
             cn.Open();
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.CommandText = "uspXoaHoaDon";
                 cmd.Connection = cn;
                 cmd.CommandType = CommandType.StoredProcedure;

                 cmd.Parameters.Add(new SqlParameter("@MaHoaDon", cbMaHD.SelectedValue.ToString()));

                 if (MessageBox.Show("Bạn muốn xóa hóa đơn?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                 {
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("Xóa hóa đơn thành công.");

                     string sql = "SELECT * FROM ORDERS";
                     orders = GetOrders(sql).Tables[0];
                     cbMaHD.DataSource = orders;
                     cbMaHD.DisplayMember = "ID_Orders";
                     cbMaHD.ValueMember = "ID_Orders";

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

         private void btSuaMon_Click(object sender, EventArgs e)
         {
             cn.Open();
             try
             {
                 
                 int currentIndex = dgvHoaDon.CurrentCell.RowIndex;

                 string soluong = Convert.ToString(dgvHoaDon.Rows[currentIndex].Cells[2].Value.ToString());
                 string mahoadon = Convert.ToString(cbMaHD.SelectedValue.ToString());
                 string mamon = Convert.ToString(dgvHoaDon.Rows[currentIndex].Cells[0].Value.ToString());

                 string suamon = "UPDATE MON_ORDERS SET SoLuong = '" + soluong + "'" + " WHERE ID_Orders = '" + mahoadon + "' AND ID_Mon = '" + mamon + "'";
                 SqlCommand cmd = new SqlCommand(suamon, cn);
                 cmd.CommandType = CommandType.Text;
                 

                 

                 if (MessageBox.Show("Bạn muốn Cập nhật số lượng món?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                 {
                     cmd.ExecuteNonQuery();
                     lbTongCong.Text = "";
                     string sql = "SELECT mord.ID_Mon, Ten_Mon, mord.SoLuong, mord.DonGia, (mon.DonGia*SoLuong) AS ThanhTien FROM MON_ORDERS mord JOIN ORDERS ord ON ord.ID_Orders = mord.ID_Orders JOIN MON mon ON mon.ID_Mon = mord.ID_Mon WHERE ord.ID_Orders = '" + cbMaHD.Text + "'";
                     dgvHoaDon.DataSource = GetOrders(sql).Tables[0];
                     MessageBox.Show("Cập nhật số lượng của món thành công.");
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



    }
}
