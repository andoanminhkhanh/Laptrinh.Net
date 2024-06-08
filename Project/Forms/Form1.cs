using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Đặt form vào chế độ fullscreen
        }
        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            Class.Function.Connect();
        }

        private void mnuKhachhang_Click(object sender, EventArgs e)
        {
            Forms.Khachhang a = new Forms.Khachhang();
            a.Show();
        }

        private void mnuLvhd_Click(object sender, EventArgs e)
        {
            Forms.Linhvuchoatdong a = new Forms.Linhvuchoatdong();
            a.Show();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Chucvu a = new Forms.Chucvu();
            a.Show();
        }

        private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Chucnang a = new Forms.Chucnang();
            a.Show();
        }

        private void chuyênMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Chuyenmon a = new Forms.Chuyenmon();
            a.Show();
        }

        private void trinhdoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Trinhdo a = new Forms.Trinhdo();
            a.Show();
        }

        private void mnu_Nhanvien_Click(object sender, EventArgs e)
        {
            Forms.Quanlynhanvien a = new Forms.Quanlynhanvien();
            a.Show();
        }

        private void mnu_TTQC_Click(object sender, EventArgs e)
        {
            Forms.TTQuangcao a = new Forms.TTQuangcao();
            a.Show();
        }

        private void mnu_banggia_Click(object sender, EventArgs e)
        {
            Forms.Banggia a = new Forms.Banggia();
            a.Show();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Phongban a = new Forms.Phongban();
            a.Show();
        }

        /*private void báoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Báo a = new Forms.Báo();
            a.Show();
        }*/

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.mnuTheloai a = new Forms.mnuTheloai();
            a.Show();
        }

        private void báoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Forms.Báo a = new Forms.Báo();
            a.Show();
        }

        private void mnubaiviet_Click(object sender, EventArgs e)
        {
            Forms.BaocaoKhanh a = new Forms.BaocaoKhanh();
            a.Show();
        }
    }
}
