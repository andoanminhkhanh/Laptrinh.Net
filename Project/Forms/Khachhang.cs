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
    public partial class Khachhang : Form
    {
        public Khachhang()
        {
            InitializeComponent();
        }
        private void Khachhang_Load(object sender, EventArgs e)
        {
            txtMakhachhang.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_data();
            Class.Function.FillCombo("select Malvhd, Tenlvhd from tbllinhvuchoatdong", cboMalvhd, "Malvhd", "Tenlvhd");
            cboMalvhd.SelectedIndex = -1;
            ResetValues();
        }
        DataTable tblkh;
        private void ResetValues()
        {
            txtMakhachhang.Text = "";
            txtTenkhachhang.Text = "";
            txtDiachi.Text = "";
            mskDienthoai.Text = "";
            mskDidong.Text = "";
            txtEmail.Text = "";
            cboMalvhd.Text = "";
        }
        private void Load_data() 
        {
            string sql;
            sql = "select Makh, Tenkh, Diachi, Dienthoai, Didong, Email, Malvhd from tblkhachhang";
            tblkh = Class.Function.GetDataToTable(sql);
            dgridKhachhang.DataSource = tblkh;
            dgridKhachhang.Columns[0].HeaderText = "Mã khách hàng";
            dgridKhachhang.Columns[1].HeaderText = "Tên khách hàng";
            dgridKhachhang.Columns[2].HeaderText = "Địa chỉ";
            dgridKhachhang.Columns[3].HeaderText = "Điện thoại";
            dgridKhachhang.Columns[4].HeaderText = "Di động";
            dgridKhachhang.Columns[5].HeaderText = "Email";
            dgridKhachhang.Columns[6].HeaderText = "Mã lĩnh vực hoạt động";
            dgridKhachhang.Columns[0].Width = 80;
            dgridKhachhang.Columns[1].Width = 150;
            dgridKhachhang.Columns[0].Width = 100;
            dgridKhachhang.Columns[1].Width = 100;
            dgridKhachhang.Columns[0].Width = 100;
            dgridKhachhang.Columns[1].Width = 100;
            dgridKhachhang.Columns[0].Width = 100;
            dgridKhachhang.AllowUserToAddRows = false;
            dgridKhachhang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgridKhachhang_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMakhachhang.Focus();
                return;
            }
            if (tblkh.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMakhachhang.Text = dgridKhachhang.CurrentRow.Cells["Makh"].Value.ToString();
            txtTenkhachhang.Text = dgridKhachhang.CurrentRow.Cells["Tenkh"].Value.ToString();
            txtDiachi.Text = dgridKhachhang.CurrentRow.Cells["Diachi"].Value.ToString();
            mskDienthoai.Text = dgridKhachhang.CurrentRow.Cells["Dienthoai"].Value.ToString();
            mskDidong.Text = dgridKhachhang.CurrentRow.Cells["Didong"].Value.ToString();
            txtEmail.Text = dgridKhachhang.CurrentRow.Cells["Email"].Value.ToString();
            ma = dgridKhachhang.CurrentRow.Cells["Malvhd"].Value.ToString();
            cboMalvhd.Text = Class.Function.GetFieldValues("select Tenlvhd from tbllinhvuchoatdong where malvhd = N'" + ma + "'");
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMakhachhang.Enabled = true;
            txtMakhachhang.Focus();
            string newCustomerID = Function.CreateCustomerKey();

            // Hiển thị mã nhân viên mới lên TextBox hoặc sử dụng cho mục đích khác
            txtMakhachhang.Text = newCustomerID;
        }
       

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMakhachhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMakhachhang.Focus();
                return;
            }
            if (txtTenkhachhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenkhachhang.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )    -")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            if (mskDidong.Text == "(   )    -")
            {
                MessageBox.Show("Bạn phải nhập số di động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDidong.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (cboMalvhd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lĩnh vực hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMalvhd.Focus();
                return;
            }
            /*sql = "select Makh from tblkhachhang where Makh=N '" + txtMakhachhang.Text.Trim() + "'";
            if (Class.Function.CheckKey(sql))
            {
                MessageBox.Show("Mã khách hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMakhachhang.Focus();
                txtMakhachhang.Text = "";
                return;
            }*/
            sql = "insert into tblkhachhang(Makh, Tenkh, Diachi, Dienthoai, Didong, Email, Malvhd) values (N'" + txtMakhachhang.Text.Trim() + "', N'" + txtTenkhachhang.Text.Trim() + "', N'" + txtDiachi.Text.Trim() + "', '" + mskDienthoai.Text + "', '" + mskDidong.Text + "', N'" + txtEmail.Text.Trim() + "', N'" + cboMalvhd.SelectedValue.ToString() + "')";
            Class.Function.RunSql(sql);
            Load_data();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMakhachhang.Enabled = false;
        }

        private void btnHopdongvietbai_Click(object sender, EventArgs e)
        {
            Forms.Hopdongbaiviet a = new Forms.Hopdongbaiviet();
            a.Show();
        }

        private void btnHopdongquangcao_Click(object sender, EventArgs e)
        {
            Forms.Hopdongquangcao a = new Forms.Hopdongquangcao();
            a.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblkh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMakhachhang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTenkhachhang.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenkhachhang.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            if (mskDidong.Text == "(   )    -")
            {
                MessageBox.Show("Bạn phải nhập di động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDidong.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (cboMalvhd.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Bạn phải nhập mã lĩnh vực hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMalvhd.Focus();
                return;
            }
            sql = "update tblkhachhang set Tenkh = N'" + txtTenkhachhang.Text.Trim().ToString() + "', Diachi = N'" + txtDiachi.Text.Trim().ToString() + "', Dienthoai = '" + mskDienthoai.Text.ToString() + "', Didong = N'" + mskDidong.Text.ToString() + "', Email = N'" + txtEmail.Text.Trim().ToString() + "', Malvhd = N'" + cboMalvhd.SelectedValue.ToString() + "' where Makh=N'" + txtMakhachhang.Text + "'";
            Class.Function.RunSql(sql);
            Load_data();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblkh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMakhachhang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete tblkhachhang where Makh = N'" + txtMakhachhang.Text + "'";
                Class.Function.RunSql(sql);
                Load_data();
                ResetValues();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMakhachhang.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
