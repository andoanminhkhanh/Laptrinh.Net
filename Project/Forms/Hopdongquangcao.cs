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

        private void Hopdongquangcao_Load (object sender, EventArgs e)
        {
            Function.Connect();
            cbomahopdong.DropDownStyle = ComboBoxStyle.DropDownList;

            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            btnin.Enabled = false;
            txtdongia.Text = "0";
            txttongtien.Text = "0";
            /*txtmahopdong.ReadOnly = true;
            txttennhanvien.Enabled = true;
            
            txttenkhachhang.Enabled = false;
            txtdiachi.Enabled = false;
            txtdienthoai.Enabled = true;
            txtdidong.Enabled = false;
            txtemail.Enabled = false;

            txttenbao.Enabled = true;
            
            txttenquangcao.ReadOnly= true;
            txtngaybatdau.ReadOnly= true;
            txtngayketthuc.ReadOnly= true;
            txtdongia.ReadOnly = true;
            txttongtien.ReadOnly = true;
            
            */
            Class.Function.FillCombo("Select MaKH, TenKH from tblKhachhang", cbomakhachhang, "MaKH", "TenKH");
            cbomakhachhang.SelectedIndex = -1;
            Class.Function.FillCombo("Select MaNV, TenNV from tblNhanvien", cbomanhanvien, "MaNV", "TenNV");
            cbomanhanvien.SelectedIndex = -1;
            Function.FillCombo("SELECT Mabao, Tenbao FROM tblBao ", cbomabao, "Mabao", "Tenbao");
            cbomabao.SelectedIndex = -1;
            Function.FillCombo("SELECT MaQcao, TenQcao FROM tblTTQuangcao", cbomaquangcao, "Maquangcao", "Tenquangcao");
            cbomaquangcao.SelectedIndex = -1;
            Function.FillCombo("SELECT MalanQC FROM tblKhach_Quangcao", cbomahopdong, "Mahopdong", "Mahopdong");
            cbomahopdong.SelectedIndex = -1;

            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtmahopdong.Text != "")
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
            sql = "SELECT Mabao, tblBao.Tenbao, MaQcao, tblTTQuangcao.TenQcao, Noidung, NgayBD, NgayKT, (Dongia*(NgayBD-NgayKT)) as Tongtien FROM tblKhach_Quangcao INNER JOIN tblBao ON tblKhach_Quangcao.Mabao=tblBao.Mabao INNER JOIN tblKhach_Quangcao.MaQcao=tblTTQuangcao.MaQcao INNER JOIN tblBanggia ON tblBanggia.Mabao=tblKhach_Quangcao.Mabao WHERE MalanQC = N'" + txtmahopdong.Text + "'";
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
            DatagridView.Columns[7].HeaderText = "Tổng tiền";
            DatagridView.Columns[0].Width = 100;
            DatagridView.Columns[1].Width = 100;
            DatagridView.Columns[2].Width = 100;
            DatagridView.Columns[3].Width = 100;
            DatagridView.Columns[4].Width = 200;
            DatagridView.Columns[5].Width = 100;
            DatagridView.Columns[6].Width = 100;
            DatagridView.Columns[7].Width = 100;
            DatagridView.AllowUserToAddRows = false;
            DatagridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Load_ThongtinHD()
        {
            string str;
            str = "SELECT MaNV FROM tblKhach_Quangcao WHERE MalanQC = N'" + txtmahopdong.Text + "'";
            cbomanhanvien.Text = Class.Function.GetFieldValues(str);
            str = "SELECT MaKH FROM tblKhach_Quangcao WHERE MalanQC = N'" + txtmahopdong.Text + "'";
            cbomakhachhang.Text = Class.Function.GetFieldValues(str);
            if (cbomakhachhang.Text == "")
            {
                txttenkhachhang.Text = "";
                txtdiachi.Text = "";
                txtdienthoai.Text = "";
                txtdidong.Text = "";
                txtemail.Text = "";

            }
            str = "Select TenKH from tblKhachhang where MaKH= N'" + cbomakhachhang.Text + "'";
            cbomakhachhang.Text = Function.GetFieldValues(str);
            str = "Select DiaChi from tblKhachhang where MaKH = N'" + cbomakhachhang.Text + "'";
            txtdiachi.Text = Function.GetFieldValues(str);
            str = "Select Dienthoai from tblKhachhang where MaKH= N'" + cbomakhachhang.Text + "'";
            txtdienthoai.Text = Function.GetFieldValues(str);
            str = "Select Didong from tblKhachhang where MaKH= N'" + cbomakhachhang.Text + "'";
            txtdidong.Text = Function.GetFieldValues(str);
            str = "Select Email from tblKhachhang where MaKH= N'" + cbomakhachhang.Text + "'";
            txtemail.Text = Function.GetFieldValues(str);


        }

        private void DatagridView_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmahopdong.Focus();
                return;
            }
            if (tblHDQC.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cbomabao.Text = DatagridView.CurrentRow.Cells["Mabao"].Value.ToString();
            cbomaquangcao.Text = DatagridView.CurrentRow.Cells["MaQcao"].Value.ToString();
            txttenbao.Text = DatagridView.CurrentRow.Cells["Tenbao"].Value.ToString();
            txttenquangcao.Text = DatagridView.CurrentRow.Cells["Tenquangcao"].Value.ToString();
            txtngaybatdau.Text = DatagridView.CurrentRow.Cells["Ngaybatdau"].Value.ToString();
            txtngayketthuc.Text = DatagridView.CurrentRow.Cells["Ngayketthuc"].Value.ToString();
            txtdongia.Text = DatagridView.CurrentRow.Cells["Dongia"].Value.ToString();
            Load_ThongtinHD();
            btnsua.Enabled = true;
            btnhuy.Enabled = true;
            btnin.Enabled = true;
        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (cbomahopdong.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomahopdong.Focus();
                return;
            }
            txtmahopdong.Text = cbomahopdong.Text;
            Load_ThongtinHD();
            load_datagridview();
            btnhuy.Enabled = true;
            btnluu.Enabled = true;
            btnin.Enabled = true;
            cbomahopdong.SelectedIndex = -1;

        }

        private void cboMaHDBan_DropDown(object sender, EventArgs e)
        {
            Function.FillCombo("SELECT MalanQC FROM tblKhach_Quangcao", cbomahopdong, "Mahopdong", "Mahopdong");
            cbomahopdong.SelectedIndex = -1;
        }


        private void resetvalues()
        {
            txtmahopdong.Text = "";
            txtngayky.Text = "";
            cbomanhanvien.Text = "";
            txttennhanvien.Text = "";
            cbomakhachhang.Text = "";
            txttenkhachhang.Text = "";
            txtdiachi.Text = "";
            txtemail.Text = "";
            txtdidong.Text = "";
            txtdienthoai.Text = "";

            cbomabao.Text = "";
            cbomaquangcao.Text = "";
            txttenbao.Text = "";
            txttenquangcao.Text = "";
            txtnoidung.Text = "";
            txtngaybatdau.Text = "";
            txtngayketthuc.Text = "";
            txtdongia.Text = "0";
            txttongtien.Text = "0";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            btnluu.Enabled = true;
            btnin.Enabled = false;
            btnthem.Enabled = false;
            txtmahopdong.Enabled = false;
            txtngayky.Enabled = false;
            txttennhanvien.Enabled = false;
            txttenkhachhang.Enabled = false;
            txtdienthoai.Enabled = true;
            txtdiachi.Enabled = false;
            txtdidong.Enabled = false;
            txtemail.Enabled = false;
            txttenbao.Enabled = true;
            txttenquangcao.Enabled = true;
            txtngaybatdau.Enabled = true;
            txtngayketthuc.Enabled = true;

            resetvalues();
            txtmahopdong.Text = Class.Function.CreateHDKey();
            load_datagridview();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn đóng menu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void btntimso_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select MaKH, TenKH, DiaChi, Didong, Email from tblKhachhang where DienThoai = '" + txtdienthoai.Text + "'";
            tblkh = Class.Function.GetDataToTable(sql);
            if (tblkh.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomakhachhang.Text = Function.CreateCustomerKey();
                txttenkhachhang.Enabled = true;
                txtdiachi.Enabled = true;
                txtdidong.Enabled = true;
                txtemail.Enabled = true;
                txtnoidung.Enabled = true;
                txttenbao.Enabled = true;
                txttenquangcao.Enabled = true;
                txtdongia.Enabled = true;
                txtngaybatdau.Enabled = true;
                txtngayketthuc.Enabled = true;
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
            str = "select MaKH from tblKhachhang where DienThoai = '" + txtdienthoai.Text + "'";
            cbomakhachhang.Text = Class.Function.GetFieldValues(str);
            str = "select TenKH from tblKhachhang where DienThoai = '" + txtdienthoai.Text + "'";
            txttenkhachhang.Text = Class.Function.GetFieldValues(str);
            str = "select DiaChi from tblKhachhang where DienThoai = '" + txtdienthoai.Text + "'";
            txtdiachi.Text = Class.Function.GetFieldValues(str);
            str = "select Didong from tblKhachhang where DienThoai = '" + txtdienthoai.Text + "'";
            txtdidong.Text = Class.Function.GetFieldValues(str);
            str = "select Email from tblKhachhang where DienThoai = '" + txtdienthoai.Text + "'";
            txtemail.Text = Class.Function.GetFieldValues(str);

            //str = "insert into tblKhachhang(MaKH, TenKH, DiaChi, DienThoai, Didong, Email, MaLVHD) values (N'" + txtMakhach.Text.Trim() + "', N '" + txtTenkhach.Text.Trim() + "', N'" + txtDiachi.Text.Trim() + "', '" + mskDienthoai.Text + "', '"+ mskDidong.Text +"', '"+ txtEmail.Text.Trim() +"', '"+ cbLVHD.SelectedValue.ToString() + "'";
            //Function.RunSql(str);
        }


        private void txtmahopdong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            //sql = "Select Malangui from tblKhachguibai where Malangui =N'" + txtMahopdong.Text + "'";
            if (cbomanhanvien.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomanhanvien.Focus();
                return;
            }
            //if (!Class.Function.CheckKey(sql))
            //{                
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
            if (txtdidong.Text == "(   )    -")
            {
                MessageBox.Show("Bạn phải nhập di động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdidong.Focus();
                return;
            }
            if (txtdienthoai.Text == "(   )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdienthoai.Focus();
                return;
            }
            if (txtemail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtemail.Focus();
                return;
            }

            sql = "INSERT INTO tblKhachhang(MaKH,TenKH,Diachi, Dienthoai, Didong, Email, MaLVHD) VALUES (N'" + cbomakhachhang.Text.Trim() + "',N'" + txttenkhachhang.Text.Trim() + "',N'" + txtdiachi.Text.Trim() + "','" + txtdienthoai.Text + "','" + txtdidong.Text + "','" + txtemail.Text.Trim() + "')";
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

            if (txtngaybatdau.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtngaybatdau.Focus();
                return;
            }
            if (txtngayketthuc.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtngayketthuc.Focus();
                return;
            }
            if (txtdongia.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdongia.Focus();
                return;
            }
            sql = "Insert into tblKhachguibai (Malangui, MaKH, Matheloai, Mabao, Tieude, Noidung, MaNV, Ngaydang, Nhuanbut) VALUES (N'" + txtmahopdong.Text.Trim() + "',N'" + cbomakhachhang.Text.Trim() + "',N'" + cbomabao.SelectedValue.ToString() + "','" + cbomaquangcao.SelectedValue.ToString() + "','" + txttenbao.Text.Trim() + "','" + txttenquangcao.Text.Trim() + "','" + txtngaybatdau.Text.Trim() + "','" + txtngayketthuc.Text.Trim() + "','" + cbomanhanvien.SelectedValue.ToString() + "','" + cbomakhachhang.SelectedValue.ToString() + "','" + txtdongia.Text.Trim() + "')";
            Class.Function.RunSql(sql);
            load_datagridview();
            resetvaluesHD();
            btnhuy.Enabled = false;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnin.Enabled = false;
            btnluu.Enabled = false;
        }
        private void resetvaluesHD()
        {
            cbomabao.Text = "";
            cbomaquangcao.Text = "";
            txtngaybatdau.Text = "  /  /";
            txtngayketthuc.Text = "  /  /";
            txttenbao.Text = "";
            txttenquangcao.Text = "";

            txtnoidung.Text = "";
            txtdongia.Text = "";
        }

        private void btnin_Click(object sender, EventArgs e)
        {

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHDQC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmahopdong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có chắn chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblKhachguibai WHERE Malangui=N'" + txtmahopdong.Text + "'";
                Class.Function.RunSqlDel(sql);
                load_datagridview();
                resetvalues();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            txtmahopdong.Enabled = false;
            cbomanhanvien.Enabled = false;
            cbomakhachhang.Enabled = false;
            if (tblHDQC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmahopdong.Text == "")
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
            if (txtdidong.Text == "(   )    -")
            {
                MessageBox.Show("Bạn phải nhập di động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdidong.Focus();
                return;
            }
            if (txtdienthoai.Text == "(   )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdienthoai.Focus();
                return;
            }
            if (txtemail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtemail.Focus();
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
            if (txtngaybatdau.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtngaybatdau.Focus();
                return;
            }
            if (txtngayketthuc.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtngayketthuc.Focus();
                return;
            }
            if (txtdongia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdongia.Focus();
                return;
            }
            sql = "UPDATE tblKhach_Quangcao SET MaKH='" + cbomakhachhang.Text.Trim().ToString() + "',Mabao=N'" + cbomabao.SelectedValue.ToString() + "',MaQcao='" + cbomaquangcao.SelectedValue.ToString() + "',Noidung='" + txtnoidung.Text.Trim().ToString() + "', MaNV='" + cbomanhanvien.SelectedValue.ToString() + "',NgayBD='" + txtngaybatdau.Text + "',NgayKT='" + txtngayketthuc.Text + "' WHERE MalanQC=N'" + txtmahopdong.Text + "'";
            Class.Function.RunSql(sql);
            Load_ThongtinHD();
            load_datagridview();
            resetvalues();
            btnin.Enabled = false;
        }
    }
}


