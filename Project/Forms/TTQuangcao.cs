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
    public partial class TTQuangcao : Form
    {
        public TTQuangcao()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Đặt form vào chế độ fullscreen
        }

        private void TTQuangcao_Load(object sender, EventArgs e)
        {
            Class.Function.Connect();
            txtmaqc.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
        }
        DataTable tblttqc;
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT MaQcao,TenQcao FROM tblTTQuangcao";
            tblttqc = Class.Function.GetDataToTable(sql);
            DataGridView.DataSource = tblttqc;
            DataGridView.Columns[0].HeaderText = "Mã QC";
            DataGridView.Columns[1].HeaderText = "Tên QC";
            

            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 300;

            DataGridView.AllowUserToAddRows = false;

            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Dang o them moi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmaqc.Focus();
                return;
            }
            if (tblttqc.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmaqc.Text = DataGridView.CurrentRow.Cells["MaQcao"].Value.ToString();
            txttenqc.Text = DataGridView.CurrentRow.Cells["TenQcao"].Value.ToString();
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

            txtmaqc.Enabled = true;
            txtmaqc.Focus();
        }
        private void ResetValues()
        {
            txtmaqc.Text = "";
            txttenqc.Text = "";     
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmaqc.Enabled = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmaqc.Text == "")
            {
                MessageBox.Show("Ban phai nhap ma hang", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmaqc.Focus();
                return;
            }

            if (txttenqc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban phai nhap ten hang", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenqc.Focus();
                return;
            }
            sql = "SELECT MaQcao FROM tblTTQuangcao WHERE MaQcao=N'" + txtmaqc.Text.Trim() + "'";
            if (Class.Function.CheckKey(sql))
            {
                MessageBox.Show("Ma hang nay da co hay nhap ma khac", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmaqc.Focus();
                txtmaqc.Text = "";
                return;
            }
            sql = "INSERT INTO tblTTQuangcao(MaQcao,TenQcao) VALUES(N'" + txtmaqc.Text + "',N'" + txttenqc.Text + "')";
            Class.Function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmaqc.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblttqc.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmaqc.Text == "")
            {
                MessageBox.Show("Ban chua co ban ghi nao", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Ban muon xoa khong", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblTTQuangcao WHERE MaQcao=N'" + txtmaqc.Text + "'";
                Class.Function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblttqc.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu ton tai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmaqc.Text == "")
            {
                MessageBox.Show("Ban chua chon ban ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttenqc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban can nhap ten phong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenqc.Focus();
                return;
            }
            sql = "UPDATE tblTTQuangcao SET TenQcao=N'" + txttenqc.Text.ToString() + "' WHERE MaQcao=N'" + txtmaqc.Text + "'";
            Class.Function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnboqua.Enabled = false;
        }
    }
}
