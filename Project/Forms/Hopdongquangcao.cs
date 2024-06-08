using Project.Class;
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
using System.Xml;
using System.Globalization;
//using Quanlybanhang.Class;



namespace Project.Forms
{
    public partial class Hopdongquangcao : Form
    {
        public Hopdongquangcao()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Đặt form vào chế độ fullscreen
        }
        //1 
        private void Hopdongquangcao_Load(object sender, EventArgs e)
        {
            Function.Connect();
            cbomahopdongqc.DropDownStyle = ComboBoxStyle.DropDownList;

            btnthembao.Enabled = true;
            btnin.Enabled = false;
            btnluu.Enabled = false;
            //btnsua.Enabled = false;
            btnhuy.Enabled = false;



            //Thong tin chung
            //Class.Function.FillCombo("Select MaKH from tblKhachhang", cbomakhachhang, "MaKH", "MaKH");
            //cbomakhachhang.SelectedIndex = -1;
            Class.Function.FillCombo("Select MaNV from tblNhanvien", cbomanhanvien, "MaNV", "MaNV");
            cbomanhanvien.SelectedIndex = -1;
            Class.Function.FillCombo("Select MaLVHD, TenLVHD from tblLinhvuchoatdong", cbomalvhd, "Malvhd", "Tenlvhd");
            cbomalvhd.SelectedIndex = -1;

            //Thong tin chi tiet
            Class.Function.FillCombo("select Mabao from tblBao ", cbomabao, "Mabao", "Mabao");
            cbomabao.SelectedIndex = -1;
            Class.Function.FillCombo("select MaQcao from tblTTQuangcao", cbomaquangcao, "MaQcao", "MaQcao");
            cbomaquangcao.SelectedIndex = -1;
            Class.Function.FillCombo("select DISTINCT MalanQC from tblKhach_Quangcao", cbomahopdongqc, "MalanQC", "MalanQC");
            cbomahopdongqc.SelectedIndex = -1;

            mskngaybatdau.MaskChanged += new EventHandler(mskngaybatdau_MaskChanged);
            mskngaybatdau.KeyPress += new KeyPressEventHandler(mskngaybatdau_KeyPress);
            mskngayketthuc.MaskChanged += new EventHandler(mskngayketthuc_MaskChanged);
            mskngayketthuc.KeyPress += new KeyPressEventHandler(mskngayketthuc_KeyPress);

            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtmahopdongqc.Text != "")
            {
                Load_ThongtinHD();
                btnhuy.Enabled = true;
                btnin.Enabled = true;
            }
            load_datagridview();
        }
        DataTable tblHDQC;
        DataTable tblkh;

        //2 
        private void load_datagridview()
        {
            string sql;
            sql = "SELECT Mabao, MaQcao,Ngayky, Noidung, NgayBD, NgayKT,  ThanhTien FROM tblKhach_Quangcao WHERE MalanQC = N'" + txtmahopdongqc.Text + "'";
            // MessageBox.Show(Sql);
            tblHDQC = Class.Function.GetDataToTable(sql);
            DatagridView.DataSource = tblHDQC;

            DatagridView.Columns[0].HeaderText = "Mã báo";
            DatagridView.Columns[1].HeaderText = "Mã quảng cáo";
            DatagridView.Columns[2].HeaderText = "Ngày ký";
            DatagridView.Columns[3].HeaderText = "Nội dung";
            DatagridView.Columns[4].HeaderText = "Ngày bắt đầu";
            DatagridView.Columns[5].HeaderText = "Ngày kết thúc";
            DatagridView.Columns[6].HeaderText = "Thành tiền";
            DatagridView.Columns[0].Width = 100;
            DatagridView.Columns[1].Width = 100;
            DatagridView.Columns[2].Width = 100;
            DatagridView.Columns[3].Width = 200;
            DatagridView.Columns[4].Width = 100;
            DatagridView.Columns[5].Width = 100;
            DatagridView.Columns[6].Width = 100;
            DatagridView.AllowUserToAddRows = false;
            DatagridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        //3 
        private void Load_ThongtinHD()
        {
            string str;

            str = "SELECT MaNV FROM tblKhach_Quangcao WHERE MalanQC = N'" + txtmahopdongqc.Text + "'";
            cbomanhanvien.Text = Class.Function.GetFieldValues(str);
            str = "SELECT MaKH FROM tblKhach_Quangcao WHERE MalanQC = N'" + txtmahopdongqc.Text + "'";
            txtmakhachhang.Text = Class.Function.GetFieldValues(str);
            str = "Select Ngayky from tblKhach_Quangcao where MalanQC = N'" + txtmahopdongqc.Text + "'";
            txtngayky.Text = Class.Function.GetFieldValues(str);

            if (txtmakhachhang.Text == "")
            {
                txttenkhachhang.Text = "";
                txtdiachi.Text = "";
                mskdienthoai.Text = "";
                mskdidong.Text = "";
                txttenmail.Text = "";
                cbomalvhd.Text = "";

            }
            str = "Select TenKH from tblKhachhang where MaKH= N'" + txtmakhachhang.Text + "'";
            txttenkhachhang.Text = Function.GetFieldValues(str);
            str = "Select DiaChi from tblKhachhang where MaKH = N'" + txtmakhachhang.Text + "'";
            txtdiachi.Text = Function.GetFieldValues(str);
            str = "Select Dienthoai from tblKhachhang where MaKH= N'" + txtmakhachhang.Text + "'";
            mskdienthoai.Text = Function.GetFieldValues(str);
            str = "Select Didong from tblKhachhang where MaKH= N'" + txtmakhachhang.Text + "'";
            mskdidong.Text = Function.GetFieldValues(str);
            str = "Select Email from tblKhachhang where MaKH= N'" + txtmakhachhang.Text + "'";
            txttenmail.Text = Function.GetFieldValues(str);
            str = "Select tblLinhvuchoatdong.MaLVHD from tblLinhvuchoatdong inner join tblKhachhang on tblLinhvuchoatdong.MaLVHD = tblKhachhang.MaLVHD where MaKH= N'" + txtmakhachhang.Text + "'";
            cbomalvhd.Text = Function.GetFieldValues(str);


            if (cbomanhanvien.Text == "")
            {
                txttennhanvien.Text = "";
            }
            str = "Select TenNV from tblNhanvien where MaNV= N'" + cbomanhanvien.Text + "'";
            txttennhanvien.Text = Function.GetFieldValues(str);

            str = "SELECT SUM(Thanhtien) FROM tblKhach_Quangcao where MalanQC = N'" + txtmahopdongqc.Text + "'";
            txtTong.Text = Function.GetFieldValues(str);


            //Khi nhap bao, qcao dc don gia 
            str = "Select Dongia from tblBanggia where Mabao= N'" + cbomabao.Text + "' and MaQcao = N'" + cbomaquangcao.Text + "'";
            txtdongia.Text = Function.GetFieldValues(str);
            //Thanhtien
            str = "SELECT ThanhTien FROM tblKhach_Quangcao where MalanQC = N'" + txtmahopdongqc.Text + "'and tblKhach_Quangcao.Mabao= N'" + cbomabao.Text + "' and tblKhach_Quangcao.MaQcao = N'" + cbomaquangcao.Text + "'";
            txtthanhtien.Text = Function.GetFieldValues(str);

            lblBangchu.Text = "Bằng chữ: " + Class.Function.ChuyenSoSangChu(txtTong.Text);

        }
        //5 
        private void mskngaybatdau_MaskChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void mskngaybatdau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CalculateTotal();
                e.Handled = true; // Ngăn chặn âm báo mặc định của phím Enter
            }
        }

        private void mskngayketthuc_MaskChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void mskngayketthuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CalculateTotal();
                e.Handled = true; // Ngăn chặn âm báo mặc định của phím Enter
            }
        }
        //6 
        private void CalculateTotal()
        {
            if (DateTime.TryParse(mskngaybatdau.Text, out DateTime ngaybatdau) && DateTime.TryParse(mskngayketthuc.Text, out DateTime ngayketthuc) && decimal.TryParse(txtdongia.Text, out decimal dongia))
            {
                TimeSpan chenhLechNgay = ngayketthuc - ngaybatdau;
                decimal thanhtien = (chenhLechNgay.Days * dongia);
                txtthanhtien.Text = thanhtien.ToString("0.00"); // Định dạng thành tiền với 2 chữ số thập phân
                CalculateTotalPrice(); // Update the total price whenever the line item total changes
            }
            else
            {
                //MessageBox.Show("Vui lòng nhập ngay hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DatagridView_Click_1(object sender, EventArgs e)
        {
            if (tblHDQC.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cbomabao.Text = DatagridView.CurrentRow.Cells["Mabao"].Value.ToString();
            cbomaquangcao.Text = DatagridView.CurrentRow.Cells["MaQcao"].Value.ToString();
            txtnoidung.Text = DatagridView.CurrentRow.Cells["Noidung"].Value.ToString();
            mskngaybatdau.Text = DatagridView.CurrentRow.Cells["NgayBD"].Value.ToString();
            mskngayketthuc.Text = DatagridView.CurrentRow.Cells["NgayKT"].Value.ToString();
            txtthanhtien.Text = DatagridView.CurrentRow.Cells["ThanhTien"].Value.ToString();


            Load_ThongtinHD();
            //btnsua.Enabled = true;
            btnhuy.Enabled = true;
            btnin.Enabled = true;

        }

        // 
        private void btntimkiem_Click_1(object sender, EventArgs e)
        {
            if (cbomahopdongqc.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hợp đồng để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomahopdongqc.Focus();
                return;
            }
            txtmahopdongqc.Text = cbomahopdongqc.Text;
            Load_ThongtinHD();
            load_datagridview();
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            btnin.Enabled = true;
            btnboqua.Enabled = true;
            btnthem.Enabled = false;
            btnthembao.Enabled = false;
            btntimkiem.Enabled = false;
            cbomahopdongqc.Enabled = false;
            cbomahopdongqc.SelectedIndex = -1;
        }

        //7 

        private void resetvalues()
        {
            txtmahopdongqc.Text = "";
            txtngayky.Text = "";

            cbomanhanvien.Text = "";
            txttennhanvien.Text = "";
            txtmakhachhang.Text = "";
            txttenkhachhang.Text = "";
            txtdiachi.Text = "";
            txttenmail.Text = "";
            mskdidong.Text = "";
            mskdienthoai.Text = "";
            cbomalvhd.Text = "";

            cbomabao.Text = "";
            cbomaquangcao.Text = "";
            txttenbao.Text = "";
            txttenquangcao.Text = "";
            txtnoidung.Text = "";
            mskngaybatdau.Text = "";
            mskngayketthuc.Text = "";
            txtdongia.Text = "0";
            txtTong.Text = "0";
            txtthanhtien.Text = "0";

            load_datagridview();
        }
        private void resetvaluesHD()
        {
            cbomabao.Text = "";
            txttenbao.Text = "";
            cbomaquangcao.Text = "";
            txttenquangcao.Text = "";
            mskngaybatdau.Text = "  /  /";
            mskngayketthuc.Text = "  /  /";
            txtnoidung.Text = "";
            txtdongia.Text = "0";
            txtthanhtien.Text = "0";
        }
        //4 
        private void btnthem_Click_1(object sender, EventArgs e)
        {
            //btnsua.Enabled = false;
            btnhuy.Enabled = false;
            btnluu.Enabled = true;
            btnin.Enabled = false;
            btnthembao.Enabled = true;
            btnboqua.Enabled = true;
            btntimkiem.Enabled = false;

            cbomahopdongqc.Enabled = false;
            txtmahopdongqc.Enabled = false;
            txtngayky.Enabled = false;
            txttennhanvien.Enabled = false;
            txttenkhachhang.Enabled = true;
            mskdienthoai.Enabled = true;
            txtdiachi.Enabled = true;
            mskdidong.Enabled = true;
            txttenmail.Enabled = true;
            cbomalvhd.Enabled = true;
            txttenbao.Enabled = true;
            txttenquangcao.Enabled = true;
            mskngaybatdau.Enabled = true;
            mskngayketthuc.Enabled = true;

            resetvaluesHD();
            txtmahopdongqc.Text = Class.Function.CreateHDQCKey();
            txtngayky.Text = DateTime.Now.ToString("dd/MM/yyyy");
            load_datagridview();
        }

        //16 
        private void btndong_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn đóng menu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void btntimso_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select MaKH, TenKH, DiaChi, Didong, Email, MaLVHD from tblKhachhang where DienThoai = '" + mskdienthoai.Text + "'";
            tblkh = Class.Function.GetDataToTable(sql);
            if (tblkh.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmakhachhang.Text = Function.CreateCustomerKey();
                txttenkhachhang.Enabled = true;
                txtdiachi.Enabled = true;
                mskdidong.Enabled = true;
                txttenmail.Enabled = true;
                txtnoidung.Enabled = true;
                mskngaybatdau.Enabled = true;
                txtthanhtien.Enabled = true;
                mskngayketthuc.Enabled = true;
                cbomalvhd.Enabled = true;
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
            str = "select MaKH from tblKhachhang where Dienthoai = '" + mskdienthoai.Text + "'";
            txtmakhachhang.Text = Class.Function.GetFieldValues(str);
            str = "select TenKH from tblKhachhang where Dienthoai = '" + mskdienthoai.Text + "'";
            txttenkhachhang.Text = Class.Function.GetFieldValues(str);
            str = "select Diachi from tblKhachhang where Dienthoai = '" + mskdienthoai.Text + "'";
            txtdiachi.Text = Class.Function.GetFieldValues(str);
            str = "select Didong from tblKhachhang where Dienthoai = '" + mskdienthoai.Text + "'";
            mskdidong.Text = Class.Function.GetFieldValues(str);
            str = "select Email from tblKhachhang where Dienthoai = '" + mskdienthoai.Text + "'";
            txttenmail.Text = Class.Function.GetFieldValues(str);
            str = "select MaLVHD from tblKhachhang where DienThoai = '" + mskdienthoai.Text + "'";
            cbomalvhd.Text = Class.Function.GetFieldValues(str);
        }



        //14 
        private void btnhuy_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (tblHDQC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmahopdongqc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có chắn chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblKhach_Quangcao WHERE MalanQC=N'" + txtmahopdongqc.Text + "'";
                Class.Function.RunSqlDel(sql);
                load_datagridview();
                resetvaluesHD();
            }
        }

        //17 
        private void btnluu_Click_1(object sender, EventArgs e)
        {
            string sql;

            if (cbomanhanvien.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomanhanvien.Focus();
                return;
            }/*
            if (txttennhanvien.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennhanvien.Focus();
            }*/

            if (txtmakhachhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmakhachhang.Focus();
                return;
            }
            if (txttenkhachhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenkhachhang.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (mskdidong.Text == "(   )    -")
            {
                MessageBox.Show("Bạn phải nhập di động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdidong.Focus();
                return;
            }
            if (mskdienthoai.Text == "(   )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdienthoai.Focus();
                return;
            }
            if (txttenmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenmail.Focus();
                return;
            }
            if (cbomalvhd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập MaLVHD", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomalvhd.Focus();
                return;
            }

            // luu khach 
            string customerID = txtmakhachhang.Text.Trim();
            string query = $"SELECT COUNT(*) FROM tblKhachhang WHERE MaKH = N'{customerID}'";
            int customerCount = int.Parse(Class.Function.GetFieldValues(query));

            if (customerCount == 0)
            {
                // Insert new customer information
                query = $"INSERT INTO tblkhachhang (MaKH, TenKH, DiaChi, DienThoai, Didong, Email, MaLVHD) " +
                        $"VALUES (N'" + txtmakhachhang.Text.Trim() + "',N'" + txttenkhachhang.Text.Trim() + "',N'" + txtdiachi.Text.Trim() + "','" + mskdienthoai.Text + "','" + mskdidong.Text + "','" + txttenmail.Text.Trim() + "','" + cbomalvhd.SelectedValue.ToString() + "')";
                Class.Function.RunSql(query);
            }

            //luu hop dong 

            foreach (DataRow row in tblHDQC.Rows)
            {
                sql = $"INSERT INTO tblKhach_Quangcao (MalanQC, MaKH, Mabao, MaNV, MaQcao, Noidung, NgayBD, NgayKT, ThanhTien, Ngayky) " +
                     $"VALUES (N'{txtmahopdongqc.Text.Trim()}', N'{txtmakhachhang.Text.Trim()}', " +
                     $"N'{row["Mabao"].ToString()}', N'{cbomanhanvien.SelectedValue}', N'{row["MaQcao"].ToString()}', " +
                     $"N'{row["Noidung"].ToString()}', " +
                     $"'{row["NgayBD"].ToString()}',N'{row["NgayKT"].ToString()}', N'{row["ThanhTien"].ToString()}','{Class.Function.convertdatetime(txtngayky.Text.Trim())}')";
                Class.Function.RunSql(sql);
            }
            MessageBox.Show("Hợp đồng đã được lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_datagridview();
            resetvalues();
            btnhuy.Enabled = false;
            btnthembao.Enabled = true;
            //btnsua.Enabled = true;
            btnin.Enabled = false;
            btnluu.Enabled = false;

        }
        private void btnin_Click_1(object sender, EventArgs e)
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

            // Định dạng tiêu đề công ty
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times New Roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; // Màu xanh da trời
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

            // Định dạng tiêu đề hợp đồng
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times New Roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; // Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HỢP ĐỒNG QUẢNG CÁO";

            // Biểu diễn thông tin chung của hợp đồng quảng cáo
            sql = "SELECT a.MalanQC, b.TenKH, b.Diachi, b.Dienthoai, c.TenNV FROM tblKhach_Quangcao AS a, tblKhachhang AS b, tblNhanvien AS c WHERE a.MalanQC = N'" + txtmahopdongqc.Text + "' AND a.MaKH = b.MaKH AND a.MaNV = c.MaNV";
            tblThongtinHD = Class.Function.GetDataToTable(sql);
            if (tblThongtinHD.Rows.Count > 0)
            {
                exRange.Range["B6:C9"].Font.Size = 12;
                exRange.Range["B6:C9"].Font.Name = "Times New Roman";
                exRange.Range["B6:B6"].Value = "Mã hợp đồng:";
                exRange.Range["C6:E6"].MergeCells = true;
                exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
                exRange.Range["B7:B7"].Value = "Khách hàng:";
                exRange.Range["C7:E7"].MergeCells = true;
                exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][1].ToString();
                exRange.Range["B8:B8"].Value = "Địa chỉ:";
                exRange.Range["C8:E8"].MergeCells = true;
                exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][2].ToString();
                exRange.Range["B9:B9"].Value = "Điện thoại:";
                exRange.Range["C9:E9"].MergeCells = true;
                exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][3].ToString();
            }

            // Lấy thông tin chi tiết hợp đồng
            sql = "SELECT b.TenQcao, c.Tenbao, a.NgayBD, a.NgayKT, a.Noidung, d.Dongia, a.ThanhTien FROM tblKhach_Quangcao AS a, tblTTQuangcao AS b, tblBao AS c, tblBanggia as d WHERE a.MalanQC = N'" + txtmahopdongqc.Text + "' AND a.MaQcao = b.MaQcao AND a.Mabao = c.Mabao AND a.MaQcao = d.MaQcao AND a.Mabao = d.Mabao";
            tblThongtinCTHD = Class.Function.GetDataToTable(sql);
            if (tblThongtinCTHD.Rows.Count > 0)
            {
                // Tạo dòng tiêu đề bảng
                exRange.Range["A11:H11"].Font.Bold = true;
                exRange.Range["A11:H11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A11:H11"].ColumnWidth = 12;
                exRange.Range["A11:A11"].Value = "STT";
                exRange.Range["B11:B11"].Value = "Tên quảng cáo";
                exRange.Range["C11:C11"].Value = "Tên báo";
                exRange.Range["D11:D11"].Value = "Ngày bắt đầu";
                exRange.Range["E11:E11"].Value = "Ngày kết thúc";
                exRange.Range["F11:F11"].Value = "Nội dung";
                exRange.Range["G11:G11"].Value = "Đơn giá";
                exRange.Range["H11:H11"].Value = "Thành tiền";

                for (hang = 0; hang <= tblThongtinCTHD.Rows.Count - 1; hang++)
                {
                    // Điền số thứ tự vào cột 1 từ dòng 12
                    exSheet.Cells[hang + 12, 1] = hang + 1;
                    for (cot = 0; cot <= tblThongtinCTHD.Columns.Count - 1; cot++)
                    {
                        // Điền thông tin hàng từ cột thứ 2, dòng 12
                        exSheet.Cells[hang + 12, cot + 2] = tblThongtinCTHD.Rows[hang][cot].ToString();
                    }
                }

                // Ghi "Nhân viên" chỉ một lần dưới phần chữ ký
                exRange = exSheet.Cells[hang + 17, 1]; // Ô A1 
                exRange.Range["A1:C1"].MergeCells = true;
                exRange.Range["A1:C1"].Font.Italic = true;
                exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A1:C1"].Value = "Hà Nội, " + DateTime.Now.ToString(" 'ngày' dd 'tháng' MM 'năm' yyyy");
                exRange.Range["A2:C2"].Font.Italic = true;
                exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

                // Ghi "Nhân viên" dưới chữ ký
                exRange = exSheet.Cells[hang + 18, 1]; // Dòng tiếp theo của ô A1
                exRange.Range["A1:C1"].MergeCells = true;
                exRange.Range["A1:C1"].Font.Italic = true;
                exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A1:C1"].Value = "Nhân viên";
                exRange.Range["A4:C4"].MergeCells = true;
                exRange.Range["A4:C4"].Font.Italic = true;
                exRange.Range["A4:C4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A4:C4"].Value = tblThongtinHD.Rows[0][4];
            }

            exSheet.Name = "Hợp đồng quảng cáo";
            exApp.Visible = true;
        }

    private void cbomanhanvien_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomanhanvien.Text == "")
            {
                txttennhanvien.Text = "";
            }
            str = "Select TenNV from tblNhanvien where MaNV= N'" + cbomanhanvien.Text + "'";
            txttennhanvien.Text = Function.GetFieldValues(str);
        }
        private void cbomabao_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomabao.Text == "")
            {
                txttenbao.Text = "";
            }
            str = "Select Tenbao from tblBao where Mabao= N'" + cbomabao.Text + "'";
            txttenbao.Text = Function.GetFieldValues(str);
            UpdateDongia();

        }

        private void cbomaquangcao_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomaquangcao.Text == "")
            {
                txttenquangcao.Text = "";
            }
            str = "Select TenQcao from tblTTQuangcao where MaQcao= N'" + cbomaquangcao.Text + "'";
            txttenquangcao.Text = Function.GetFieldValues(str);
            UpdateDongia();
        }
        
        private void UpdateDongia()
        {
            // Kiểm tra xem cả hai combobox đều đã có giá trị được chọn
            if (cbomabao.SelectedValue != null && cbomaquangcao.SelectedValue != null)
            {
                string mabao = cbomabao.SelectedValue.ToString();
                string maquangcao = cbomaquangcao.SelectedValue.ToString();

                // Truy vấn cơ sở dữ liệu để lấy giá tiền tương ứng
                string query1 = $"SELECT Dongia FROM tblBanggia WHERE Mabao = N'{mabao}' AND MaQcao = N'{maquangcao}'";
                string dongia = Class.Function.GetFieldValues(query1);
                string query2 = $"SELECT ThanhTien from tblKhach_Quangcao Where Mabao = N'{mabao}' AND MaQcao = N'{maquangcao}'";
                string thanhtien = Class.Function.GetFieldValues(query2);
                //string query3 = $"SELECT NgayBD from tblKhach_Quangcao Where Mabao = N'{mabao}' AND MaQcao = N'{maquangcao}'";
                //string ngaybd = Class.Function.GetFieldValues(query3);
                //string query4 = $"SELECT NgayKT from tblKhach_Quangcao Where Mabao = N'{mabao}' AND MaQcao = N'{maquangcao}'";
                //string ngaykt = Class.Function.GetFieldValues(query4);
                // Hiển thị đơn giá và ngày trong textbox Đơn giá
                txtdongia.Text = string.IsNullOrEmpty(dongia) ? "0" : dongia;
                //mskngaybatdau.Text = string.IsNullOrEmpty(ngaybd) ? "  /  /    " : ngaybd;
                //mskngayketthuc.Text = string.IsNullOrEmpty(ngaykt) ? "  /  /    " : ngaykt;
                // Hiển thị thành tiền tính từ đơn giá *(Ngày KT - Ngày BD)
                //txtthanhtien.Text = string.IsNullOrEmpty(thanhtien) ? "0" : thanhtien;

            }
        }

        //15 
        private void DelUpdateTongtien(string Mahoadon, double Thanhtien)
        {
            try
            {
                // Lấy tổng tiền hiện tại từ txtTongtien
                double Tong = Convert.ToDouble(txtTong.Text);

                // Tính toán lại tổng tiền
                double Tongmoi = Tong - Thanhtien;

                // Cập nhật tổng tiền mới trên giao diện
                txtTong.Text = Tongmoi.ToString();
                lblBangchu.Text = "Bằng chữ: " + Class.Function.ChuyenSoSangChu(Tongmoi.ToString());
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                MessageBox.Show("Lỗi khi cập nhật tổng tiền: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //10 
        private void CalculateTotalPrice()
        {
            decimal tongtien = 0;
            foreach (DataRow row in tblHDQC.Rows)
            {
                tongtien += Convert.ToDecimal(row["ThanhTien"]);
            }
            txtTong.Text = tongtien.ToString("0.00");
            lblBangchu.Text = "Bằng chữ: " + Class.Function.ChuyenSoSangChu(txtTong.Text);
        }

        // 8 
        private void btnthembao_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường dữ liệu có được nhập đầy đủ không
            if (string.IsNullOrEmpty(txtmahopdongqc.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hợp đồng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //if (string.IsNullOrEmpty(txtngayky.Text))
            //{
            //    MessageBox.Show("Vui lòng nhập ngày ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            if (cbomaquangcao.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã quang cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbomabao.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã báo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txttenbao.Text))
            {
                MessageBox.Show("Vui lòng nhập tên báo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txttenquangcao.Text))
            {
                MessageBox.Show("Vui lòng nhập tên quảng cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtnoidung.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(mskngaybatdau.Text))
            {
                MessageBox.Show("Vui lòng nhập ngày bắt đầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(mskngayketthuc.Text))
            {
                MessageBox.Show("Vui lòng nhập ngày kết thúc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DateTime.ParseExact(txtngayky.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture) >= DateTime.ParseExact(mskngaybatdau.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture))
            {
                MessageBox.Show("Ngày bắt đầu phải lớn hơn hoặc bằng ngày ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskngayketthuc.Text = "";
                mskngaybatdau.Text = "";
                return;
            }

            if (DateTime.ParseExact(mskngaybatdau.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture) >= DateTime.ParseExact(mskngayketthuc.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture))
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskngayketthuc.Text = "";
                mskngaybatdau.Text = "";
                return;
            }
            
            bool productExists = false;
            foreach (DataRow row in tblHDQC.Rows)
            {
                if ((row["Mabao"].ToString() == cbomabao.SelectedValue.ToString()) && (row["MaQcao"].ToString() == cbomaquangcao.SelectedValue.ToString()))
                {
                    MessageBox.Show("Đã có bài viết thuộc mã báo, mã quảng cáo này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (!productExists)
            {
                DataRow newRow = tblHDQC.NewRow();
                newRow["Mabao"] = cbomabao.SelectedValue;
                newRow["MaQcao"] = cbomaquangcao.SelectedValue;
                newRow["Ngayky"] = txtngayky.Text;
                newRow["Noidung"] = txtnoidung.Text;
                newRow["NgayBD"] = mskngaybatdau.Text;
                newRow["NgayKT"] = mskngayketthuc.Text;
                newRow["ThanhTien"] = txtthanhtien.Text;
                tblHDQC.Rows.Add(newRow);
            } 

            // Tính toán thành tiền
            CalculateTotal();

            // Cập nhật lại DataGridView
            DatagridView.DataSource = tblHDQC;

            // Tính toán lại tổng tiền
            CalculateTotalPrice();

            // Reset các giá trị nhập vào
            resetvaluesHD(); 
        }
        //18 
        private void btnboqua_Click(object sender, EventArgs e)
        {
            resetvalues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnhuy.Enabled = true;
            //btnsua.Enabled = true;
            btnluu.Enabled = false;
            btntimkiem.Enabled=true;
            cbomahopdongqc.Enabled = true;
        }

        private void DatagridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblHDQC.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                // Lấy chỉ số dòng hiện tại
                int rowIndex = e.RowIndex;

                // Lấy mã báo, mã qc và thành tiền của dòng hiện tại
                string mabao = DatagridView.Rows[rowIndex].Cells["Mabao"].Value.ToString();
                string maqc = DatagridView.Rows[rowIndex].Cells["MaQcao"].Value.ToString();
                double thanhtien = Convert.ToDouble(DatagridView.Rows[rowIndex].Cells["ThanhTien"].Value.ToString());

                // Xóa hàng tạm thời khỏi DataGridView
                DelBaoTamThoi(rowIndex);

                // Cập nhật lại tổng tiền cho hóa đơn
                DelUpdateTongtien(txtmahopdongqc.Text, thanhtien);
            }
        }
        private void DelBaoTamThoi(int rowIndex)
        {
            // Xóa hàng tạm thời khỏi DataGridView
            if (rowIndex >= 0 && rowIndex < DatagridView.Rows.Count)
            {
                DatagridView.Rows.RemoveAt(rowIndex);
            }
        }

        
    }
}


