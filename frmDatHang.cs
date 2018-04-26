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
    public partial class frmDatHang : Form
    {
        string cnStr;
        SqlConnection cn;
        public frmDatHang()
        {
            InitializeComponent();
        }

        private void frmDatHang_Load(object sender, EventArgs e)
        {
            cnStr = "Server = .; Database = QuanLyATC_HueTam; Integrated security = true;";
            cn = new SqlConnection();
            cn.ConnectionString = cnStr;

           
            try
            {
                cn.Open();
                List<DatHang> lst = DonDatHang();
                dgvDatHang.DataSource = lst;

                List<XuatNhapKho> lstXNK = XuatNhap();
                dgvXuatNhapKho.DataSource = lstXNK;

                string sql = "SELECT ID_LoaiNVL, Ten_LoaiNVL FROM LOAI_NVL";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cbMaLoaiNVL.Items.Add(dr[0]);
                    cbTenLoaiNVL.Items.Add(dr[1]);
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
            btXuat.Enabled = false;
            btNhap.Enabled = false;
        }

        public List<DatHang> DonDatHang()
        {
            //cn.Open();
            try
            {
                List<DatHang> list = new List<DatHang>();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "uspDatHang";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                string MaNVL, TenNVL, LoaiNVL, TenNCC, Quycach, dvt;
                double slcon;
                while (dr.Read())
                {
                    MaNVL = dr.GetString(0);
                    TenNVL = dr.GetString(1);
                    LoaiNVL = dr.GetString(2);
                    TenNCC = dr.GetString(3);
                    Quycach = dr.GetString(4);
                    slcon = dr.GetDouble(5);
                    dvt = dr.GetString(6);
                    DatHang DH1 = new DatHang(MaNVL, TenNVL, LoaiNVL, TenNCC, Quycach, slcon, dvt);
                    list.Add(DH1);
                    this.dgvDatHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                dr.Close();
                return list;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                //cn.Close();
            }
        }

        public List<XuatNhapKho> XuatNhap()
        {
            //cn.Open();
            try
            {
                List<XuatNhapKho> listXNK = new List<XuatNhapKho>();
                SqlCommand cmdXNK = new SqlCommand();
                cmdXNK.CommandText = "uspXuatNhapKho";
                cmdXNK.Connection = cn;
                cmdXNK.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmdXNK.ExecuteReader();

                string MaNVL, TenNVL, TenLoaiNVL, QuyCach, DVT;
                double SoLuongCon;
                while (dr.Read())
                {
                    MaNVL = dr.GetString(0);
                    TenNVL = dr.GetString(1);
                    TenLoaiNVL = dr.GetString(2);
                    QuyCach = dr.GetString(3);
                    SoLuongCon = dr.GetDouble(4);
                    DVT = dr.GetString(5);
                    XuatNhapKho XNK = new XuatNhapKho(MaNVL, TenNVL, TenLoaiNVL, QuyCach, SoLuongCon, DVT);
                    listXNK.Add(XNK);
                    this.dgvXuatNhapKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                dr.Close();
                return listXNK;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                //cn.Close();
            }
        }

        public List<XuatNhapKho> XuatNhapTheoLoaiNVL(string sql)
        {
            cn.Open();
            try
            {
                List<XuatNhapKho> listXNK = new List<XuatNhapKho>();
                SqlCommand cmdXNK = new SqlCommand();
                cmdXNK.CommandText = sql;
                cmdXNK.Connection = cn;
                cmdXNK.CommandType = CommandType.Text;
                SqlDataReader dr = cmdXNK.ExecuteReader();

                string MaNVL, TenNVL, TenLoaiNVL, QuyCach, DVT;
                double SoLuongCon;
                while (dr.Read())
                {
                    MaNVL = dr.GetString(0);
                    TenNVL = dr.GetString(1);
                    TenLoaiNVL = dr.GetString(2);
                    QuyCach = dr.GetString(3);
                    SoLuongCon = dr.GetDouble(4);
                    DVT = dr.GetString(5);
                    XuatNhapKho XNK = new XuatNhapKho(MaNVL, TenNVL, TenLoaiNVL, QuyCach, SoLuongCon, DVT);
                    listXNK.Add(XNK);
                    this.dgvXuatNhapKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                dr.Close();
                return listXNK;
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

        private void cbMaLoaiNVL_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT ID_NVL, Ten_NVL, Ten_LoaiNVL, QuyCach, SoLuongCon, DonViTinh FROM NGUYENVATLIEU nvl JOIN LOAI_NVL lnvl ON lnvl.ID_LoaiNVL = nvl.ID_LoaiNVL WHERE lnvl.ID_LoaiNVL = '" + cbMaLoaiNVL.Text + "'";
            List<XuatNhapKho> lstXNK = XuatNhapTheoLoaiNVL(sql);
            dgvXuatNhapKho.DataSource = lstXNK;
        }

        private void dgvXuatNhapKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btXuat.Enabled = true;
            btNhap.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rows = this.dgvXuatNhapKho.Rows[e.RowIndex];
                txtDVTNhap.Text = rows.Cells[5].Value.ToString();
                txtDVTXuat.Text = rows.Cells[5].Value.ToString();
                txtMaNVL.Text = rows.Cells[0].Value.ToString();
            }
        }

        private void btXuat_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "uspXuatNVL";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNVL", txtMaNVL.Text));
                cmd.Parameters.Add(new SqlParameter("@Soluongxuat", nudSoLuongXuat.Value));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xuất kho thành công!");
                dgvXuatNhapKho.DataSource = XuatNhap();
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

        private void btNhap_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "uspNhapNVL";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNVL", txtMaNVL.Text));
                cmd.Parameters.Add(new SqlParameter("@Soluongnhap", nudSoLuongNhap.Value));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nhập kho thành công!");
                dgvXuatNhapKho.DataSource = XuatNhap();
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

        private void cbTenLoaiNVL_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT ID_NVL, Ten_NVL, Ten_LoaiNVL, QuyCach, SoLuongCon, DonViTinh FROM NGUYENVATLIEU nvl JOIN LOAI_NVL lnvl ON lnvl.ID_LoaiNVL = nvl.ID_LoaiNVL WHERE lnvl.Ten_LoaiNVL = N'" + cbTenLoaiNVL.Text + "'";
            List<XuatNhapKho> lstXNK = XuatNhapTheoLoaiNVL(sql);
            dgvXuatNhapKho.DataSource = lstXNK;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT ID_NVL, Ten_NVL, Ten_LoaiNVL, QuyCach, SoLuongCon, DonViTinh FROM NGUYENVATLIEU nvl JOIN LOAI_NVL lnvl ON lnvl.ID_LoaiNVL = nvl.ID_LoaiNVL WHERE ";
            if (rdTheoTen.Checked == true)
            {
                sql += "Ten_NVL LIKE N'%" + txtNhap.Text + "%'";
            }
            if(rdTheoMa.Checked == true)
            {
                sql += "ID_NVL = ('" + txtNhap.Text + "')";
            }
            dgvXuatNhapKho.DataSource = XuatNhapTheoLoaiNVL(sql);
        }

        private void btHienThiTatCa_Click(object sender, EventArgs e)
        {
            string sql = "SELECT ID_NVL, Ten_NVL, Ten_LoaiNVL, QuyCach, SoLuongCon, DonViTinh FROM NGUYENVATLIEU nvl JOIN LOAI_NVL lnvl ON lnvl.ID_LoaiNVL = nvl.ID_LoaiNVL";
            dgvXuatNhapKho.DataSource = XuatNhapTheoLoaiNVL(sql);
        }

        private void frmDatHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainFrm f = new MainFrm();
            f.Show();
        }

        
    }
}
