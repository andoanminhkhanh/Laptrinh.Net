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
    public partial class Banggia : Form
    {
        public Banggia()
        {
            InitializeComponent();
        }

        private void Banggia_Load(object sender, EventArgs e)
        {
            Class.Function.Connect();
            cbomabao.Enabled = false;
            cbomaqc.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
            Function.FillCombo("SELECT Mabao, Tenbao FROM tblBao", cbomabao, "Mabao", "Mabao");
            cbomabao.SelectedIndex = -1;
            Function.FillCombo("SELECT MaQcao, TenQcao FROM tblTTQuangcao", cbomaqc, "MaQcao", "MaQcao");
            cbomaqc.SelectedIndex = -1;
        }
        DataTable tblbg;
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Mabao,MaQcao,Dongia FROM tblBanggia";
            tblbg = Class.Function.GetDataToTable(sql);
            DataGridView.DataSource = tblbg;
            DataGridView.Columns[0].HeaderText = "Mã báo";
            DataGridView.Columns[1].HeaderText = "Mã Quảng cáo";
            DataGridView.Columns[2].HeaderText = "Đơn giá";

            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 100;
            DataGridView.Columns[2].Width = 100;


            DataGridView.AllowUserToAddRows = false;

            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Dang o them moi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbomabao.Focus();
                return;
            }
            if (tblbg.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cbomabao.Text = DataGridView.CurrentRow.Cells["Mabao"].Value.ToString();
            cbomaqc.Text = DataGridView.CurrentRow.Cells["MaQcao"].Value.ToString();
            txtdongia.Text = DataGridView.CurrentRow.Cells["Dongia"].Value.ToString();

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
            cbomaqc.Enabled = true;
            ResetValues();

            cbomabao.Enabled = true;
            cbomabao.Focus();
        }
        private void ResetValues()
        {
            cbomabao.Text = "";
            cbomaqc.Text = "";
            txtdongia.Text = "";

        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            cbomabao.Enabled = false;
            cbomaqc.Enabled = false;

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (cbomabao.Text == "")
            {
                MessageBox.Show("Ban phai nhap ma hang", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomabao.Focus();
                return;
            }

            if (cbomaqc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban phai nhap ten hang", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomaqc.Focus();
                return;
            }
            /*sql = "SELECT Mabao FROM tblBao WHERE Mabao=N'" + cbomabao.Text.Trim() + "'";
            /*if (Class.Function.CheckKey(sql))
            {
                MessageBox.Show("Ma hang nay da co hay nhap ma khac", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomabao.Focus();
                cbomaqc.Text = "";
                return;
            }*/
            sql = "INSERT INTO tblBanggia(Mabao,MaQcao,Dongia) VALUES(N'" + cbomabao.Text + "',N'" + cbomaqc.Text + "','" + txtdongia.Text + "')";
            Class.Function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            cbomabao.Enabled = false;
            cbomaqc.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblbg.Rows.Count == 0)
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
                sql = "DELETE tblBanggia WHERE Mabao=N'" + cbomabao.Text + "'";
                Class.Function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            
            string sql;
            if (tblbg.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu ton tai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbomabao.Text == "")
            {
                MessageBox.Show("Ban chua chon ban ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbomaqc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban can nhap ma qc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomaqc.Focus();
                return;
            }
            sql = "UPDATE tblBanggia SET MaQcao=N'" + cbomaqc.Text.ToString() + "', Dongia='" + txtdongia.Text.ToString() + "' WHERE Mabao=N'" + cbomabao.Text + "'";
            Class.Function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnboqua.Enabled = false;
            cbomabao.Enabled = true;
            cbomaqc.Enabled = true;
        }
    }
}
