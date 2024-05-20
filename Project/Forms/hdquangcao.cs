/*using Project.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;
//using Quanlybanhang.Class;



namespace Project.Forms
{
    public partial class frmhopdongqc : Form
    {
        public frmhopdongqc()
        {
            InitializeComponent();
        }
        DataTable tblCTHDQC;
        private void hdquangcao_Load(object sender, EventArgs e)
        {
            Function.Connect();
            cbomahopdong.DropDownStyle = ComboBoxStyle.DropDownList;
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            btnin.Enabled = false;
            txtmahopdong.ReadOnly = true;
            txttennhanvien.ReadOnly = true;
            txttenkhachhang.ReadOnly = true;
            txtdiachi.ReadOnly = true;
            txtdienthoai.ReadOnly = true;
            txtdidong.ReadOnly = true;
            txtemail.ReadOnly = true;
            txttenbao.ReadOnly = true;
            txtdongia.ReadOnly = true;
            txttongtien.ReadOnly = true;
            txttongtien.Text = "0";

            Function.FillCombo("SELECT Mabao, Tenbao, FROM tblBao", cbomabao, "Mabao", "Tenbao");
            cbomabao.SelectedIndex = -1;
            Function.FillCombo("SELECT Malanquangcao FROM tblquangcao", cbomahopdong, "Mahopdong", "Mahopdong");
            cbomahopdong.SelectedIndex = -1;

            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtmahopdong.Text != "")
            {

                btnhuy.Enabled = true;
                btnin.Enabled = true;
            }
            load_datagridview();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnhuy.Enabled = false;
            btnluu.Enabled = true;
            btnin.Enabled = false;
            btnthem.Enabled = false;
            ResetValues();
            txtmahopdong.Text = Function.CreateKey("HDB");
            load_datagridview();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (cbomahopdong.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomahopdong.Focus();
                return;
            }
            txtmahopdong.Text = cbomahopdong.Text;
            Load_ThongtinHD();
            load_datagridview();
            btnhuy.Enabled = true;
            btnluu.Enabled = true;
            btnin.Enabled = true;
            cbomahopdong.SelectedIndex = -1;

        }

        private void cboMaHDBan_DropDown(object sender, EventArgs e)
        {
            Function.FillCombo("SELECT Malanquangcao FROM tblHopdong", cbomahopdong, "Mahopdong", "Mahopdong");
            cbomahopdong.SelectedIndex = -1;
        }

    }
    private void load_datagridview()
    {
        string sql;
        sql = "SELECT Mabao, Tenbao, Mahopdong, Tenquangcao, Dongia,Ngaybatdau, Ngayketthuc, Tongtien FROM Bao AS a, Quangcao AS b WHERE Điều kiện ;
        tblCTHDQC = Function.GetDataToTable(sql);
        DatagridView.DataSource = tblCTHDQC;

        DatagridView.Columns[0].HeaderText = "Mã báo";
        DatagridView.Columns[1].HeaderText = "Tên báo";
        DatagridView.Columns[2].HeaderText = "Mã hợp đồng";
        DatagridView.Columns[3].HeaderText = "Tên quảng cáo";
        DatagridView.Columns[4].HeaderText = "Ngày bắt đầu";
        DatagridView.Columns[5].HeaderText = "Ngày kết thúc";
        DatagridView.Columns[6].HeaderText = "Đơn giá";
        DatagridView.Columns[7].HeaderText = "Tổng tiền";
        DatagridView.Columns[0].Width = 80;
        DatagridView.Columns[1].Width = 100;
        DatagridView.Columns[2].Width = 80;
        DatagridView.Columns[3].Width = 90;
        DatagridView.Columns[4].Width = 90;
        DatagridView.Columns[5].Width = 90;
        DatagridViewDatagridView.AllowUserToAddRows = false;
        DatagridView.EditMode = DataGridViewEditMode.EditProgrammatically;
    }
    private void ResetValues()
    {

    }


    private void frmHoadonban_FormClosing(object sender, FormClosingEventArgs e)
    {
        //Xóa dữ liệu trong các điều khiển trước khi đóng Form
        ResetValues();
    }


    private void btndong_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
}*/

