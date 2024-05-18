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
    public partial class Chucvu : Form
    {
        public Chucvu()
        {
            InitializeComponent();
        }

        private void Chucvu_Load(object sender, EventArgs e)
        {
            txtMachucvu.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }
        DataTable tblCV;
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Machucvu, Tenchucvu FROM tblChucvu";
            tblCV = Class.Function.GetDataToTable(sql);
            DataGridView.DataSource = tblCV;

            //do dl tu bang vao datagridview

            DataGridView.Columns[0].HeaderText = "Mã chức vụ";
            DataGridView.Columns[1].HeaderText = "Tên chức vụ";
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
            if (tblCV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtMachucvu.Text = DataGridView.CurrentRow.Cells["Machucvu"].Value.ToString();
            txtTenchucvu.Text = DataGridView.CurrentRow.Cells["Tenchucvu"].Value.ToString();
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
            txtMachucvu.Enabled = true;
            txtMachucvu.Focus();
            ResetValues();
        }
        private void ResetValues()
        {
            txtMachucvu.Text = "";
            txtTenchucvu.Text = "";
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMachucvu.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMachucvu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMachucvu.Focus();
                return;
            }
            if (txtTenchucvu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenchucvu.Focus();
                return;
            }

            //ktra trung ma 
            sql = "SELECT Machucvu FROM tblChucvu WHERE Machucvu=N'" + txtMachucvu.Text.Trim() + "'";
            if (Class.Function.CheckKey(sql))
            {
                MessageBox.Show("Mã chức vụ này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMachucvu.Focus();
                txtMachucvu.Text = "";
                return;
            }
            sql = "INSERT INTO tblChucvu(Machucvu,Tenchucvu) VALUES(N'" + txtMachucvu.Text.Trim() + "',N'" + txtTenchucvu.Text.Trim() + "')";
            Class.Function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMachucvu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMachucvu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTenchucvu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenchucvu.Focus();
                return;
            }
            sql = "UPDATE tblChucvu SET Tenchucvu=N'" + txtTenchucvu.Text.Trim() + "' WHERE Machucvu=N'" + txtMachucvu.Text + "'";
            Class.Function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMachucvu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                sql = "DELETE tblChucvu WHERE Machucvu=N'" + txtMachucvu.Text + "'";
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
