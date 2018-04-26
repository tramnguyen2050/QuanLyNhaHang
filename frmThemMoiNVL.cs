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
    public partial class frmThemMoiNVL : Form
    {
        string cnStr = "";
        SqlConnection cn;
        DataSet ds;
        DataTable dt = new DataTable();

        public frmThemMoiNVL()
        {
            InitializeComponent();
        }

        private void frmThemMoiNVL_Load(object sender, EventArgs e)
        {
            cnStr = "Server = .; Database = QuanLyATC_HueTam; Integrated security = true;";
            cn = new SqlConnection(cnStr);

            //Load tên loại NVL lên cbLoaiNVL
            string sqlLoaiNVL = "SELECT * FROM LOAI_NVL";
            dt = GetData(sqlLoaiNVL).Tables[0];
            cbLoaiNVL.DataSource = dt;
            cbLoaiNVL.DisplayMember = "Ten_LoaiNVL";
            cbLoaiNVL.ValueMember = "ID_LoaiNVL";
        }

        public DataSet GetData (string sql)
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

        private void btLuuTaoMoi_Click(object sender, EventArgs e)
        {
            luu();
            SetNull();
        }

        public void luu()
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "uspThemMoiNVLVaoDanhMuc";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNVL", txtMaNVL.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@TenNVL", txtTenNVL.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@LoaiNVL", cbLoaiNVL.SelectedValue.ToString()));
                cmd.Parameters.Add(new SqlParameter("@QuyCach", txtQuyCachNVL.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@DonViTinh", txtDonViTinh.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@SoLuongCon", txtSoLuongTrongKho.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@ToiThieuDatLai", txtToiThieuDatLai.Text.ToString()));

                if (MessageBox.Show("Bạn muốn lưu?", "Xác nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm nguyên vật liệu thành công.");
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
            txtMaNVL.Text = "";
            txtTenNVL.Text = "";
            cbLoaiNVL.Text = "";
            txtQuyCachNVL.Text = "";
            txtDonViTinh.Text = "";
            txtSoLuongTrongKho.Text = "";
            txtToiThieuDatLai.Text = "";
        }
    }
}
