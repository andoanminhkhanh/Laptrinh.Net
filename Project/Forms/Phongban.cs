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
        }

        private void Phongban_Load(object sender, EventArgs e)
        {
            Class.Function.Connect();
            txtmaphong.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
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
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 50;
           
            DataGridView.AllowUserToAddRows = false;

            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
