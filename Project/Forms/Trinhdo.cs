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
    public partial class Trinhdo : Form
    {
        public Trinhdo()
        {
            InitializeComponent();
        }

        private void Trinhdo_Load(object sender, EventArgs e)
        {
            txtMatrinhdo.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }
        DataTable tblTD;
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT MaTD, TenTD FROM tblTrinhdo";
            tblTD = Class.Function.GetDataToTable(sql);
            DataGridView.DataSource = tblTD;

            //do dl tu bang vao datagridview

            DataGridView.Columns[0].HeaderText = "Mã trình độ";
            DataGridView.Columns[1].HeaderText = "Tên trình độ";
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
            if (tblTD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtMatrinhdo.Text = DataGridView.CurrentRow.Cells["MaTD"].Value.ToString();
            txtTentrinhdo.Text = DataGridView.CurrentRow.Cells["TenTD"].Value.ToString();
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
            txtMatrinhdo.Enabled = true;
            txtMatrinhdo.Focus();
            ResetValues();
        }
        private void ResetValues()
        {
            txtMatrinhdo.Text = "";
            txtTentrinhdo.Text = "";
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMatrinhdo.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMatrinhdo.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã trình độ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatrinhdo.Focus();
                return;
            }
            if (txtTentrinhdo.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên trình độ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTentrinhdo.Focus();
                return;
            }

            //ktra trung ma 
            sql = "SELECT MaTD FROM tblTrinhdo WHERE MaTD=N'" + txtMatrinhdo.Text.Trim() + "'";
            if (Class.Function.CheckKey(sql))
            {
                MessageBox.Show("Mã trình độ này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatrinhdo.Focus();
                txtMatrinhdo.Text = "";
                return;
            }
            sql = "INSERT INTO tblTrinhdo(MaTD,TenTD) VALUES(N'" + txtMatrinhdo.Text.Trim() + "',N'" + txtTentrinhdo.Text.Trim() + "')";
            Class.Function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMatrinhdo.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblTD.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMatrinhdo.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTentrinhdo.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên trình độ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTentrinhdo.Focus();
                return;
            }
            sql = "UPDATE tblTrinhdo SET TenTD=N'" + txtTentrinhdo.Text.Trim() + "' WHERE MaTD=N'" + txtMatrinhdo.Text + "'";
            Class.Function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblTD.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMatrinhdo.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                sql = "DELETE tblTrinhdo WHERE MaTD=N'" + txtMatrinhdo.Text + "'";
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
