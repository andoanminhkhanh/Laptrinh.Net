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
    public partial class Báo : Form
    {
        public Báo()
        {
            InitializeComponent();
        }

        private void Báo_Load(object sender, EventArgs e)
        {
            txtMabao.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_data();
            Class.Function.FillCombo("select Machucnang, Tenchucnang from tbllinhvuchoatdong", cboMachucnang, "Machucnang", "Tenchucnang");
            cboMachucnang.SelectedIndex = -1;
            ResetValues();
        }
        DataTable tblbao;
        private void ResetValues()
        {
            txtMabao.Text = "";
            txtTenbao.Text = "";
            txtDiachi.Text = "";
            mskDienthoai.Text = "";
            txtEmail.Text = "";
            cboMachucnang.Text = "";
        }
        private void Load_data()
        {
            string sql;
            sql = "select Mabao, Tenbao, Machucnang, Diachi, Dienthoai, Email from tblbao";
            tblbao = Class.Function.GetDataToTable(sql);
            dgridBao.DataSource = tblbao;
            dgridBao.Columns[0].HeaderText = "Mã báo";
            dgridBao.Columns[1].HeaderText = "Tên báo";
            dgridBao.Columns[2].HeaderText = "Mã chức năng";
            dgridBao.Columns[3].HeaderText = "Địa chỉ";
            dgridBao.Columns[4].HeaderText = "Điện thoại";
            dgridBao.Columns[5].HeaderText = "Email";
            dgridBao.AllowUserToAddRows = false;
            dgridBao.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgridBao_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMabao.Focus();
                return;
            }
            if (tblbao.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMabao.Text = dgridBao.CurrentRow.Cells["Mabao"].Value.ToString();
            txtTenbao.Text = dgridBao.CurrentRow.Cells["Tenbao"].Value.ToString();
            txtDiachi.Text = dgridBao.CurrentRow.Cells["Diachi"].Value.ToString();
            mskDienthoai.Text = dgridBao.CurrentRow.Cells["Dienthoai"].Value.ToString();
            txtEmail.Text = dgridBao.CurrentRow.Cells["Email"].Value.ToString();
            ma = dgridBao.CurrentRow.Cells["Malvhd"].Value.ToString();
            cboMachucnang.Text = Class.Function.GetFieldValues("select Tenchucnang from tblchucnang where machucnang = N'" + ma + "'");
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
            txtMabao.Enabled = true;
            txtMabao.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMabao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã báo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMabao.Focus();
                return;
            }
            if (txtTenbao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên báo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenbao.Focus();
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
            
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (cboMachucnang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMachucnang.Focus();
                return;
            }
            sql = "select Mabao from tblbao where Mabao=N '" + txtMabao.Text.Trim() + "'";
            if (Class.Function.CheckKey(sql))
            {
                MessageBox.Show("Mã báo này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMabao.Focus();
                txtMabao.Text = "";
                return;
            }
            sql = "insert into tblbao(Mabao, Tenbao, Machucnang, Diachi, Dienthoai, Email) values (N'" + txtMabao.Text.Trim() + "', N'" + txtTenbao.Text.Trim() + "', N'" + cboMachucnang.SelectedValue.ToString() + "',N'" + txtDiachi.Text.Trim() + "', '" + mskDienthoai.Text + "', N'" + txtEmail.Text.Trim() + "')";
            Class.Function.RunSql(sql);
            Load_data();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMabao.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblbao.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMabao.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTenbao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên báo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenbao.Focus();
                return;
            }
            if (cboMachucnang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chức năngg", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMachucnang.Focus();
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
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            sql = "update tblbao set Tenbao = N'" + txtTenbao.Text.Trim().ToString() + "', Machucnang = N'" + cboMachucnang.SelectedValue.ToString() + "', Diachi = N'" + txtDiachi.Text.Trim().ToString() + "', Dienthoai = '" + mskDienthoai.Text.ToString() + "', Email = N'" + txtEmail.Text.Trim().ToString() + "' where Mabao=N'" + txtMabao.Text + "'";
            Class.Function.RunSql(sql);
            Load_data();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblbao.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMabao.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete tblbao where Makh = N'" + txtMabao.Text + "'";
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
            txtMabao.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
