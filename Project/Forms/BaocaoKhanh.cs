using Project.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;


namespace Project.Forms
{
    public partial class BaocaoKhanh : Form
    {
        public BaocaoKhanh()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Đặt form vào chế độ fullscreen
            rdtTheongay.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rdtTheokhoang.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rdtTheongay.Checked)
            {
                mskTheongay.Enabled = true;
                mskTheokhoang.Enabled = false;
                mskDenkhoang.Enabled = false;
            }
            else if (rdtTheokhoang.Checked)
            {
                mskTheongay.Enabled = false;
                mskTheokhoang.Enabled = true;
                mskDenkhoang.Enabled = false;
            }
        }

        private void BaocaoKhanh_Load(object sender, EventArgs e)
        {
            btnHienthi.Enabled = true;
            btnInbaocao.Enabled = false;
            Class.Function.FillCombo("Select MaQCao, TenQCao from tblTTQuangcao", cboLoaiquangcao, "MaQcao", "MaQCao");
            cboLoaiquangcao.SelectedIndex = -1;
            Class.Function.FillCombo("Select Matheloai, Tentheloai from tblTheloai", cboManhanvien, "Matheloai", "Matheloai");
            cboManhanvien.SelectedIndex = -1;
            Class.Function.FillCombo("Select Mabao, Tenbao from tblBao", cboLoaibao, "Mabao", "Mabao");
            cboLoaibao.SelectedIndex = -1;
            mskTheongay.Enabled = false;
            mskTheokhoang.Enabled = false;
            mskDenkhoang.Enabled = false;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            // Kiểm tra các điều kiện nhập
            if (txtMahopdong.Text == "" && txtMakhachhang.Text == "" && cboLoaibao.SelectedValue == null && cboLoaiquangcao.SelectedValue == null && cboManhanvien.SelectedValue == null  && mskTheongay.Text == "  /  /" && mskTheokhoang.Text == "  /  /" && mskDenkhoang.Text == "  /  /")
            {
                MessageBox.Show("Hãy nhập ít nhất 1 dữ liệu để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xây dựng câu truy vấn SQL
            sql = "SELECT * FROM tblKhach_Quangcao WHERE 1=1";

            if (txtMahopdong.Text != "")
            {
                sql += " AND MalanQC = N'" + txtMahopdong.Text + "'";
            }

            if (cboLoaibao.SelectedValue != null)
            {
                sql += " AND Mabao = N'" + cboLoaibao.SelectedValue.ToString() + "'";
            }

            if (cboLoaiquangcao.SelectedValue != null)
            {
                sql += " AND MaQcao = N'" + cboLoaiquangcao.SelectedValue.ToString() + "'";
            }
            if (txtMakhachhang.Text != "")
            {
                sql += " AND MaKH = N'" + txtMakhachhang.Text + "'";
            }
            if (cboManhanvien.SelectedValue != null)
            {
                sql += " AND MaNV = N'" + cboManhanvien.SelectedValue.ToString() + "'";
            }

            if (mskTheongay.Text != "  /  /")
            {
                if (!Function.isdate(mskTheongay.Text))
                {
                    MessageBox.Show("Hãy nhập lại ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskTheongay.Focus();
                    mskTheongay.Text = "";
                    return;
                }
                sql += " AND Ngayky = '" + Function.convertdatetime(mskTheongay.Text) + "'";
            }

            if (mskTheokhoang.Text != "  /  /" && mskDenkhoang.Text == "  /  /")
            {
                MessageBox.Show("Hãy nhập đến ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskDenkhoang.Focus();
                return;
            }

            if (mskDenkhoang.Text != "  /  /" && mskTheokhoang.Text == "  /  /")
            {
                MessageBox.Show("Hãy nhập từ ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskTheokhoang.Focus();
                return;
            }

            if (mskTheokhoang.Text != "  /  /" && mskDenkhoang.Text != "  /  /")
            {
                if (!Function.isdate(mskDenkhoang.Text))
                {
                    MessageBox.Show("Hãy nhập lại đến ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskDenkhoang.Focus();
                    mskDenkhoang.Text = "";
                    return;
                }
                if (!Function.isdate(mskTheokhoang.Text))
                {
                    MessageBox.Show("Hãy nhập lại từ ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskTheokhoang.Focus();
                    mskDenkhoang.Text = "";
                    return;
                }
                if (DateTime.ParseExact(mskTheokhoang.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture) > DateTime.ParseExact(mskDenkhoang.Text, "mm/dd/yyyy", CultureInfo.InvariantCulture))
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskDenkhoang.Text = "";
                    mskTheokhoang.Text = "";
                    return;
                }
                sql += " AND (Ngayky BETWEEN '" + Function.convertdatetime(mskTheokhoang.Text) + "' AND '" + Function.convertdatetime(mskDenkhoang.Text) + "')";
            }

            load_datagrid(sql);
        }
        DataTable tbldt;
        private void load_datagrid(string sql)
        {
            tbldt = Class.Function.GetDataToTable(sql);
            dgridDoanhthu.DataSource = tbldt;
            dgridDoanhthu.Columns[0].HeaderText = "Mã hợp đồng";
            dgridDoanhthu.Columns[1].HeaderText = "Mã KH";
            dgridDoanhthu.Columns[2].HeaderText = "Mã báo";
            dgridDoanhthu.Columns[3].HeaderText = "Mã NV";
            dgridDoanhthu.Columns[4].HeaderText = "Mã Quảng cáo";
            dgridDoanhthu.Columns[5].HeaderText = "Nội dung";
            dgridDoanhthu.Columns[6].HeaderText = "Ngày bắt đầu";
            dgridDoanhthu.Columns[7].HeaderText = "Ngày kết thúc";
            dgridDoanhthu.Columns[8].HeaderText = "Thành tiền";
            dgridDoanhthu.Columns[9].HeaderText = "Ngày ký";
            dgridDoanhthu.Columns[0].Width = 100;
            dgridDoanhthu.Columns[1].Width = 90;
            dgridDoanhthu.Columns[2].Width = 120;
            dgridDoanhthu.Columns[3].Width = 120;
            dgridDoanhthu.Columns[4].Width = 80;
            dgridDoanhthu.Columns[5].Width = 80;
            dgridDoanhthu.Columns[6].Width = 80;
            dgridDoanhthu.Columns[7].Width = 80;
            dgridDoanhthu.Columns[8].Width = 80;
            dgridDoanhthu.Columns[9].Width = 80;
            dgridDoanhthu.AllowUserToAddRows = false;
            dgridDoanhthu.EditMode = DataGridViewEditMode.EditProgrammatically;
            //try
            //{
            //    // Kiểm tra kết nối đã mở chưa, nếu chưa thì mở kết nối
            //    if (Class.Function.Conn == null || Class.Function.Conn.State != ConnectionState.Open)
            //    {
            //        Class.Function.ketnoi();
            //    }

            //    // Lấy dữ liệu từ bảng vào DataTable
            //    DataTable dt = Class.Function.GetDataToTable(sql);

            //    // Gán DataTable vào DataGridView (giả sử tên DataGridView của bạn là dgvSanPham)
            //    dgriddoanhthu.DataSource = dt;
            //}
            //catch (Exception ex)
            //{
            //    // Xử lý ngoại lệ nếu có lỗi xảy ra
            //    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            // Khai báo biến tổng nhuận bút và khởi tạo giá trị ban đầu bằng 0
            decimal tongtien = 0;

            // Duyệt qua từng dòng trong DataGridView
            foreach (DataGridViewRow row in dgridDoanhthu.Rows)
            {
                // Lấy giá trị của cột Nhuanbut từ mỗi dòng và cộng vào biến tổng
                tongtien += Convert.ToDecimal(row.Cells["Thanhtien"].Value);
            }

            // Đổ giá trị tổng nhuận bút vào TextBox
            txtTongtien.Text = tongtien.ToString();
            lblBangchu.Text = "Bằng chữ: " + Function.ChuyenSoSangChu(txtTongtien.Text);
            btnInbaocao.Enabled = true;
        }

        private void btnInbaocao_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            int hang = 0, cot = 0;

            try
            {
                // Tạo Workbook và Worksheet
                exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
                exSheet = exBook.Worksheets[1];
                exRange = exSheet.Cells[1, 1];

                // Định dạng header của báo cáo
                exRange.Range["A1:B3"].Font.Size = 10;
                exRange.Range["A1:B3"].Font.Name = "Times new roman";
                exRange.Range["A1:B3"].Font.Bold = true;
                exRange.Range["A1:B3"].Font.ColorIndex = 5; // Màu xanh da trời
                exRange.Range["A1:A1"].ColumnWidth = 7;
                exRange.Range["B1:B1"].ColumnWidth = 15;
                exRange.Range["A1:B1"].MergeCells = true;
                exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A1:B1"].Value = "Công ty ABC";
                exRange.Range["A2:B2"].MergeCells = true;
                exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A2:B2"].Value = "Chùa Bộc - Đống Đa - Hà Nội";
                exRange.Range["A3:B3"].MergeCells = true;
                exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A3:B3"].Value = "Điện thoại: (09)87654321";
                exRange.Range["C2:G2"].Font.Size = 16;
                exRange.Range["C2:G2"].Font.Name = "Times new roman";
                exRange.Range["C2:G2"].Font.Bold = true;
                exRange.Range["C2:G2"].Font.ColorIndex = 3; // Màu đỏ
                exRange.Range["C2:G2"].MergeCells = true;
                exRange.Range["C2:G2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["C2:G2"].Value = "DOANH THU HỢP ĐỒNG QUẢNG CÁO";

                // Tạo dòng tiêu đề bảng
                exRange.Range["A11:K11"].Font.Bold = true;
                exRange.Range["A11:K11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A11:K11"].ColumnWidth = 12;

                exRange.Range["A11:A11"].Value = "STT";
                exRange.Range["B11:B11"].Value = "Mã HĐQC";
                exRange.Range["C11:C11"].Value = "Mã khách hàng";
                exRange.Range["D11:D11"].Value = "Mã báo";
                exRange.Range["E11:E11"].Value = "Mã nhân viên";
                exRange.Range["F11:F11"].Value = "Mã quảng cáo";
                exRange.Range["G11:G11"].Value = "Nội dung";
                exRange.Range["H11:H11"].Value = "Ngày bắt đầu";
                exRange.Range["I11:I11"].Value = "Ngày kết thúc";
                exRange.Range["J11:J11"].Value = "Thành tiền";
                exRange.Range["K11:K11"].Value = "Ngày ký";

                // Lấy dữ liệu từ DataGridView và điền vào bảng
                for (hang = 0; hang < dgridDoanhthu.Rows.Count; hang++)
                {
                    exSheet.Cells[hang + 12, 1] = hang + 1; // Điền số thứ tự vào cột 1 từ dòng 12
                    for (cot = 0; cot < dgridDoanhthu.Columns.Count; cot++)
                    {
                        exSheet.Cells[hang + 12, cot + 2] = dgridDoanhthu.Rows[hang].Cells[cot].Value?.ToString();
                    }
                }

                // Tính tổng nhuận bút
                decimal tongtien = 0;
                foreach (DataGridViewRow row in dgridDoanhthu.Rows)
                {
                    tongtien += Convert.ToDecimal(row.Cells["Thanhtien"].Value);
                }

                // Hiển thị tổng nhuận bút
                exRange = exSheet.Cells[hang + 14, 10]; // Ô để hiển thị tổng nhuận bút (cột J)
                exRange.Font.Bold = true;
                exRange.Value2 = "Tổng Doanh Thu: " + tongtien.ToString("C");

                // Định dạng chữ ký nhân viên
                exRange = exSheet.Cells[hang + 17, 1]; // Ô A1 
                exRange.Range["A1:C1"].MergeCells = true;
                exRange.Range["A1:C1"].Font.Italic = true;
                exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A1:C1"].Value = "Hà Nội, " + DateTime.Now.ToString(" 'ngày' d 'tháng' M 'năm' yyyy");
                exRange.Range["A2:C2"].MergeCells = true;
                exRange.Range["A2:C2"].Font.Italic = true;
                exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A2:C2"].Value = "Nhân viên";

                // Đặt tên cho sheet và hiển thị Excel
                exSheet.Name = "Doanh thu hợp đồng quảng cáo";
                exApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();

            btnBoqua.Enabled = true;
            lblBangchu.Text = "Bằng chữ:";
        }
        private void ResetValues()
        {
            txtMahopdong.Text = "";
            cboLoaibao.Text = "";
            cboLoaiquangcao.Text = "";
            txtMakhachhang.Text = "";
            cboManhanvien.Text = "";
            mskTheongay.Text = "";
            mskTheokhoang.Text = "";
            mskDenkhoang.Text = "";
            rdtTheongay = null;
            rdtTheokhoang = null;
            txtTongtien.Text = "";

        }
    }
}
