using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;
using Project.Class;


namespace Project.Forms
{
    public partial class Hopdongbaiviet : Form
    {
        public Hopdongbaiviet()
        {
            InitializeComponent();
            //this.SizeChanged += new EventHandler(Hopdongbaiviet_SizeChanged);

        }
        private void Hopdongbaiviet_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnIn.Enabled = false;
            btnHuy.Enabled = false;
            txtNhuanbut.ReadOnly = true;
            Class.Function.FillCombo("Select MaNV, TenNV from tblNhanvien", cbManhanvien, "MaNV", "TenNV");
            cbManhanvien.SelectedIndex = -1;
            Class.Function.FillCombo("Select Matheloai, Tentheloai from tblTheloai", cbMatheloai, "Matheloai", "Tentheloai");
            cbMatheloai.SelectedIndex = -1;
            Class.Function.FillCombo("Select Mabao, Tenbao from tblBao", cbMabao, "Mabao", "Tenbao");
            cbMabao.SelectedIndex = -1;
            Class.Function.FillCombo("Select MaLVHD, TenLVHD from tblLinhvuchoatdong", cbLVHD, "MaLVHD", "TenLVHD");
            cbLVHD.SelectedIndex = -1;
            Class.Function.FillCombo("Select Malangui from tblKhachguibai", cbMahopdong, "Malangui", "Malangui");
            cbMahopdong.SelectedIndex = -1;
            if (txtMahopdong.Text != "")
            {
                Load_TTHD();
                btnHuy.Enabled = true;
                btnIn.Enabled = true;
            }
            Load_datagridview();
        }
        DataTable tblHDBV;
        DataTable tblKH;
        private void Load_datagridview()
        {
            string sql;
            sql = "select Matheloai, Mabao, Tieude, Noidung, Ngaydang, Nhuanbut from tblKhachguibai where Malangui=N'" + txtMahopdong.Text + "'";
            //MessageBox.Show(sql);
            tblHDBV = Class.Function.GetDataToTable(sql);
            dgridHopdongbaiviet.DataSource = tblHDBV;
            dgridHopdongbaiviet.Columns[0].HeaderText = "Mã thể loại";
            dgridHopdongbaiviet.Columns[1].HeaderText = "Mã báo";
            dgridHopdongbaiviet.Columns[2].HeaderText = "Tiêu đề";
            dgridHopdongbaiviet.Columns[3].HeaderText = "Nội dung";
            dgridHopdongbaiviet.Columns[4].HeaderText = "Ngày đăng";
            dgridHopdongbaiviet.Columns[5].HeaderText = "Nhuận bút";
            dgridHopdongbaiviet.Columns[0].Width = 100;
            dgridHopdongbaiviet.Columns[1].Width = 80;
            dgridHopdongbaiviet.Columns[2].Width = 115;
            dgridHopdongbaiviet.Columns[3].Width = 115;
            dgridHopdongbaiviet.Columns[4].Width = 80;
            dgridHopdongbaiviet.Columns[5].Width = 80;
            dgridHopdongbaiviet.AllowUserToAddRows = false;
            dgridHopdongbaiviet.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Load_TTHD()
        {
            string str;
            str = "SELECT MaNV FROM tblKhachguibai WHERE Malangui = N'" + txtMahopdong.Text + "'";
            cbManhanvien.Text = Class.Function.GetFieldValues(str);
            str = "SELECT MaKH FROM tblKhachguibai WHERE Malangui = N'" + txtMahopdong.Text + "'";
            txtMakhach.Text = Class.Function.GetFieldValues(str);
            str = "select Ngayky from tblKhachguibai where malangui = N'" + txtMahopdong.Text + "'";
            txtNgayky.Text = Class.Function.convertdatetime(Class.Function.GetFieldValues(str));
            if (txtMakhach.Text == "")
            {
                txtTenkhach.Text = "";
                txtDiachi.Text = "";
                mskDienthoai.Text = "";
                mskDidong.Text = "";
                txtEmail.Text = "";
                cbLVHD.Text = "";
            }
            str = "Select TenKH from tblKhachhang where MaKH= N'" + txtMakhach.Text + "'";
            txtTenkhach.Text = Function.GetFieldValues(str);
            str = "Select DiaChi from tblKhachhang where MaKH = N'" + txtMakhach.Text + "'";
            txtDiachi.Text = Function.GetFieldValues(str);
            str = "Select Dienthoai from tblKhachhang where MaKH= N'" + txtMakhach.Text + "'";
            mskDienthoai.Text = Function.GetFieldValues(str);
            str = "Select Didong from tblKhachhang where MaKH= N'" + txtMakhach.Text + "'";
            mskDidong.Text = Function.GetFieldValues(str);
            str = "Select Email from tblKhachhang where MaKH= N'" + txtMakhach.Text + "'";
            txtEmail.Text = Function.GetFieldValues(str);
            str = "Select MaLVHD from tblKhachhang where MaKH= N'" + txtMakhach.Text + "'";
            cbLVHD.Text = Function.GetFieldValues(str);
            str = "SELECT SUM(Nhuanbut) AS TongTien FROM tblKhachguibai WHERE Malangui = N'" + txtMahopdong.Text + "'";
            txtTongtien.Text = Class.Function.GetFieldValues(str);

            lblBangchu.Text = "Bằng chữ: " + Class.Function.ChuyenSoSangChu(txtTongtien.Text);
            /*str = "Select Matheloai from tblTheloai Where Matheloai=N'"+ cbMatheloai.Text + "'";
            cbMatheloai.Text = Function.GetFieldValues(str);
            str = "Select Mabao from tblBao where Mabao=N'"+ cbMabao.Text + "'";
            cbMabao.Text = Function.GetFieldValues(str);
            str = "Select Ngaydang from tblKhachguibai where Malangui=N'"+ txtMahopdong +"'";
            mskNgaydang.Text = Function.GetFieldValues(str);
            str = "Select Nhuanbut from tblKhachguibai where Malangui=N'" + txtMahopdong + "'";
            txtNhuanbut.Text = Function.GetFieldValues(str);
            str = "Select Tieude from tblKhachguibai where Malangui=N'"+ txtMahopdong+"'";
            txtTieude.Text = Function.GetFieldValues(str);
            str = "Select Noidung from tblKhachguibai where Malangui=N'" + txtMahopdong + "'";
            txtNoidung.Text = Function.GetFieldValues(str);*/
        }
        private void dgridHopdongbaiviet_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMahopdong.Focus();
                return;
            }
            if (tblHDBV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cbMatheloai.Text = dgridHopdongbaiviet.CurrentRow.Cells["Matheloai"].Value.ToString();
            cbMabao.Text = dgridHopdongbaiviet.CurrentRow.Cells["Mabao"].Value.ToString();
            txtTieude.Text = dgridHopdongbaiviet.CurrentRow.Cells["Tieude"].Value.ToString();
            txtNoidung.Text = dgridHopdongbaiviet.CurrentRow.Cells["Noidung"].Value.ToString();
            mskNgaydang.Text = dgridHopdongbaiviet.CurrentRow.Cells["Ngaydang"].Value.ToString();
            txtNhuanbut.Text = dgridHopdongbaiviet.CurrentRow.Cells["Nhuanbut"].Value.ToString();
            Load_TTHD();
            //btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnIn.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //btnSua.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = true;
            btnIn.Enabled = false;
            btnThem.Enabled = false;
            txtMahopdong.Enabled = false;
            mskDienthoai.Enabled = true;
            mskNgaydang.Enabled = true;
            txtTieude.Enabled = true;
            txtNoidung.Enabled = true;
            txtMakhach.Enabled = false;
            txtTenkhach.Enabled = false;
            mskDidong.Enabled = false;
            txtDiachi.Enabled = false;
            txtEmail.Enabled = false;
            cbLVHD.Enabled = false;
            resetvalues();
            txtMahopdong.Text = Class.Function.CreateHDKey();
            Load_datagridview();
        }
        private void resetvalues()
        {
            txtNgayky.Text = DateTime.Now.ToShortDateString();
            txtMahopdong.Text = "";
            txtMakhach.Text = "";
            txtTenkhach.Text = "";
            txtDiachi.Text = "";
            txtEmail.Text = "";
            mskDidong.Text = "";
            mskDienthoai.Text = "";
            cbLVHD.Text = "";
            cbMatheloai.Text = "";
            cbMabao.Text = "";
            txtTieude.Text = "";
            txtNoidung.Text = "";
            cbManhanvien.Text = "";
            mskNgaydang.Text = "";
            txtNhuanbut.Text = "0";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn đóng menu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (cbMahopdong.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hợp đồng để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMahopdong.Focus();
                return;
            }
            txtMahopdong.Text = cbMahopdong.Text;
            Load_TTHD();
            Load_datagridview();
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnIn.Enabled = true;
            cbMahopdong.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            //sql = "Select Malangui from tblKhachguibai where Malangui =N'" + txtMahopdong.Text + "'";
            if (cbManhanvien.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbManhanvien.Focus();
                return;
            }
            //if (!Class.Function.CheckKey(sql))
            //{                
            if (txtMakhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMakhach.Focus();
                return;
            }
            if (txtTenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenkhach.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDidong.Text == "(   )    -")
            {
                MessageBox.Show("Bạn phải nhập di động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDidong.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (cbLVHD.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải chọn lĩnh vực hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbLVHD.Focus();
                return;
            }
            // Save Customer Information if not exists
            string customerID = txtMakhach.Text.Trim();
            string query = $"SELECT COUNT(*) FROM tblKhachhang WHERE MaKH = N'{customerID}'";
            int customerCount = int.Parse(Class.Function.GetFieldValues(query));

            if (customerCount == 0)
            {
                // Insert new customer information
                query = $"INSERT INTO tblkhachhang (MaKH, TenKH, DiaChi, DienThoai, Didong, Email, MaLVHD) " +
                        $"VALUES (N'" + txtMakhach.Text.Trim() + "',N'" + txtTenkhach.Text.Trim() + "',N'" + txtDiachi.Text.Trim() + "','" + mskDienthoai.Text + "','" + mskDidong.Text + "','" + txtEmail.Text.Trim() + "','" + cbLVHD.SelectedValue.ToString() + "')";
                Class.Function.RunSql(query);
            }

            //ở đây

            foreach (DataRow row in tblHDBV.Rows)
            {
                sql = $"INSERT INTO tblKhachguibai (Malangui, Ngayky, MaKH, Matheloai, Mabao, Tieude, Noidung, MaNV, Ngaydang, Nhuanbut) " +
                    $"VALUES (N'{txtMahopdong.Text.Trim()}', '{Class.Function.convertdatetime(txtNgayky.Text.Trim())}', " +
                    $"N'{txtMakhach.Text.Trim()}', N'{row["Matheloai"].ToString()}', N'{row["Mabao"].ToString()}', " +
                    $"N'{row["Tieude"].ToString()}', N'{row["Noidung"].ToString()}', N'{cbManhanvien.SelectedValue}', " +
                    $"N'{row["Ngaydang"].ToString()}', N'{row["Nhuanbut"].ToString()}')";
                Class.Function.RunSql(sql);
            }
            MessageBox.Show("Hợp đồng đã được lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Load_datagridview();
            resetvaluesHD();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            //btnSua.Enabled = true;
            btnIn.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void resetvaluesHD()
        {
            cbMatheloai.Text = "";
            cbMabao.Text = "";
            mskNgaydang.Text = "  /  /";
            txtTieude.Text = "";
            txtNoidung.Text = "";
            txtNhuanbut.Text = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select MaKH, TenKH, DiaChi, Didong, Email, MaLVHD from tblKhachhang where DienThoai = '" + mskDienthoai.Text + "'";
            tblKH = Class.Function.GetDataToTable(sql);
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMakhach.Text = Function.CreateCustomerKey();
                txtTenkhach.Enabled = true;
                txtDiachi.Enabled = true;
                mskDidong.Enabled = true;
                txtEmail.Enabled = true;
                txtNoidung.Enabled = true;
                txtTieude.Enabled = true;
                txtNhuanbut.Enabled = true;
                mskNgaydang.Enabled = true;
                cbLVHD.Enabled = true;
            }
            else
            {
                MessageBox.Show("Đã có khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Load_ThongtinKH();
            }
        }
        private void Load_ThongtinKH()
        {
            string str;
            str = "select MaKH from tblKhachhang where DienThoai = '" + mskDienthoai.Text + "'";
            txtMakhach.Text = Class.Function.GetFieldValues(str);
            str = "select TenKH from tblKhachhang where DienThoai = '" + mskDienthoai.Text + "'";
            txtTenkhach.Text = Class.Function.GetFieldValues(str);
            str = "select DiaChi from tblKhachhang where DienThoai = '" + mskDienthoai.Text + "'";
            txtDiachi.Text = Class.Function.GetFieldValues(str);
            str = "select Didong from tblKhachhang where DienThoai = '" + mskDienthoai.Text + "'";
            mskDidong.Text = Class.Function.GetFieldValues(str);
            str = "select Email from tblKhachhang where DienThoai = '" + mskDienthoai.Text + "'";
            txtEmail.Text = Class.Function.GetFieldValues(str);
            str = "select MaLVHD from tblKhachhang where DienThoai = '" + mskDienthoai.Text + "'";
            cbLVHD.Text = Class.Function.GetFieldValues(str);
            //str = "insert into tblKhachhang(MaKH, TenKH, DiaChi, DienThoai, Didong, Email, MaLVHD) values (N'" + txtMakhach.Text.Trim() + "', N '" + txtTenkhach.Text.Trim() + "', N'" + txtDiachi.Text.Trim() + "', '" + mskDienthoai.Text + "', '"+ mskDidong.Text +"', '"+ txtEmail.Text.Trim() +"', '"+ cbLVHD.SelectedValue.ToString() + "'";
            //Function.RunSql(str);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHDBV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMahopdong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có chắn chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblKhachguibai WHERE Malangui=N'" + txtMahopdong.Text + "'";
                Class.Function.RunSqlDel(sql);
                Load_datagridview();
                resetvalues();
            }
        }

        //private void btnSua_Click(object sender, EventArgs e)
        //{
        //    string sql;
        //    txtMahopdong.Enabled = false;
        //    cbManhanvien.Enabled = false;
        //    txtMakhach.Enabled = false;
        //    if (tblHDBV.Rows.Count == 0)
        //    {
        //        MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    if (txtMahopdong.Text == "")
        //    {
        //        MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    if (txtTenkhach.Text.Trim().Length == 0)
        //    {
        //        MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtTenkhach.Focus();
        //        return;
        //    }
        //    if (txtDiachi.Text.Trim().Length == 0)
        //    {
        //        MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtDiachi.Focus();
        //        return;
        //    }
        //    if (mskDidong.Text == "(   )    -")
        //    {
        //        MessageBox.Show("Bạn phải nhập di động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        mskDidong.Focus();
        //        return;
        //    }
        //    if (mskDienthoai.Text == "(   )    -")
        //    {
        //        MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        mskDienthoai.Focus();
        //        return;
        //    }
        //    if (txtEmail.Text.Trim().Length == 0)
        //    {
        //        MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtDiachi.Focus();
        //        return;
        //    }
        //    if (cbLVHD.Text.Length == 0)
        //    {
        //        MessageBox.Show("Bạn phải chọn lĩnh vực hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        cbLVHD.Focus();
        //        return;
        //    }
        //    if (cbMatheloai.Text == "")
        //    {
        //        MessageBox.Show("Bạn phải nhập mã thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        cbMatheloai.Focus();
        //        return;
        //    }
        //    if (cbMabao.Text == "")
        //    {
        //        MessageBox.Show("Bạn phải nhập mã báo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        cbMabao.Focus();
        //        return;
        //    }
        //    if (txtTieude.Text.Trim().Length == 0)
        //    {
        //        MessageBox.Show("Bạn phải nhập tiêu đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtTieude.Focus();
        //        return;
        //    }
        //    if (mskNgaydang.Text == "  /  /")
        //    {
        //        MessageBox.Show("Bạn phải nhập ngày đăng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        mskNgaydang.Focus();
        //        return;
        //    }
        //    if (txtNhuanbut.Text.Trim().Length == 0)
        //    {
        //        MessageBox.Show("Bạn phải nhập nhuận bút", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtNhuanbut.Focus();
        //        return;
        //    }
        //    sql = "UPDATE tblKhachguibai SET MaKH=N'" + txtMakhach.Text.ToString() + "',Matheloai=N'" + cbMatheloai.Text.ToString() + "',Mabao=N'" + cbMabao.Text.ToString() + "',Tieude=N'" + txtTieude.Text.ToString() + "', Noidung=N'" + txtNoidung.Text.ToString() + "',MaNV=N'" + cbManhanvien.SelectedValue.ToString() + "',Ngaydang='" + mskNgaydang.Text + "', Nhuanbut='" + txtNhuanbut.Text.Trim().ToString() + "', Ngayky='"+ txtNgayky.Text.Trim().ToString()+"' WHERE Malangui=N'" + txtMahopdong.Text + "'";
        //    Class.Function.RunSql(sql);
        //    Load_TTHD();
        //    Load_datagridview();
        //    resetvalues();
        //    btnIn.Enabled = false;
        //}

        private void btnIn_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinCTHD;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Công ty ABC";

            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Chùa Bộc - Đống Đa - Hà Nội";

            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (09)87654321";


            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HỢP ĐỒNG BÀI VIẾT";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.Malangui, b.TenKH, b.Diachi, b.Dienthoai, c.TenNV FROM tblKhachguibai AS a, tblKhachhang AS b, tblNhanvien AS c WHERE a.Malangui = N'" + txtMahopdong.Text + "' AND a.MaKH = b.MaKH AND a.MaNV =c.MaNV";
            tblThongtinHD = Class.Function.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hợp đồng:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            //exRange.Range["C9:E9"].MergeCells = true;
            //exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.Tentheloai, c.Tenbao, a.Ngaydang, a.Tieude, a.Noidung, a.Nhuanbut FROM tblKhachguibai AS a , tblTheloai AS b, tblBao AS c WHERE a.Malangui = N'" + txtMahopdong.Text + "' AND a.Matheloai = b.Matheloai AND a.Mabao = c.Mabao";
            tblThongtinCTHD = Class.Function.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên thể loại";
            exRange.Range["C11:C11"].Value = "Tên báo";
            exRange.Range["D11:D11"].Value = "Ngày đăng";
            exRange.Range["E11:E11"].Value = "Tiêu đề";
            exRange.Range["F11:F11"].Value = "Nội dung";
            exRange.Range["G11:G11"].Value = "Nhuận bút";
            for (hang = 0; hang <= tblThongtinCTHD.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongtinCTHD.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinCTHD.Rows[hang][cot].ToString();
            }

            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            //DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, " + DateTime.Now.ToString(" 'ngày' d 'tháng' M 'năm' yyyy");
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            //exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hợp đồng bài viết";
            exApp.Visible = true;
        }

        private void cbMatheloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNhuanBut();
        }

        private void cbMabao_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNhuanBut();
        }
        private void UpdateNhuanBut()
        {
            // Kiểm tra xem cả hai combobox đều đã có giá trị được chọn
            if (cbMatheloai.SelectedValue != null && cbMabao.SelectedValue != null)
            {
                string maTheLoai = cbMatheloai.SelectedValue.ToString();
                string maBao = cbMabao.SelectedValue.ToString();

                // Truy vấn cơ sở dữ liệu để lấy giá tiền tương ứng
                string query = $"SELECT Nhuanbut FROM tblBao_Theloai WHERE MaTheLoai = N'{maTheLoai}' AND MaBao = N'{maBao}'";
                string giaTien = Class.Function.GetFieldValues(query);

                // Hiển thị giá tiền trong textbox Nhuận bút
                txtNhuanbut.Text = string.IsNullOrEmpty(giaTien) ? "0" : giaTien;
            }
        }

        private void CalculateTotalPrice()
        {
            decimal tongtien = 0;
            foreach (DataRow row in tblHDBV.Rows)
            {
                tongtien += Convert.ToDecimal(row["Nhuanbut"]);
            }
            txtTongtien.Text = tongtien.ToString("0.00");
            lblBangchu.Text = "Bằng chữ: " + Class.Function.ChuyenSoSangChu(txtTongtien.Text);
        }

        private void btnThembaiviet_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường dữ liệu có được nhập đầy đủ không
            if (string.IsNullOrEmpty(txtMahopdong.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hợp đồng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(mskNgaydang.Text))
            {
                MessageBox.Show("Vui lòng nhập ngày đăng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbMatheloai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn thể loại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbMabao.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn báo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtTieude.Text))
            {
                MessageBox.Show("Vui lòng nhập tiêu đề.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtNoidung.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra xem đã có mã thể loại tương tự trong danh sách hay chưa
            bool productExists = false;
            foreach (DataRow row in tblHDBV.Rows)
            {
                if (row["Matheloai"].ToString() == cbMatheloai.SelectedValue.ToString())
                {
                    MessageBox.Show("Đã có bài viết thuộc thẻ loại này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (!productExists)
            {
                DataRow newRow = tblHDBV.NewRow();
                newRow["Matheloai"] = cbMatheloai.SelectedValue;
                newRow["Mabao"] = cbMabao.SelectedValue;
                newRow["Tieude"] = txtTieude.Text;
                newRow["Noidung"] = txtNoidung.Text;
                newRow["Ngaydang"] = mskNgaydang.Text;
                newRow["Nhuanbut"] = txtNhuanbut.Text;
                tblHDBV.Rows.Add(newRow);
            }
            // Cập nhật lại DataGridView
            dgridHopdongbaiviet.DataSource = tblHDBV;
            // Tính toán lại tổng tiền
            CalculateTotalPrice();

            // Reset các giá trị nhập vào
            ResetProductInputs();
        }
        private void ResetProductInputs()
        {
            cbMabao.SelectedIndex = -1;
            cbMatheloai.SelectedIndex = -1;
            txtTieude.Clear();
            txtNoidung.Clear();
            txtNhuanbut.Text = "0";
            mskNgaydang.Clear();
        }

        private void cbMahopdong_DropDown(object sender, EventArgs e)
        {
            Function.FillCombo("SELECT DISTINCT Malangui FROM tblKhachguibai", cbMahopdong, "Malangui", "Malangui");
            cbMahopdong.SelectedIndex = -1;
        }

        private void dgridHopdongbaiviet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblHDBV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                // Lấy chỉ số dòng hiện tại
                int rowIndex = e.RowIndex;

                // Lấy mã sản phẩm và thành tiền của dòng hiện tại
                string matheloai = dgridHopdongbaiviet.Rows[rowIndex].Cells["Matheloai"].Value.ToString();
                double nhuanbut = Convert.ToDouble(dgridHopdongbaiviet.Rows[rowIndex].Cells["Nhuanbut"].Value.ToString());

                // Xóa hàng tạm thời khỏi DataGridView
                DelBaoTamThoi(rowIndex);

                // Cập nhật lại tổng tiền cho hóa đơn
                DelUpdateTongtien(txtMahopdong.Text, nhuanbut);
            }
        }
        private void DelBaoTamThoi(int rowIndex)
        {
            // Xóa hàng tạm thời khỏi DataGridView
            if (rowIndex >= 0 && rowIndex < dgridHopdongbaiviet.Rows.Count)
            {
                dgridHopdongbaiviet.Rows.RemoveAt(rowIndex);
            }
        }
        private void DelUpdateTongtien(string Matheloai, double Nhuanbut)
        {
            try
            {
                // Lấy tổng tiền hiện tại từ txtTongtien
                double Tong = Convert.ToDouble(txtTongtien.Text);

                // Tính toán lại tổng tiền
                double Tongmoi = Tong - Nhuanbut;

                // Cập nhật tổng tiền mới trên giao diện
                txtTongtien.Text = Tongmoi.ToString();
                lblBangchu.Text = "Bằng chữ: " + Class.Function.ChuyenSoSangChu(Tongmoi.ToString());
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                MessageBox.Show("Lỗi khi cập nhật tổng tiền: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

