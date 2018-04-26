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
    public partial class frmThemHoaDon : Form
    {
        string cnStr = "";
        SqlConnection cn;
        DataSet ds;
        DataTable dt = new DataTable();

        public frmThemHoaDon()
        {
            InitializeComponent();
        }

        private void frmThemHoaDon_Load(object sender, EventArgs e)
        {
            cnStr = "Server = .; Database = QuanLyATC_HueTam; Integrated security = true;";
            cn = new SqlConnection(cnStr);

            //load tên khách hàng lên cbMaKH
            string sqlMaKH = "SELECT ID_KH, Ho_KH, Ten_KH, (CAST(ID_KH AS nvarchar) + ' - ' + Ho_KH + ' ' + Ten_KH) AS MaVaTen FROM KHACHHANG";
            dt = GetData(sqlMaKH).Tables[0];
            cbMaKH.DataSource = dt;
            cbMaKH.DisplayMember = "MaVaTen";
            cbMaKH.ValueMember = "ID_KH";
            cbMaKH.SelectedIndex = -1;

            //load tên nhân viên lên cbMaNV
            string sqlMaNV = "SELECT ID_NV, Ho_NV, Ten_NV, (CAST(ID_NV AS nvarchar) + ' - ' + Ho_NV + ' ' + Ten_NV) AS TenDayDu FROM NHANVIEN";
            dt = GetData(sqlMaNV).Tables[0];
            cbMaNV.DataSource = dt;
            cbMaNV.DisplayMember = "TenDayDu";
            cbMaNV.ValueMember = "ID_NV";
            cbMaNV.SelectedIndex = -1;
        }

        public void noichuoi()
        {

        }

        public DataSet GetData(string sql)
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

        public void SetNull()
        {
            cbMaKH.Text = "";
            cbMaNV.Text = "";
            dtpNgayLapHD.Text = "";
            txtBanSo.Text = "";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "uspThemMoiHoaDon";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                //cac parameter
                cmd.Parameters.Add(new SqlParameter("@MaKhachhang",cbMaKH.SelectedValue.ToString()));
                cmd.Parameters.Add(new SqlParameter("@MaNhanVien", cbMaNV.SelectedValue.ToString()));
                cmd.Parameters.Add(new SqlParameter("@NgayGioDat", Convert.ToDateTime(dtpNgayLapHD.Text)));
                cmd.Parameters.Add(new SqlParameter("@BanSo", txtBanSo.Text.ToString()));

                if (MessageBox.Show("Bạn muốn lưu?", "Xác nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm hoá đơn thành công.");
                    SetNull();

                    if (MessageBox.Show("Bạn muốn thêm món ăn vào hóa đơn này không?", "Gợi ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Hide();
                        frmThemMon f = new frmThemMon();
                        f.ShowDialog();
                    }
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

        private void frmThemHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            frmHoaDon f = new frmHoaDon();
            f.Show();
        }

    }
}
