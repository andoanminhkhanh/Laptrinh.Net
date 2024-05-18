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
    public partial class Chucnang : Form
    {
        public Chucnang()
        {
            InitializeComponent();
        }

        private void Chucnang_Load(object sender, EventArgs e)
        {
            txtMachucnang.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }
        DataTable tblCN;
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Machucnang, Tenchucnang FROM tblChucnang";
            tblCN = Class.Function.GetDataToTable(sql);
            DataGridView.DataSource = tblCN;

            //do dl tu bang vao datagridview

            DataGridView.Columns[0].HeaderText = "Mã chức năng";
            DataGridView.Columns[1].HeaderText = "Tên chức năng";
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            DataGridView.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tblCN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtMachucnang.Text = DataGridView.CurrentRow.Cells["Machucnang"].Value.ToString();
            txtTenchucnang.Text = DataGridView.CurrentRow.Cells["Tenchucnang"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            txtMachucnang.Enabled = true;
            txtMachucnang.Focus();
            ResetValues();
        }
        private void ResetValues()
        {
            txtMachucnang.Text = "";
            txtTenchucnang.Text = "";
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMachucnang.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMachucnang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMachucnang.Focus();
                return;
            }
            if (txtTenchucnang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenchucnang.Focus();
                return;
            }

            //ktra trung ma 
            sql = "SELECT Machucnang FROM tblChucnang WHERE Machucnang=N'" + txtMachucnang.Text.Trim() + "'";
            if (Class.Function.CheckKey(sql))
            {
                MessageBox.Show("Mã chức năng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMachucnang.Focus();
                txtMachucnang.Text = "";
                return;
            }
            sql = "INSERT INTO tblChucnang(Machucnang,Tenchucnang) VALUES(N'" + txtMachucnang.Text.Trim() + "',N'" + txtTenchucnang.Text.Trim() + "')";
            Class.Function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMachucnang.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMachucnang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTenchucnang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenchucnang.Focus();
                return;
            }
            sql = "UPDATE tblChucnang SET Tenchucnang=N'" + txtTenchucnang.Text.Trim() + "' WHERE Machucnang=N'" + txtMachucnang.Text + "'";
            Class.Function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMachucnang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                sql = "DELETE tblChucnang WHERE Machucnang=N'" + txtMachucnang.Text + "'";
                Class.Function.RunSql(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
