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
    public partial class frmDanhMuc : Form
    {
        string cnStr;
        SqlConnection cn;
        DataTable dt = new DataTable();
        DataSet ds;

        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            cnStr = "Server = .; Database = QuanLyATC_HueTam; Integrated security = true;";
            cn = new SqlConnection();
            cn.ConnectionString = cnStr;

            //load mã món ăn lên cbMaMonAn
            string sqlMonAn = "SELECT * FROM MON";
            dt = loadDL(sqlMonAn).Tables[0];
            cbMaMonAn.DataSource = dt;
            cbMaMonAn.DisplayMember = "ID_Mon";
            cbMaMonAn.ValueMember = "ID_Mon";
            cbMaMonAn.SelectedIndex = -1;

            //load tên loại món ăn lên cbLoaiMon
            string sqlLoaiMon = "SELECT * FROM LOAI_MON";
            dt = loadDL(sqlLoaiMon).Tables[0];
            cbLoaiMon.DataSource = dt;
            cbLoaiMon.ValueMember = dt.Columns["ID_LoaiMon"].ColumnName;
            cbLoaiMon.DisplayMember = dt.Columns["Ten_LoaiMon"].ColumnName;
            cbLoaiMon.SelectedIndex = -1;

            //load mã NVL lên cbMaNVL
            string sqlMaNVL = "SELECT * FROM NGUYENVATLIEU";
            dt = loadDL(sqlMaNVL).Tables[0];
            cbMaNVL.DataSource = dt;
            cbMaNVL.DisplayMember = "ID_NVL";
            cbMaNVL.ValueMember = "ID_NVL";
            cbMaNVL.SelectedIndex = -1;

            //load tên loại NVL lên cbLoaiNVL
            string sqlLoaiNVL = "SELECT * FROM LOAI_NVL";
            dt = loadDL(sqlLoaiNVL).Tables[0];
            cbLoaiNVL.DataSource = dt;
            cbLoaiNVL.ValueMember = dt.Columns["ID_LoaiNVL"].ColumnName;
            cbLoaiNVL.DisplayMember = dt.Columns["Ten_LoaiNVL"].ColumnName;
            cbLoaiNVL.SelectedIndex = -1;

            try
            {

                //loadMonAnlenluoi();
                //loadNVLlenluoi();

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void loadMonAnlenluoi()
        {
            try
            {
                cn.Open();
                string sql = "uspXemDanhMucMonAn";
                List<MonAn> dsmonan = DSMonAn(sql);
                dgvMonAn.DataSource = dsmonan;

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

        public void loadNVLlenluoi()
        {
            try
            {
                cn.Open();

                List<NguyenVatLieu> NVL = DSNguyenVatLieu();
                dgvNVL.DataSource = NVL;

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

        public DataSet loadDL(string sql)
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

        public List<MonAn> DSMonAn(string sql)
        {
            try
            {
                List<MonAn> dsmonan = new List<MonAn>();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                string MaMonAn, TenMonAn, LoaiMon, QuyCach, NuocCham, MonKemTheo;
                int DonGia;

                while(dr.Read())
                {
                    MaMonAn = dr.GetString(0);
                    TenMonAn = dr.GetString(1);
                    LoaiMon = dr.GetString(2);
                    QuyCach = dr.GetString(3);
                    NuocCham = dr.GetString(4);
                    MonKemTheo = dr.GetString(5);
                    DonGia = dr.GetInt32(6);

                    MonAn monan = new MonAn(MaMonAn, TenMonAn, LoaiMon, QuyCach, NuocCham, MonKemTheo, DonGia);
                    dsmonan.Add(monan);

                }
                dr.Close();
                return dsmonan;
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<NguyenVatLieu> DSNguyenVatLieu()
        {
            try
            {
                List<NguyenVatLieu> dsnvl = new List<NguyenVatLieu>();
                SqlCommand cmdNVL = new SqlCommand();
                cmdNVL.CommandText = "uspXemDanhMucNVL";
                cmdNVL.Connection = cn;
                cmdNVL.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmdNVL.ExecuteReader();

                string MaNVL, TenNVL, TenLoaiNVL, QuyCach, DonViTinh;
                double SoLuongTrongKho, SoLuongToiThieuDatLai;

                while(dr.Read())
                {
                    MaNVL = dr.GetString(0);
                    TenNVL = dr.GetString(1);
                    TenLoaiNVL = dr.GetString(2);
                    QuyCach = dr.GetString(3);
                    SoLuongTrongKho = dr.GetDouble(4);
                    SoLuongToiThieuDatLai = dr.GetDouble(5);
                    DonViTinh = dr.GetString(6);

                    NguyenVatLieu nvl = new NguyenVatLieu(MaNVL, TenNVL, TenLoaiNVL, QuyCach, SoLuongTrongKho, SoLuongToiThieuDatLai, DonViTinh);
                    dsnvl.Add(nvl);
                }
                dr.Close();
                return dsnvl;
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void dgvMonAn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            String value = e.Value as string;
            if ((value != null) && value.Equals(e.CellStyle.DataSourceNullValue))
            {
                e.Value = e.CellStyle.NullValue;
                e.FormattingApplied = true;
            }
        }

        public void SetNullMA()
        {
            cbMaMonAn.Text = "" ;
            txtTenMonAn.Text = "";
            cbLoaiMon.Text = "";
            txtDonGia.Text = "";
            txtQuyCachMA.Text = "";
            txtMonAnKem.Text = "";
            txtNuocCham.Text = "";
        }

        public void SetNullNVL()
        {
            cbMaNVL.Text = "";
            txtTenNVL.Text = "";
            cbLoaiNVL.Text = "";
            txtQuyCachNVL.Text = "";
            txtDonViTinh.Text = "";
            txtSoLuongTrongKho.Text = "";
            txtSoLuongToiThieu.Text = "";
        }

        private void btXoaMA_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "uspXoaDanhMucMonAn";
                cmd.Parameters.Add(new SqlParameter("@MaMonAn", cbMaMonAn.Text));
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                if (MessageBox.Show("Bạn muốn xóa món ăn này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    string sql = "uspXemDanhMucMonAn";
                    dgvMonAn.DataSource = DSMonAn(sql);
                    MessageBox.Show("Xóa thành công.");
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

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvMonAn.Rows[e.RowIndex];
                cbMaMonAn.Text = row.Cells[0].Value.ToString();
                txtTenMonAn.Text = row.Cells[1].Value.ToString();
                cbLoaiMon.Text = row.Cells[2].Value.ToString();
                txtQuyCachMA.Text = row.Cells[3].Value.ToString();
                txtNuocCham.Text = row.Cells[4].Value.ToString();
                txtMonAnKem.Text = row.Cells[5].Value.ToString();
                txtDonGia.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btXoaNVL_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "uspXoaDanhMucNVL";
                
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNVL", cbMaNVL.Text));
                if (MessageBox.Show("Bạn muốn xóa nguyên vật liệu này?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    dgvNVL.DataSource = DSNguyenVatLieu();
                    MessageBox.Show("Xóa nguyên vật liệu thành công.");
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

        private void btTimKiemMA_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT mon.ID_Mon, mon.Ten_Mon, lm.Ten_LoaiMon, mon.QuyCach, mon.NuocCham, mon.MonKemTheo, mon.DonGia FROM dbo.MON mon JOIN dbo.LOAI_MON lm ON mon.ID_LoaiMon = lm.ID_LoaiMon WHERE ";
                
                sql += " ((mon.ID_Mon LIKE '%' + ISNULL(N'" + cbMaMonAn.Text + "', ID_Mon) + '%') OR '" + cbMaMonAn.Text + "' IS NULL) ";
                
                if (!string.IsNullOrEmpty(txtTenMonAn.Text))
                    sql += " AND ((mon.Ten_Mon LIKE '%' + ISNULL(N'" + txtTenMonAn.Text + "', Ten_Mon) + '%') OR '" + txtTenMonAn.Text + "' IS NULL) ";
                if (!string.IsNullOrEmpty(txtQuyCachMA.Text))
                    sql += " AND ((mon.QuyCach LIKE '%' + ISNULL(N'" + txtQuyCachMA.Text + "', mon.QuyCach) + '%') OR '" + txtQuyCachMA.Text + "' IS NULL) ";
                if (!string.IsNullOrEmpty(txtNuocCham.Text))
                    sql += "AND ((mon.NuocCham LIKE '%' + ISNULL(N'" + txtNuocCham.Text + "', mon.NuocCham) + '%') OR '" + txtNuocCham.Text + "' IS NULL)";
                if (!string.IsNullOrEmpty(txtMonAnKem.Text))
                    sql += " AND ((mon.MonKemTheo LIKE '%' + ISNULL(N'" + txtMonAnKem.Text + "', mon.MonKemTheo) + '%') OR N'" + txtMonAnKem.Text + "' IS NULL) ";
                if (!string.IsNullOrEmpty(txtDonGia.Text))
                    sql += " AND (mon.DonGia = " + txtDonGia.Text + " OR N'" + txtDonGia.Text + "' IS NULL) ";
                if (!string.IsNullOrEmpty(cbLoaiMon.Text))
                    sql += " AND ((lm.Ten_LoaiMon LIKE '%' + ISNULL(N'" + cbLoaiMon.Text + "', lm.Ten_LoaiMon) + '%') OR '" + cbLoaiMon.Text + "' IS NULL) ";
                dgvMonAn.DataSource = loadDL(sql).Tables[0];
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btTimKiemNVL_Click(object sender, EventArgs e)
        {
            try
            {
                
                string sql = "SELECT nvl.ID_NVL, nvl.Ten_NVL, lnvl.Ten_LoaiNVL, nvl.QuyCach, nvl.SoLuongCon, nvl.ToiThieuDatLai, nvl.DonViTinh FROM dbo.NGUYENVATLIEU nvl JOIN dbo.LOAI_NVL lnvl ON nvl.ID_LoaiNVL = lnvl.ID_LoaiNVL WHERE ";
                sql += " ((nvl.ID_NVL LIKE '%' + ISNULL('" + cbMaNVL.Text + "', ID_NVL) + '%') OR '" + cbMaNVL.Text + "' IS NULL) ";

                if (!string.IsNullOrEmpty(txtTenNVL.Text))
                    sql += " AND ((nvl.Ten_NVL LIKE '%' + ISNULL(N'" + txtTenNVL.Text + "', Ten_NVL) + '%') OR '" + txtTenNVL.Text + "' IS NULL) ";
                if (!string.IsNullOrEmpty(cbLoaiNVL.Text))
                    sql += " AND ((lnvl.Ten_LoaiNVL LIKE '%' + ISNULL(N'" + cbLoaiNVL.Text + "', lnvl.Ten_LoaiNVL) + '%') OR '" + cbLoaiNVL.Text + "' IS NULL) ";
                if (!string.IsNullOrEmpty(txtQuyCachNVL.Text))
                    sql += " AND ((nvl.QuyCach LIKE '%' + ISNULL(N'" + txtQuyCachNVL.Text + "', nvl.QuyCach) + '%') OR '" + txtQuyCachNVL.Text + "' IS NULL) ";
                if (!string.IsNullOrEmpty(txtSoLuongTrongKho.Text))
                    sql += " AND (nvl.SoLuongCon = '" + txtSoLuongTrongKho.Text + "' OR '" + txtSoLuongTrongKho.Text + "' IS NULL) ";
                if (!string.IsNullOrEmpty(txtSoLuongToiThieu.Text))
                    sql += " AND (nvl.ToiThieuDatLai = '" + txtSoLuongToiThieu.Text + "' OR '" + txtSoLuongToiThieu.Text + "' IS NULL) ";
                if (!string.IsNullOrEmpty(txtDonViTinh.Text))
                    sql += " AND ((nvl.DonViTinh LIKE '%' + ISNULL(N'" + txtDonViTinh.Text + "', nvl.DonViTinh) + '%') OR '" + txtDonViTinh.Text + "' IS NULL) ";

                dgvNVL.DataSource = loadDL(sql).Tables[0];
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btSuaNVL_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "uspSuaNVL";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                //Cac parameter
                cmd.Parameters.Add(new SqlParameter("@MaNVL", cbMaNVL.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@TenNVL", txtTenNVL.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@MaLoaiNVL", cbLoaiNVL.SelectedValue.ToString()));
                cmd.Parameters.Add(new SqlParameter("@QuyCach", txtQuyCachNVL.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@DonViTinh", txtDonViTinh.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@SoLuongCon", txtSoLuongTrongKho.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@ToiThieuDatLai", txtSoLuongToiThieu.Text.ToString()));

                if (MessageBox.Show("Bạn muốn cập nhật nguyên vật liệu này?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công.");
                    dgvNVL.DataSource = DSNguyenVatLieu();
                }
                SetNullNVL();
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

        //private void cbLoaiNVL_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cn.Open();
        //    try
        //    {
        //        //SetNullNVL();
        //        string sql = "SELECT * FROM NGUYENVATLIEU WHERE ID_LoaiNVL = '" + cbLoaiNVL.SelectedValue.ToString() + "'";
        //        //dgvNVL.DataSource = loadDL(sql).Tables[0];
        //    }
        //    catch (SqlException ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
        //}

        //private void cbLoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cn.Open();
        //    try
        //    {
        //        //SetNullMA();
        //        string sql = "SELECT ID_Mon, Ten_Mon, ID_LoaiMon, DonGia, NuocCham FROM MON WHERE ID_LoaiMon = '" + cbLoaiMon.SelectedValue.ToString() + "'";
        //        //dgvMonAn.DataSource = loadDL(sql).Tables[0];
        //    }
        //    catch (SqlException ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
        //}

        private void btTaoMoiNVL_Click(object sender, EventArgs e)
        {
            frmThemMoiNVL fThemNVL = new frmThemMoiNVL();
            fThemNVL.ShowDialog();
        }

        private void btTaoMoiMA_Click(object sender, EventArgs e)
        {
            frmThemMoiMA fTaoMoiMA = new frmThemMoiMA();
            fTaoMoiMA.ShowDialog();
        }

        private void btSuaMA_Click(object sender, EventArgs e)
        {
            //cbMaMonAn.Enabled = false;
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "uspSuaMonAn";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                //Cac parameter
                cmd.Parameters.Add(new SqlParameter("@MaMon", cbMaMonAn.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@TenMon", txtTenMonAn.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@MaLoaiMon", cbLoaiMon.SelectedValue.ToString()));
                cmd.Parameters.Add(new SqlParameter("@DonGia", txtDonGia.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@QuyCach", txtQuyCachMA.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@MonKemTheo", txtMonAnKem.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@NuocCham", txtNuocCham.Text.ToString()));

                if (MessageBox.Show("Bạn muốn cập nhật món ăn này?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công.");
                    dgvNVL.DataSource = DSNguyenVatLieu();
                }
                SetNullNVL();
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

        private void btTaiLaiMA_Click(object sender, EventArgs e)
        {
            SetNullMA();
            loadMonAnlenluoi();
        }

        private void btTaiLaiNVL_Click(object sender, EventArgs e)
        {
            SetNullNVL();
            loadNVLlenluoi();
        }

        private void dgvMonAn_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SetNullMA();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvMonAn.Rows[e.RowIndex];
                cbMaMonAn.Text = row.Cells[0].Value.ToString();
                txtTenMonAn.Text = row.Cells[1].Value.ToString();
                cbLoaiMon.Text = row.Cells[2].Value.ToString();
                txtQuyCachMA.Text = row.Cells[3].Value.ToString();
                txtNuocCham.Text = row.Cells[4].Value.ToString();
                txtMonAnKem.Text = row.Cells[5].Value.ToString();
                txtDonGia.Text = row.Cells[6].Value.ToString();
            }
        }

        private void dgvNVL_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SetNullNVL();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvNVL.Rows[e.RowIndex];
                cbMaNVL.Text = row.Cells[0].Value.ToString();
                txtTenNVL.Text = row.Cells[1].Value.ToString();
                cbLoaiNVL.Text = row.Cells[2].Value.ToString();
                txtQuyCachNVL.Text = row.Cells[3].Value.ToString();
                txtDonViTinh.Text = row.Cells[6].Value.ToString();
                txtSoLuongTrongKho.Text = row.Cells[4].Value.ToString();
                txtSoLuongToiThieu.Text = row.Cells[5].Value.ToString();
            }
        }

        private void frmDanhMuc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            MainFrm f = new MainFrm();
            f.Show();
        }


    }
}
