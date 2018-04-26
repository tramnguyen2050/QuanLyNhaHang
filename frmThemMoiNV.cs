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
    public partial class frmThemMoiNV : Form
    {
        string cnStr = "";
        SqlConnection cn;
        DataSet ds;
        DataTable dt = new DataTable();

        public frmThemMoiNV()
        {
            InitializeComponent();
        }

        private void frmThemMoiNV_Load(object sender, EventArgs e)
        {
            cnStr = "Server = .; Database = QuanLyATC_HueTam; Integrated security = true;";
            cn = new SqlConnection(cnStr);

            //Load tên loại NVL lên cbLoaiNVL
            string sqlChucVu = "SELECT * FROM CHUCVU";
            dt = GetData(sqlChucVu).Tables[0];
            cbChucVu.DataSource = dt;
            cbChucVu.DisplayMember = "Ten_ChucVu";
            cbChucVu.ValueMember = "ID_ChucVu";
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

        private void btLuu_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "uspThamNV";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Ho", txtHoNV.Text));
                cmd.Parameters.Add(new SqlParameter("@Ten", txtTenNV.Text));
                cmd.Parameters.Add(new SqlParameter("@Chucvu", cbChucVu.SelectedValue.ToString()));
                cmd.Parameters.Add(new SqlParameter("@Gioitinh", KieuGioiTinh()));
                cmd.Parameters.Add(new SqlParameter("@Ngayvaolam", dtpNgayVaoLam.Text));
                cmd.Parameters.Add(new SqlParameter("@Socalam", txtSoCaLam.Text));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", txtDiaChi.Text));
                cmd.Parameters.Add(new SqlParameter("@SDT", txtSDTNV.Text));

                if (MessageBox.Show("Bạn muốn lưu?", "Xác nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhân viên thành công.");
                }
                SetNull();
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

        public Boolean KieuGioiTinh()
        {
            if (cbGioiTinhNV.Text == "Nam")
                return true;
            else
                return false;
        }

        public void SetNull()
        {
            txtHoNV.Text = "";
            txtTenNV.Text = "";
            cbGioiTinhNV.Text = "";
            cbChucVu.Text = "";
            txtDiaChi.Text = "";
            dtpNgayVaoLam.Text = "";
            txtSoCaLam.Text = "";
            txtSDTNV.Text = "";
        }

    }
}
