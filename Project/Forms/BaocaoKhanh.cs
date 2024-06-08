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
            Class.Function.FillCombo("Select MaQCao, TenQCao from tblTTQuangcao", cboLoaiquangcao, "MaQcao", "TenQCao");
            cboLoaiquangcao.SelectedIndex = -1;
            Class.Function.FillCombo("Select Matheloai, Tentheloai from tblTheloai", cboTheloai, "Matheloai", "Tentheloai");
            cboTheloai.SelectedIndex = -1;
            Class.Function.FillCombo("Select Mabao, Tenbao from tblBao", cboLoaibao, "Mabao", "Tenbao");
            cboLoaibao.SelectedIndex = -1;
            mskTheongay.Enabled = false;
            mskTheokhoang.Enabled = false;
            mskDenkhoang.Enabled = false;
        }
    }
}
