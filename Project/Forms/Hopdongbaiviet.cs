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
            this.SizeChanged += new EventHandler(Hopdongbaiviet_SizeChanged);

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
            dgridHopdongbaiviet.Columns[0].Width = 120;
            dgridHopdongbaiviet.Columns[1].Width = 120;
            dgridHopdongbaiviet.Columns[2].Width = 150;
            dgridHopdongbaiviet.Columns[3].Width = 200;
            dgridHopdongbaiviet.Columns[4].Width = 120;
            dgridHopdongbaiviet.Columns[5].Width = 120;
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
            btnSua.Enabled = true;
            btnHuy.Enabled = true;
            btnIn.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
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
                query = $"INSERT INTO tblkhachhang (MaKH, TenKH, DiaChi, DienThoai, Didong, Emali, MaLVHD) " +
                        $"(N'" + txtMakhach.Text.Trim() + "',N'" + txtTenkhach.Text.Trim() + "',N'" + txtDiachi.Text.Trim() + "','" + mskDienthoai.Text + "','" + mskDidong.Text + "','" + txtEmail.Text.Trim() + "','" + cbLVHD.SelectedValue.ToString() + "')";
                Class.Function.RunSql(query);
            }
            //sql = "INSERT INTO tblKhachhang(MaKH,TenKH,Diachi, Dienthoai, Didong, Email, MaLVHD) VALUES (N'" + txtMakhach.Text.Trim() + "',N'" + txtTenkhach.Text.Trim() + "',N'" + txtDiachi.Text.Trim() + "','" + mskDienthoai.Text + "','" + mskDidong.Text + "','" + txtEmail.Text.Trim() + "','" + cbLVHD.SelectedValue.ToString() + "')";
            //Class.Function.RunSql(sql);
            //}
            if (cbMatheloai.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMatheloai.Focus();
                return;
            }
            if (cbMabao.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã báo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMabao.Focus();
                return;
            }
            if (txtTieude.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tiêu đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTieude.Focus();
                return;
            }
            if (txtNoidung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoidung.Focus();
                return;
            }
            if (mskNgaydang.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày đăng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaydang.Focus();
                return;
            }
            if (txtNhuanbut.Text == "")
            {
                MessageBox.Show("Bạn phải nhập nhuận bút", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhuanbut.Focus();
                return;
            }
            sql = "Insert into tblKhachguibai (Malangui, MaKH, Matheloai, Mabao, Tieude, Noidung, MaNV, Ngaydang, Nhuanbut) VALUES (N'" + txtMahopdong.Text.Trim() + "',N'" + txtMakhach.Text.Trim() + "',N'" + cbMatheloai.SelectedValue.ToString() + "',N'" + cbMabao.SelectedValue.ToString() + "',N'" + txtTieude.Text.Trim() + "',N'" + txtNoidung.Text.Trim() + "','" + cbManhanvien.SelectedValue.ToString() + "','" + mskNgaydang.Text + "', '" + txtNhuanbut.Text.Trim() + "')";
            Class.Function.RunSql(sql);
            Load_datagridview();
            resetvaluesHD();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
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
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            txtMahopdong.Enabled = false;
            cbManhanvien.Enabled = false;
            txtMakhach.Enabled = false;
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
            if (cbMatheloai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMatheloai.Focus();
                return;
            }
            if (cbMabao.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã báo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMabao.Focus();
                return;
            }
            if (txtTieude.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tiêu đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTieude.Focus();
                return;
            }
            if (mskNgaydang.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày đăng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaydang.Focus();
                return;
            }
            if (txtNhuanbut.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhuận bút", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhuanbut.Focus();
                return;
            }
            sql = "UPDATE tblKhachguibai SET MaKH='" + txtMakhach.Text.Trim().ToString() + "',Matheloai=N'" + cbMatheloai.SelectedValue.ToString() + "',Mabao=N'" + cbMabao.SelectedValue.ToString() + "',Tieude=N'" + txtTieude.Text.Trim().ToString() + "', Noidung=N'" + txtNoidung.Text.Trim().ToString() + "',MaNV='" + cbManhanvien.SelectedValue.ToString() + "',Ngaydang='" + mskNgaydang.Text + "', Nhuanbut='" + txtNhuanbut.Text.Trim().ToString() + "' WHERE Malangui=N'" + txtMahopdong.Text + "'";
            Class.Function.RunSql(sql);
            Load_TTHD();
            Load_datagridview();
            resetvalues();
            btnIn.Enabled = false;
        }

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

        private void Hopdongbaiviet_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Thực hiện các thao tác cần thiết khi form được mở rộng toàn màn hình
                // Ví dụ: cập nhật lại giao diện, điều chỉnh kích thước các điều khiển, v.v.
            }
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
    }
}

