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
    public partial class Phongban : Form
    {
        public Phongban()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Đặt form vào chế độ fullscreen
        }

        private void Phongban_Load(object sender, EventArgs e)
        {
            Class.Function.Connect();
            txtmaphong.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
            Function.FillCombo("SELECT Mabao, Tenbao FROM tblBao", cbomabao, "Mabao", "Tenbao");
            cbomabao.SelectedIndex = -1;
        }
        DataTable tblpb;
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Maphong, Tenphong,Mabao,Dienthoai FROM tblPhongban";
            tblpb = Class.Function.GetDataToTable(sql);
            DataGridView.DataSource = tblpb;
            DataGridView.Columns[0].HeaderText = "Mã phòng";
            DataGridView.Columns[1].HeaderText = "Tên phòng";
            DataGridView.Columns[2].HeaderText = "Mã báo";
            DataGridView.Columns[3].HeaderText = "Điện thoại";
            
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 300;
            DataGridView.Columns[2].Width = 100;
            DataGridView.Columns[3].Width = 50;
           
            DataGridView.AllowUserToAddRows = false;

            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtmaphong.Text = "";
            txttenphong.Text = "";
            cbomabao.Text = "";
            mskdienthoai.Text = "";
            
        }
        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Dang o them moi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmaphong.Focus();
                return;
            }
            if (tblpb.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmaphong.Text = DataGridView.CurrentRow.Cells["Maphong"].Value.ToString();
            txttenphong.Text = DataGridView.CurrentRow.Cells["Tenphong"].Value.ToString();
            cbomabao.Text = DataGridView.CurrentRow.Cells["Mabao"].Value.ToString();
            mskdienthoai.Text = DataGridView.CurrentRow.Cells["Dienthoai"].Value.ToString();
            
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();

            txtmaphong.Enabled = true;
            txtmaphong.Focus();
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (tblpb.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmaphong.Text == "")
            {
                MessageBox.Show("Ban chua co ban ghi nao", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Ban muon xoa khong", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblPhongban WHERE Maphong=N'" + txtmaphong.Text + "'";
                Class.Function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (tblpb.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu ton tai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmaphong.Text == "")
            {
                MessageBox.Show("Ban chua chon ban ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttenphong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban can nhap ten phong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenphong.Focus();
                return;
            }
            sql = "UPDATE tblPhongban SET Tenphong=N'" + txttenphong.Text.ToString() + "', Mabao='" + cbomabao.Text.ToString() + "', Dienthoai='" + mskdienthoai.Text.ToString() + "' WHERE Maphong=N'" + txtmaphong.Text + "'";
            Class.Function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnboqua.Enabled = false;
        }

        private void btnluu_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (txtmaphong.Text == "")
            {
                MessageBox.Show("Ban phai nhap ma phong ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmaphong.Focus();
                return;
            }

            if (txttenphong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban phai nhap ten phong ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenphong.Focus();
                return;
            }
            if (cbomabao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban phai nhap ten phong ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomabao.Focus();
                return;
            }
            if (mskdienthoai.Text == "(   )    -")
            {
                MessageBox.Show("Phai nhap sđt", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskdienthoai.Focus();
                return;
            }
            sql = "SELECT Maphong FROM tblPhongban WHERE Maphong=N'" + txtmaphong.Text.Trim() + "'";
            if (Class.Function.CheckKey(sql))
            {
                MessageBox.Show("Ma phong ban nay da co hay nhap ma khac", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmaphong.Focus();
                txtmaphong.Text = "";
                return;
            }
            sql = "INSERT INTO tblPhongban(Maphong,Tenphong,Mabao,Dienthoai) VALUES(N'" + txtmaphong.Text + "',N'" + txttenphong.Text + "',N'" + cbomabao.Text + "','" + mskdienthoai.Text + "')";
            Class.Function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmaphong.Enabled = false;
        }

        private void btnboqua_Click_1(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmaphong.Enabled = false;
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
