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
    public partial class BaocaoKhanh : Form
    {
        public BaocaoKhanh()
        {
            InitializeComponent();
        }

        private void BaocaoKhanh_Load(object sender, EventArgs e)
        {
            btnHienthi.Enabled = true;
            btnInbaocao.Enabled = false;
        }
    }
}
