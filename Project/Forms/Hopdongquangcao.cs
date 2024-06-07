﻿using Project.Class;
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
//using Quanlybanhang.Class;



namespace Project.Forms
{
    public partial class Hopdongquangcao : Form
    {
        public Hopdongquangcao()
        {
            InitializeComponent();
        }

        private void Hopdongquangcao_Load(object sender, EventArgs e)
        {
            Function.Connect();
            cbomahopdongqc.DropDownStyle = ComboBoxStyle.DropDownList;

            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            btnin.Enabled = false;




            //txtmahopdongqc.ReadOnly = true;
            //txttennhanvien.Enabled = true;
            //txttenkhachhang.Enabled = false;
            //txtdiachi.Enabled = false;
            //txtdienthoai.Enabled = true;
            //txtdidong.Enabled = false;
            //txtemail.Enabled = false;
            //txttenbao.Enabled = true;

            //txttenquangcao.ReadOnly= true;
            //txtngaybatdau.ReadOnly= true;
            //txtngayketthuc.ReadOnly= true;
            //txtdongia.ReadOnly = true;
            //txttongtien.ReadOnly = true;

            //Thong tin chung
            Class.Function.FillCombo("Select MaKH from tblKhachhang", cbomakhachhang, "MaKH", "MaKH");
            cbomakhachhang.SelectedIndex = -1;
            Class.Function.FillCombo("Select MaNV from tblNhanvien", cbomanhanvien, "MaNV", "MaNV");
            cbomanhanvien.SelectedIndex = -1;
            Class.Function.FillCombo("Select MaLVHD from tblLinhvuchoatdong", cbomalvhd, "Malvhd", "Malvhd");
            cbomalvhd.SelectedIndex = -1;

            //Thong tin chi tiet
            Class.Function.FillCombo("select Mabao from tblBao ", cbomabao, "Mabao", "Mabao");
            cbomabao.SelectedIndex = -1;
            Class.Function.FillCombo("select MaQcao from tblTTQuangcao", cbomaquangcao, "MaQcao", "MaQcao");
            cbomaquangcao.SelectedIndex = -1;
            Class.Function.FillCombo("select MalanQC from tblKhach_Quangcao", cbomahopdongqc, "MalanQC", "MalanQC");
            cbomahopdongqc.SelectedIndex = -1;


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
        private void load_datagridview()
        {
            string sql;
            sql = "SELECT tblBao.Mabao, tblBao.Tenbao, tblTTQuangcao.MaQcao, tblTTQuangcao.TenQcao, Noidung, NgayBD, NgayKT, Dongia, (tblBanggia.Dongia * DATEDIFF(day,NgayBD,NgayKT)) as Thanhtien FROM tblKhach_Quangcao INNER JOIN tblBao ON tblKhach_Quangcao.Mabao=tblBao.Mabao INNER JOIN tblTTQuangcao ON tblKhach_Quangcao.MaQcao= tblTTQuangcao.MaQcao INNER JOIN tblBanggia ON tblBanggia.Mabao=tblKhach_Quangcao.Mabao WHERE tblKhach_Quangcao.MalanQC = N'" + txtmahopdongqc.Text + "'";
            // MessageBox.Show(Sql);
            tblHDQC = Class.Function.GetDataToTable(sql);
            DatagridView.DataSource = tblHDQC;

            DatagridView.Columns[0].HeaderText = "Mã báo";
            DatagridView.Columns[1].HeaderText = "Tên báo";
            DatagridView.Columns[2].HeaderText = "Mã quảng cáo";
            DatagridView.Columns[3].HeaderText = "Tên quảng cáo";
            DatagridView.Columns[4].HeaderText = "Nội dung";
            DatagridView.Columns[5].HeaderText = "Ngày bắt đầu";
            DatagridView.Columns[6].HeaderText = "Ngày kết thúc";
            DatagridView.Columns[7].HeaderText = "Đơn giá";
            DatagridView.Columns[8].HeaderText = "Thành tiền";
            DatagridView.Columns[0].Width = 100;
            DatagridView.Columns[1].Width = 100;
            DatagridView.Columns[2].Width = 100;
            DatagridView.Columns[3].Width = 100;
            DatagridView.Columns[4].Width = 200;
            DatagridView.Columns[5].Width = 100;
            DatagridView.Columns[6].Width = 100;
            DatagridView.Columns[7].Width = 100;
            DatagridView.Columns[8].Width = 200;
            DatagridView.AllowUserToAddRows = false;
            DatagridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Load_ThongtinHD()
        {
            string str;

            str = "SELECT MaNV FROM tblKhach_Quangcao WHERE MalanQC = N'" + txtmahopdongqc.Text + "'";
            cbomanhanvien.Text = Class.Function.GetFieldValues(str);
            str = "SELECT MaKH FROM tblKhach_Quangcao WHERE MalanQC = N'" + txtmahopdongqc.Text + "'";
            cbomakhachhang.Text = Class.Function.GetFieldValues(str);
            
            if (cbomakhachhang.Text == "")
            {
                txttenkhachhang.Text = "";
                txtdiachi.Text = "";
                mskdienthoai.Text = "";
                mskdidong.Text = "";
                txtemail.Text = "";
                cbomalvhd.Text = "";

            }
            str = "Select TenKH from tblKhachhang where MaKH= N'" + cbomakhachhang.Text + "'";
            txttenkhachhang.Text = Function.GetFieldValues(str);
            str = "Select DiaChi from tblKhachhang where MaKH = N'" + cbomakhachhang.Text + "'";
            txtdiachi.Text = Function.GetFieldValues(str);
            str = "Select Dienthoai from tblKhachhang where MaKH= N'" + cbomakhachhang.Text + "'";
            mskdienthoai.Text = Function.GetFieldValues(str);
            str = "Select Didong from tblKhachhang where MaKH= N'" + cbomakhachhang.Text + "'";
            mskdidong.Text = Function.GetFieldValues(str);
            str = "Select Email from tblKhachhang where MaKH= N'" + cbomakhachhang.Text + "'";
            txtemail.Text = Function.GetFieldValues(str);
            str = "Select tblLinhvuchoatdong.MaLVHD from tblLinhvuchoatdong inner join tblKhachhang on tblLinhvuchoatdong.MaLVHD = tblKhachhang.MaLVHD where MaKH= N'" + cbomakhachhang.Text + "'";
            cbomalvhd.Text = Function.GetFieldValues(str);


            if (cbomanhanvien.Text == "")
            {
                txttennhanvien.Text = "";
            }
            str = "Select TenNV from tblNhanvien where MaNV= N'" + cbomanhanvien.Text + "'";
            txttennhanvien.Text = Function.GetFieldValues(str);

            str = "SELECT SUM(tblBanggia.Dongia * DATEDIFF(day, tblKhach_Quangcao.NgayBD, tblKhach_Quangcao.NgayKT)) AS Tongtien FROM tblKhach_Quangcao INNER JOIN tblBanggia ON tblKhach_Quangcao.Mabao = tblBanggia.Mabao where MalanQC = N'" + txtmahopdongqc.Text + "'";
            txtTong.Text = Function.GetFieldValues(str);


            //Khi nhap bao, qcao dc don gia 
            str = "Select Dongia from tblBanggia where Mabao= N'" + cbomabao.Text + "' and MaQcao = N'" + cbomaquangcao.Text + "'";
            txtdongia.Text = Function.GetFieldValues(str);

        }
        
        private void DatagridView_Click_1(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmahopdongqc.Focus();
                return;
            }
            if (tblHDQC.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cbomabao.Text = DatagridView.CurrentRow.Cells["Mabao"].Value.ToString();
            txttenbao.Text = DatagridView.CurrentRow.Cells["Tenbao"].Value.ToString();
            cbomaquangcao.Text = DatagridView.CurrentRow.Cells["MaQcao"].Value.ToString();
            txttenquangcao.Text = DatagridView.CurrentRow.Cells["TenQcao"].Value.ToString();
            txtnoidung.Text = DatagridView.CurrentRow.Cells["Noidung"].Value.ToString();
            mskngaybatdau.Text = DatagridView.CurrentRow.Cells["NgayBD"].Value.ToString();
            mskngayketthuc.Text = DatagridView.CurrentRow.Cells["NgayKT"].Value.ToString();
            txtdongia.Text = DatagridView.CurrentRow.Cells["Dongia"].Value.ToString();

            Load_ThongtinHD();
            btnsua.Enabled = true;
            btnhuy.Enabled = true;
            btnin.Enabled = true;

        }


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
            btnhuy.Enabled = true;
            btnluu.Enabled = true;
            btnin.Enabled = true;

            cbomahopdongqc.SelectedIndex = -1;
            resetvaluesHD();
        }

        private void resetvalues()
        {
            txtmahopdongqc.Text = "";

            cbomanhanvien.Text = "";
            txttennhanvien.Text = "";
            cbomakhachhang.Text = "";
            txttenkhachhang.Text = "";
            txtdiachi.Text = "";
            txtemail.Text = "";
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
            txtdongia.Text = "";
            txtTong.Text = "0";

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
            txtdongia.Text = "";

        }
        private void btnthem_Click_1(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            btnluu.Enabled = true;
            btnin.Enabled = false;
            btnthem.Enabled = false;

            txtmahopdongqc.Enabled = false;
            txtngayky.Enabled = false;
            txttennhanvien.Enabled = false;
            txttenkhachhang.Enabled = true;
            mskdienthoai.Enabled = true;
            txtdiachi.Enabled = true;
            mskdidong.Enabled = true;
            txtemail.Enabled = true;
            cbomalvhd.Enabled = true;
            txttenbao.Enabled = true;
            txttenquangcao.Enabled = true;
            mskngaybatdau.Enabled = true;
            mskngayketthuc.Enabled = true;

            resetvalues();
            txtmahopdongqc.Text = Class.Function.CreateHDQCKey();
            txtngayky.Text = DateTime.Now.ToString("dd/MM/yyyy");

            load_datagridview();
        }

        private void btndong_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn đóng menu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }
        private void btntimso_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select * from tblKhachhang where DienThoai = '" + mskdienthoai.Text + "'";
            tblkh = Class.Function.GetDataToTable(sql);
            if (tblkh.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomakhachhang.Text = Function.CreateCustomerKey();
                txttenkhachhang.Enabled = true;
                txtdiachi.Enabled = true;
                mskdidong.Enabled = true;
                txtemail.Enabled = true;
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
            str = "select MaKH from tblKhachhang where DienThoai = '" + mskdienthoai.Text + "'";
            cbomakhachhang.Text = Class.Function.GetFieldValues(str);
            str = "select TenKH from tblKhachhang where DienThoai = '" + mskdienthoai.Text + "'";
            txttenkhachhang.Text = Class.Function.GetFieldValues(str);
            str = "select DiaChi from tblKhachhang where DienThoai = '" + mskdienthoai.Text + "'";
            txtdiachi.Text = Class.Function.GetFieldValues(str);
            str = "select Didong from tblKhachhang where DienThoai = '" + mskdienthoai.Text + "'";
            mskdidong.Text = Class.Function.GetFieldValues(str);
            str = "select Email from tblKhachhang where DienThoai = '" + mskdienthoai.Text + "'";
            txtemail.Text = Class.Function.GetFieldValues(str);
            str = "select MaLVHD from tblLinhvuchoatdong inner join tblKhachhang on tblLinhvuchoatdong.MaLVHD=tblKhachhang.MaLVHD where DienThoai = '" + mskdienthoai.Text + "'";
            cbomalvhd.Text = Class.Function.GetFieldValues(str);

        }




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
                sql = "DELETE tblKhachguibai WHERE Malangui=N'" + txtmahopdongqc.Text + "'";
                Class.Function.RunSqlDel(sql);
                load_datagridview();
                resetvalues();
            }
        }


        private void btnluu_Click_1(object sender, EventArgs e)
        {
            string sql;

            if (cbomanhanvien.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomanhanvien.Focus();
                return;
            }
            if (txttennhanvien.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennhanvien.Focus();
            }

            if (cbomakhachhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomakhachhang.Focus();
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
            if (txtemail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtemail.Focus();
                return;
            }
            if (cbomalvhd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập MaLVHD", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomalvhd.Focus();
                return;
            }
            sql = "Insert into tblKhachhang (MaKH, TenKH, Diachi, Dienthoai, Didong, Email, MaLVHD) values (N'" + cbomakhachhang.SelectedValue + "',N'" + txttenkhachhang.Text.Trim() + "',N'" + txtdiachi.Text.Trim() + "',N'" + mskdienthoai.Text.Trim() + "', N'" + mskdidong.Text.Trim() + "',N'" + txtemail.Text.Trim() + "', N'" + cbomalvhd.SelectedValue + "')";

            Class.Function.RunSql(sql);
            //}
            if (cbomabao.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã báo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomabao.Focus();
                return;
            }
            if (cbomaquangcao.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã quảng cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomaquangcao.Focus();
                return;
            }
            if (txtnoidung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnoidung.Focus();
                return;
            }

            if (mskngaybatdau.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaybatdau.Focus();
                return;
            }
            if (mskngayketthuc.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngayketthuc.Focus();
                return;
            }
            if (txtdongia.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdongia.Focus();
                return;
            }
            sql = "Insert into tblKhach_Quangcao (MalanQC, MaKH, Mabao, MaNV, MaQcao, Noidung, NgayBD, NgayKT, Tongtien ) values (N'" + txtmahopdongqc.Text.Trim() + "',N'" + cbomakhachhang.SelectedValue + "', N'" + cbomabao.SelectedValue + "', N'" + cbomanhanvien.SelectedValue + "',N'" + cbomaquangcao.SelectedValue + "',N'" + txtnoidung.Text.Trim() + "', N'" + mskngaybatdau.Text.Trim() + "',N'" + mskngayketthuc.Text.Trim() + "',N'" + txtTong.Text.Trim() + "')";

            Class.Function.RunSql(sql);
            load_datagridview();
            resetvaluesHD();
            btnhuy.Enabled = false;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnin.Enabled = false;
            btnluu.Enabled = false;

        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            string sql;
            txtmahopdongqc.Enabled = false;
            cbomanhanvien.Enabled = false;
            cbomakhachhang.Enabled = false;
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
            if (txtemail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtemail.Focus();
                return;
            }
            if (cbomalvhd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập MaLVHD", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomalvhd.Focus();
                return;
            }

            if (cbomabao.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã báo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomabao.Focus();
                return;
            }
            if (cbomaquangcao.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã quảng cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomaquangcao.Focus();
                return;
            }
            if (txttenbao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên báo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenbao.Focus();
                return;
            }
            if (txttenquangcao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên quảng cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenquangcao.Focus();
                return;
            }
            if (mskngaybatdau.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaybatdau.Focus();
                return;
            }
            if (mskngayketthuc.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngayketthuc.Focus();
                return;
            }
            if (txtdongia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdongia.Focus();
                return;
            }
            sql = "UPDATE tblKhach_Quangcao SET MaKH='" + cbomakhachhang.Text.Trim().ToString() + "',Mabao=N'" + cbomabao.SelectedValue.ToString() + "',MaQcao='" + cbomaquangcao.SelectedValue.ToString() + "',Noidung='" + txtnoidung.Text.Trim().ToString() + "', MaNV='" + cbomanhanvien.SelectedValue.ToString() + "',NgayBD='" + mskngaybatdau.Text + "',NgayKT='" + mskngayketthuc.Text + "' WHERE MalanQC=N'" + txtmahopdongqc.Text + "'";
            Class.Function.RunSql(sql);
            Load_ThongtinHD();
            load_datagridview();
            resetvalues();
            btnin.Enabled = false;

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
            exRange.Range["C2:E2"].Value = "HỢP ĐỒNG QUẢNG CÁO";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.MalanQC, b.TenKH, b.Diachi, b.Dienthoai, c.TenNV FROM tblKhach_Quangcao AS a, tblKhachhang AS b, tblNhanvien AS c WHERE a.MalanQC = N'" + txtmahopdongqc.Text + "' AND a.MaKH = b.MaKH AND a.MaNV =c.MaNV";
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
            sql = "SELECT b.TenQcao, c.Tenbao, a.NgayBD, a.NgayKT, a.Noidung, d.Dongia, a.Tongtien FROM tblKhach_Quangcao AS a , tblTTQuangcao AS b, tblBao AS c, tblBanggia as d WHERE a.MalanQC = N'" + txtmahopdongqc.Text + "' AND a.MaQcao = b.MaQcao AND a.Mabao = c.Mabao AND a.Mabao=d.Mabao";
            tblThongtinCTHD = Class.Function.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên quảng cáo";
            exRange.Range["C11:C11"].Value = "Tên báo";
            exRange.Range["D11:D11"].Value = "Ngày bắt đầu";
            exRange.Range["E11:E11"].Value = "Ngày kết thúc";
            exRange.Range["F11:F11"].Value = "Nội dung";
            exRange.Range["G11:G11"].Value = "Đơn giá";
            exRange.Range["H11:H11"].Value = "Tổng tiền";
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

        private void cbomakhachhang_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomakhachhang.Text == "")
            {
                txttenkhachhang.Text = "";
                txtdiachi.Text = "";
                mskdienthoai.Text = "";
                mskdidong.Text = "";
                txtemail.Text = "";
                cbomalvhd.Text = "";

            }
            str = "Select TenKH from tblKhachhang where MaKH= N'" + cbomakhachhang.Text + "'";
            txttenkhachhang.Text = Function.GetFieldValues(str);
            str = "Select DiaChi from tblKhachhang where MaKH = N'" + cbomakhachhang.Text + "'";
            txtdiachi.Text = Function.GetFieldValues(str);
            str = "Select Dienthoai from tblKhachhang where MaKH= N'" + cbomakhachhang.Text + "'";
            mskdienthoai.Text = Function.GetFieldValues(str);
            str = "Select Didong from tblKhachhang where MaKH= N'" + cbomakhachhang.Text + "'";
            mskdidong.Text = Function.GetFieldValues(str);
            str = "Select Email from tblKhachhang where MaKH= N'" + cbomakhachhang.Text + "'";
            txtemail.Text = Function.GetFieldValues(str);
            str = "Select tblLinhvuchoatdong.MaLVHD from tblLinhvuchoatdong inner join tblKhachhang on tblLinhvuchoatdong.MaLVHD = tblKhachhang.MaLVHD where MaKH= N'" + cbomakhachhang.Text + "'";
            cbomalvhd.Text = Function.GetFieldValues(str);
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
                string query2 = $"SELECT (Dongia*DATEDIFF(day,NgayBD,NgayKT)) as Thanhtien from tblKhach_Quangcao inner join tblBanggia on tblKhach_Quangcao.Mabao = tblBanggia.Mabao Where tblBanggia.Mabao = N'{mabao}' AND tblBanggia.MaQcao = N'{maquangcao}'";
                string thanhtien = Class.Function.GetFieldValues(query2);
                string query3 = $"SELECT NgayBD from tblKhach_Quangcao inner join tblBanggia on tblKhach_Quangcao.Mabao = tblBanggia.Mabao Where tblBanggia.Mabao = N'{mabao}' AND tblBanggia.MaQcao = N'{maquangcao}'";
                string ngaybd = Class.Function.GetFieldValues(query3);
                string query4 = $"SELECT NgayKT from tblKhach_Quangcao inner join tblBanggia on tblKhach_Quangcao.Mabao = tblBanggia.Mabao Where tblBanggia.Mabao = N'{mabao}' AND tblBanggia.MaQcao = N'{maquangcao}'";
                string ngaykt = Class.Function.GetFieldValues(query4);
                // Hiển thị đơn giá và ngày trong textbox Đơn giá
                txtdongia.Text = string.IsNullOrEmpty(dongia) ? "0" : dongia;
                mskngaybatdau.Text = string.IsNullOrEmpty(ngaybd) ? "  /  /    " : ngaybd;
                mskngayketthuc.Text = string.IsNullOrEmpty(ngaykt) ? "  /  /    " : ngaykt;
                // Hiển thị thành tiền tính từ đơn giá *(Ngày KT - Ngày BD)
                //txtthanhtien.Text = string.IsNullOrEmpty(thanhtien) ? "0" : thanhtien;

            }
        }
        
        private void btnthembao_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường dữ liệu có được nhập đầy đủ không
            /*
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
            ResetProductInputs();*/
        }
    }
}


