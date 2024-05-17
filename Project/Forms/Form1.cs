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
    }
}
