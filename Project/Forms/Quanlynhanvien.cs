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

namespace Project.Forms
{
    public partial class Quanlynhanvien : Form
    {
        public Quanlynhanvien()
        {
            InitializeComponent();
        }

        private void Quanlynhanvien_Load(object sender, EventArgs e)
        {
            
                Class.Function.Connect();
                txtmanv.Enabled = false;
                cbochucvu.Enabled = false;
                cbochuyenmon.Enabled = false;
                cbomabao.Enabled = false;
                cbophongban.Enabled = false;
                cbotrinhdo.Enabled = false;
                btnluu.Enabled = false;
                btnboqua.Enabled = false;
                Load_DataGridView();

                Function.FillCombo("SELECT Maphong, Tenphong FROM tblPhongban", cbophongban, "Maphong", "Maphong");
                cbophongban.SelectedIndex = -1;  
                Function.FillCombo("SELECT MaTD, TenTD FROM tblTrinhdo", cbotrinhdo, "MaTD", "MaTD");
                cbotrinhdo.SelectedIndex = -1;  
                Function.FillCombo("SELECT Machucvu, Tenchucvu FROM tblChucvu", cbochucvu, "Machucvu", "Machucvu");
                cbochucvu.SelectedIndex = -1;  
                Function.FillCombo("SELECT MaCM, TenCM FROM tblChuyenmon", cbochuyenmon, "MaCM", "MaCM");
                cbochuyenmon.SelectedIndex = -1;  
                Function.FillCombo("SELECT Mabao, Tenbao FROM tblBao", cbomabao, "Mabao", "Mabao");
                cbomabao.SelectedIndex = -1;  

                // Đặt các giá trị TextBox ban đầu là trống
                txtmanv.Text = "";
                txttennv.Text = "";
                txtdiachi.Text = "";
                mskdienthoai.Text = "";
                mskmobile.Text = "";
                txtemail.Text = "";
                mskngaysinh.Text = "";
            
        }
        DataTable tblnv;
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT MaNV,TenNV,Mabao,Maphong,Machucvu,Matrinhdo,MaCM,Diachi,Ngaysinh,Gioitinh,Dienthoai,Mobile,Email FROM tblNhanvien";
            tblnv = Class.Function.GetDataToTable(sql);
            DataGridView.DataSource = tblnv;
            DataGridView.Columns[0].HeaderText = "Mã NV";
            DataGridView.Columns[1].HeaderText = "Tên NV";
            DataGridView.Columns[2].HeaderText = "Mã báo";
            DataGridView.Columns[3].HeaderText = "Mã phòng";
            DataGridView.Columns[4].HeaderText = "Mã chức vụ";
            DataGridView.Columns[5].HeaderText = "Mã trình độ";
            DataGridView.Columns[6].HeaderText = "Mã CM";
            DataGridView.Columns[7].HeaderText = "Địa chỉ";
            DataGridView.Columns[8].HeaderText = "Ngày sinh";
            DataGridView.Columns[9].HeaderText = "Giới tính";
            DataGridView.Columns[10].HeaderText = "Điện thoại";
            DataGridView.Columns[11].HeaderText = "Mobile";
            DataGridView.Columns[12].HeaderText = "Email";

            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 300;
            DataGridView.Columns[2].Width = 100;
            DataGridView.Columns[3].Width = 100;
            DataGridView.Columns[4].Width = 100;
            DataGridView.Columns[5].Width = 100;
            DataGridView.Columns[6].Width = 100;
            DataGridView.Columns[7].Width = 300;
            DataGridView.Columns[8].Width = 100;
            DataGridView.Columns[9].Width = 20;
            DataGridView.Columns[10].Width = 100;
            DataGridView.Columns[11].Width = 100;
            DataGridView.Columns[12].Width = 100;
           

            DataGridView.AllowUserToAddRows = false;

            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Dang o them moi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanv.Focus();
                return;
            }
            if (tblnv.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmanv.Text = DataGridView.CurrentRow.Cells["MaNV"].Value.ToString();
            txttennv.Text = DataGridView.CurrentRow.Cells["TenNV"].Value.ToString();
            if (DataGridView.CurrentRow.Cells["Gioitinh"].Value.ToString() == "Nam")
            {
                chknam.Checked = true;
                chknu.Checked = false; // Bỏ tích ô "Nữ"
            }
            else
            {
                chknam.Checked = false; // Bỏ tích ô "Nam"
                chknu.Checked = true;
            }
            mskngaysinh.Text = DataGridView.CurrentRow.Cells["Ngaysinh"].Value.ToString();
            cbomabao.Text = DataGridView.CurrentRow.Cells["Mabao"].Value.ToString();
            cbophongban.Text = DataGridView.CurrentRow.Cells["Maphong"].Value.ToString();
            cbochucvu.Text = DataGridView.CurrentRow.Cells["Machucvu"].Value.ToString();
            cbotrinhdo.Text = DataGridView.CurrentRow.Cells["Matrinhdo"].Value.ToString();
            cbochuyenmon.Text = DataGridView.CurrentRow.Cells["MaCM"].Value.ToString();
            txtdiachi.Text = DataGridView.CurrentRow.Cells["Diachi"].Value.ToString();
            mskdienthoai.Text = DataGridView.CurrentRow.Cells["Dienthoai"].Value.ToString();
            mskmobile.Text = DataGridView.CurrentRow.Cells["Mobile"].Value.ToString();
            txtemail.Text = DataGridView.CurrentRow.Cells["Email"].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();

            txtmanv.Enabled = true;
            txtmanv.Focus();
            txtmanv.Enabled = true;
            cbophongban.Enabled = true;
            cbochucvu.Enabled = true;
            cbotrinhdo.Enabled = true;
            cbochuyenmon.Enabled = true;
            cbomabao.Enabled = true;

            string newEmployeeID = Function.CreateKey();

            // Hiển thị mã nhân viên mới lên TextBox hoặc sử dụng cho mục đích khác
            txtmanv.Text = newEmployeeID;
        }
        private void ResetValues()
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            cbomabao.Text = "";
            cbophongban.Text = "";
            cbochucvu.Text = "";
            cbotrinhdo.Text = "";
            cbochuyenmon.Text = "";
            txtdiachi.Text = "";
            mskdienthoai.Text = "";
            mskmobile.Text = "";
            txtemail.Text = "";
            mskngaysinh.Text = "";
            chknam.Checked = false;
            chknu.Checked = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmanv.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            cbochucvu.Enabled = true;
            cbochuyenmon.Enabled = true;
            cbomabao.Enabled = true;
            cbophongban.Enabled = true;
            cbotrinhdo.Enabled = true;
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Ban phai nhap ma nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanv.Focus();
                return;
            }

            if (txttennv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban phai nhap ten nhan vien", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennv.Focus();
                return;
            }

            if (cbophongban.Text == "")
            {
                MessageBox.Show("Ban phai chon ma phong ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbophongban.Focus();
                return;
            }

            if (cbochucvu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban phai chọn chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbochucvu.Focus();
                return;
            }
            if (mskdienthoai.Text == "(   )    -")
            {
                MessageBox.Show("Phai nhap sđt", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskdienthoai.Focus();
                return;
            }
         
            if (mskngaysinh.Text == "  /  /")
            {
                MessageBox.Show("Phai nhap ngay sinh", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskngaysinh.Focus();
                return;
            }
            if (!Class.Function.isdate(mskngaysinh.Text))
            {
                MessageBox.Show("Phai nhap lai ngay sinh", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskngaysinh.Focus();
                mskngaysinh.Text = "";
                return;

            }

            sql = "SELECT MaNV FROM tblNhanvien WHERE MaNV=N'" + txtmanv.Text.Trim() + "'";
            if (Class.Function.CheckKey(sql))
            {
                MessageBox.Show("Ma nhan vien nay da co hay nhap ma khac", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanv.Focus();
                txtmanv.Text = "";
                return;
            }
            sql = "INSERT INTO tblNhanvien(MaNV, TenNV, Gioitinh, Ngaysinh, Mabao, Maphong, Machucvu, Matrinhdo, MaCM, Diachi, Dienthoai, Mobile, Email) VALUES(N'" + txtmanv.Text + "', N'" + txttennv.Text + "', N'" + (chknam.Checked ? "Nam" : "Nữ") + "', '" + Class.Function.convertdatetime(mskngaysinh.Text) + "', N'" + cbomabao.Text + "', N'" + cbophongban.Text + "', N'" + cbochucvu.Text + "', N'" + cbotrinhdo.Text + "', N'" + cbochuyenmon.Text + "', N'" + txtdiachi.Text + "', '" + mskdienthoai.Text + "', N'" + mskmobile.Text + "', N'" + txtemail.Text + "')";

            Class.Function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmanv.Enabled = false;
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblnv.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbomabao.Text == "")
            {
                MessageBox.Show("Ban chua co ban ghi nao", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Ban muon xoa khong", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblNhanvien WHERE MaNV=N'" + txtmanv.Text + "'";
                Class.Function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblnv.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu ton tai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Ban chua chon ban ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttennv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban can nhap ma qc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennv.Focus();
                return;
            }
            sql = "UPDATE tblNhanvien SET TenNV=N'" + txtmanv.Text.ToString() + "',Gioitinh=N'" + chknam.Text.ToString() + "',Ngaysinh='" + Class.Function.convertdatetime(mskngaysinh.Text) + "'N,Maphong='" + cbophongban.Text.ToString() + "'," +
                "Matrinhdo='" + cbotrinhdo.Text.ToString() + "',Machucvu='" + cbochucvu.Text.ToString() + "',MaCM='" + cbochuyenmon.Text.ToString() + "',Diachi='" + txtdiachi.Text.ToString() + "', Dienthoai='" + mskdienthoai.Text.ToString() + "',Mobile='" + mskdienthoai.Text.ToString() + "',Email='" + mskmobile.Text.ToString() + "',Mabao='" + cbomabao.Text.ToString() + "' WHERE MaNV=N'" + cbomabao.Text + "'";
            Class.Function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnboqua.Enabled = false;
            cbomabao.Enabled = true;
            cbophongban.Enabled = true;
        }

        private void chknam_Click(object sender, EventArgs e)
        {
            chknu.Enabled = false;
            if (chknam.Checked == false)
            { chknu.Enabled = true; }
   
        }

        private void chknu_Click(object sender, EventArgs e)
        {
            chknam.Enabled = false;
            
            if (chknu.Checked == false)
            { chknam.Enabled = true; }
        }
    }
}
