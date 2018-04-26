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
    public partial class frmThemMoiMA : Form
    {
        string cnStr = "";
        SqlConnection cn;
        DataSet ds;
        DataTable dt = new DataTable();

        public frmThemMoiMA()
        {
            InitializeComponent();
        }

        private void frmThemMoiMA_Load(object sender, EventArgs e)
        {
            cnStr = "Server = .; Database = QuanLyATC_HueTam; Integrated security = true;";
            cn = new SqlConnection(cnStr);

            //Load tên loại NVL lên cbLoaiMon
            string sqlLoaiMon = "SELECT * FROM LOAI_MON";
            dt = GetData(sqlLoaiMon).Tables[0];
            cbLoaiMon.DataSource = dt;
            cbLoaiMon.DisplayMember = "Ten_LoaiMon";
            cbLoaiMon.ValueMember = "ID_LoaiMon";
            cbLoaiMon.SelectedIndex = -1;
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
            txtMaMonAn.Text = "";
            txtTenMonAn.Text = "";
            cbLoaiMon.Text = "";
            txtDonGia.Text = "";
            txtQuyCachMA.Text = "";
            txtMonAnKem.Text = "";
            txtNuocCham.Text = "";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "uspThemMoiMonAnVaoDanhMuc";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                //các parameter
                cmd.Parameters.Add(new SqlParameter("@MaMon", txtMaMonAn.Text));
                cmd.Parameters.Add(new SqlParameter("@TenMon", txtTenMonAn.Text));
                cmd.Parameters.Add(new SqlParameter("@MaLoaiMon", cbLoaiMon.SelectedValue.ToString()));
                cmd.Parameters.Add(new SqlParameter("@DonGia", txtDonGia.Text));
                cmd.Parameters.Add(new SqlParameter("@QuyCach", txtQuyCachMA.Text));
                cmd.Parameters.Add(new SqlParameter("@MonKemTheo", txtMonAnKem.Text));
                cmd.Parameters.Add(new SqlParameter("@NuocCham", txtNuocCham.Text));

                if (MessageBox.Show("Bạn muốn lưu?", "Xác nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm món thành công.");
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
    }
}
