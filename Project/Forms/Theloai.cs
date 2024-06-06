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
    public partial class mnuTheloai : Form
    {
        public mnuTheloai()
        {
            InitializeComponent();
        }

        private void mnuTheloai_Load(object sender, EventArgs e)
        {
            txtMatheloai.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }
       
        DataTable tblTL;
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Matheloai, Tentheloai FROM tblTheloai";
            tblTL = Class.Function.GetDataToTable(sql);
            dgridTL.DataSource = tblTL;
            dgridTL.Columns[0].HeaderText = "Mã thể loại";
            dgridTL.Columns[1].HeaderText = "Tên thể loại";
            dgridTL.Columns[0].Width = 250;
            dgridTL.Columns[1].Width = 250;
            dgridTL.AllowUserToAddRows = false;
            dgridTL.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void dgridTL_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tblTL.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtMatheloai.Text = dgridTL.CurrentRow.Cells["Matheloai"].Value.ToString();
            txtTentheloai.Text = dgridTL.CurrentRow.Cells["Tentheloai"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            txtMatheloai.Enabled = true;
            txtMatheloai.Focus();
            ResetValues();
        }
        private void ResetValues()
        {
            txtMatheloai.Text = "";
            txtTentheloai.Text = "";
        }
        private void btnBoqua_Click_1(object sender, EventArgs e)
        {
            ResetValues();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMatheloai.Enabled = false;
        }
        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (txtMatheloai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatheloai.Focus();
                return;
            }
            if (txtTentheloai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTentheloai.Focus();
                return;
            }
            sql = "SELECT Matheloai FROM tblTheloai WHERE Matheloai=N'" + txtMatheloai.Text.Trim() + "'";
            if (Class.Function.CheckKey(sql))
            {
                MessageBox.Show("Mã thể loại này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatheloai.Focus();
                txtMatheloai.Text = "";
                return;
            }
            sql = "INSERT INTO tblTheloai(Matheloai,Tentheloai) VALUES(N'" + txtMatheloai.Text.Trim() + "',N'" + txtTentheloai.Text.Trim() + "')";
            Class.Function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMatheloai.Enabled = false;
        }
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (tblTL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMatheloai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTentheloai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTentheloai.Focus();
                return;
            }
            sql = "UPDATE tblTheloai SET Tentheloai=N'" + txtTentheloai.Text.Trim() + "' WHERE Matheloai=N'" + txtMatheloai.Text + "'";
            Class.Function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (tblTL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMatheloai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                sql = "DELETE tblTheloai WHERE Matheloai=N'" + txtMatheloai.Text + "'";
                Class.Function.RunSql(sql);
                Load_DataGridView();
                ResetValues();
            }
        }
        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

    

