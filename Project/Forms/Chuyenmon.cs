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
    public partial class Chuyenmon : Form
    {
        public Chuyenmon()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Đặt form vào chế độ fullscreen
        }

        private void Chuyenmon_Load(object sender, EventArgs e)
        {
            txtMachuyenmon.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }
        DataTable tblCM;
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT MaCM, TenCM FROM tblChuyenmon";
            tblCM = Class.Function.GetDataToTable(sql);
            DataGridView.DataSource = tblCM;

            //do dl tu bang vao datagridview

            DataGridView.Columns[0].HeaderText = "Mã chuyên môn";
            DataGridView.Columns[1].HeaderText = "Tên chuyên môn";
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
            if (tblCM.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtMachuyenmon.Text = DataGridView.CurrentRow.Cells["MaCM"].Value.ToString();
            txtTenchuyenmon.Text = DataGridView.CurrentRow.Cells["TenCM"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }
        private void ResetValues()
        {
            txtMachuyenmon.Text = "";
            txtTenchuyenmon.Text = "";
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            txtMachuyenmon.Enabled = true;
            txtMachuyenmon.Focus();
            ResetValues();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (tblCM.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMachuyenmon.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                sql = "DELETE tblChuyenmon WHERE MaCM=N'" + txtMachuyenmon.Text + "'";
                Class.Function.RunSql(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (txtMachuyenmon.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã chuyên môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMachuyenmon.Focus();
                return;
            }
            if (txtTenchuyenmon.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên chuyên môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenchuyenmon.Focus();
                return;
            }

            //ktra trung ma 
            sql = "SELECT MaCM FROM tblChuyenmon WHERE MaCM=N'" + txtMachuyenmon.Text.Trim() + "'";
            if (Class.Function.CheckKey(sql))
            {
                MessageBox.Show("Mã chuyên môn này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMachuyenmon.Focus();
                txtMachuyenmon.Text = "";
                return;
            }
            sql = "INSERT INTO tblChuyenmon(MaCM,TenCM) VALUES(N'" + txtMachuyenmon.Text.Trim() + "',N'" + txtTenchuyenmon.Text.Trim() + "')";
            Class.Function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMachuyenmon.Enabled = false;
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBoqua_Click_1(object sender, EventArgs e)
        {
            ResetValues();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMachuyenmon.Enabled = false;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (tblCM.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMachuyenmon.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTenchuyenmon.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenchuyenmon.Focus();
                return;
            }
            sql = "UPDATE tblChuyenmon SET TenCM=N'" + txtTenchuyenmon.Text.Trim() + "' WHERE MaCM=N'" + txtMachuyenmon.Text + "'";
            Class.Function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }
    }
}
