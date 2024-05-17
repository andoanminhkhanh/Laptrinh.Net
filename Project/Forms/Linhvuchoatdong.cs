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
    public partial class Linhvuchoatdong : Form
    {
        public Linhvuchoatdong()
        {
            InitializeComponent();
        }

        private void Linhvuchoatdong_Load(object sender, EventArgs e)
        {
            txtMalvhd.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_data();
        }
        DataTable tbllvhd;
        private void Load_data()
        {
            string sql;
            sql = "select Malvhd, Tenlvhd from tbllinhvuchoatdong";
            tbllvhd = Class.Function.GetDataToTable(sql);
            dgridLvhd.DataSource = tbllvhd;
            dgridLvhd.Columns[0].HeaderText = "Mã lĩnh vực hoạt động";
            dgridLvhd.Columns[1].HeaderText = "Tên lĩnh vực hoạt động";
            dgridLvhd.AllowUserToAddRows = false;
            dgridLvhd.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgridLvhd_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMalvhd.Focus();
                return;
            }
            if (tbllvhd.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMalvhd.Text = dgridLvhd.CurrentRow.Cells["Malvhd"].Value.ToString();
            txtTenlvhd.Text = dgridLvhd.CurrentRow.Cells["Tenlvhd"].Value.ToString();
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
            txtMalvhd.Enabled = true;
            txtMalvhd.Focus();
        }
        private void ResetValues()
        {
            txtMalvhd.Text = "";
            txtTenlvhd.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMalvhd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã lĩnh vực hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMalvhd.Focus();
                return;
            }
            if (txtTenlvhd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên lĩnh vực hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenlvhd.Focus();
                return;
            }
            sql = "select Malvhd from tbllinhvuchoatdong where Malvhd=N '" + txtMalvhd.Text.Trim() + "'";
            if (Class.Function.CheckKey(sql))
            {
                MessageBox.Show("Mã lĩnh vực hoạt động này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMalvhd.Focus();
                txtMalvhd.Text = "";
                return;
            }
            sql = "insert into tbllinhvuchoatdong(Malvhd, Tenlvhd) values (N'" + txtMalvhd.Text.Trim() + "', N'" + txtTenlvhd.Text.Trim() + "')";
            Class.Function.RunSql(sql);
            Load_data();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMalvhd.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbllvhd.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMalvhd.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTenlvhd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên lĩnh vực hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenlvhd.Focus();
                return;
            }
            sql = "update tbllinhvuchoatdong set Tenlvhd = N'" + txtTenlvhd.Text.Trim().ToString() + "' where Malvhd=N'" + txtMalvhd.Text + "'";
            Class.Function.RunSql(sql);
            Load_data();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbllvhd.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMalvhd.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete tbllinhvuchoatdong where Makh = N'" + txtMalvhd.Text + "'";
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
            txtMalvhd.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
