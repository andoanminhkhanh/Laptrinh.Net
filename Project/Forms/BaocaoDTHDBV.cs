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
    public partial class BaocaoDTHDBV : Form
    {
        public BaocaoDTHDBV()
        {
            InitializeComponent();
        }

        private void BaocaoDTHDBV_Load(object sender, EventArgs e)
        {
            Class.Function.FillCombo("Select Mabao, Tenbao from tblBao", cboloaibao, "Mabao", "Mabao");
            cboloaibao.SelectedIndex = -1;

            Class.Function.FillCombo("Select Matheloai, Tentheloai from tblTheloai", cbotheloai, "Matheloai", "Matheloai");
            cbotheloai.SelectedIndex = -1;


            // Fill ComboBox for NhanVien
            Class.Function.FillCombo("Select MaNV, TenNV from tblNhanvien", cbonhanvien, "MaNV", "MaNV");
            cbonhanvien.SelectedIndex = -1;

            txtdoanhthu.Enabled = false;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            // Kiểm tra các điều kiện nhập
            if (txtmalangui.Text == "" && cboloaibao.SelectedValue == null && cbotheloai.SelectedValue == null && txtkhachhang.Text == "" && cbonhanvien.SelectedValue == null && msktheongay.Text == "  /  /" && msktu.Text == "  /  /" && mskden.Text == "  /  /")
            {
                MessageBox.Show("Hãy nhập ít nhất 1 dữ liệu để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xây dựng câu truy vấn SQL
            sql = "SELECT * FROM tblKhachguibai WHERE 1=1";

            if (txtmalangui.Text != "")
            {
                sql += " AND Malangui = N'" + txtmalangui.Text + "'";
            }

            if (cboloaibao.SelectedValue != null)
            {
                sql += " AND Mabao = N'" + cboloaibao.Text + "'";
            }

            if (cbotheloai.SelectedValue != null)
            {
                sql += " AND Matheloai = N'" + cbotheloai.SelectedValue + "'";

            }
            if (txtkhachhang.Text != "")
            {
                sql += " AND MaKH = N'" + txtkhachhang.Text + "'";
            }

            if (cbonhanvien.SelectedValue != null)
            {
                sql += " AND MaNV = '" + cbonhanvien.SelectedValue.ToString() + "'";
            }

            if (msktheongay.Text != "  /  /")
            {
                if (!Function.isdate(msktheongay.Text))
                {
                    MessageBox.Show("Hãy nhập lại ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msktheongay.Focus();
                    msktheongay.Text = "";
                    return;
                }
                sql += " AND Ngaydang = '" + Function.convertdatetime(msktheongay.Text) + "'";
            }

            if (msktu.Text != "  /  /" && mskden.Text == "  /  /")
            {
                MessageBox.Show("Hãy nhập đến ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskden.Focus();
                return;
            }

            if (mskden.Text != "  /  /" && msktu.Text == "  /  /")
            {
                MessageBox.Show("Hãy nhập từ ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msktu.Focus();
                return;
            }

            if (msktu.Text != "  /  /" && mskden.Text != "  /  /")
            {
                if (!Function.isdate(mskden.Text))
                {
                    MessageBox.Show("Hãy nhập lại đến ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskden.Focus();
                    mskden.Text = "";
                    return;
                }
                if (!Function.isdate(msktu.Text))
                {
                    MessageBox.Show("Hãy nhập lại từ ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msktu.Focus();
                    msktu.Text = "";
                    return;
                }
                if (DateTime.ParseExact(msktu.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture) > DateTime.ParseExact(mskden.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture))
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskden.Text = "";
                    msktu.Text = "";
                    return;
                }
                sql += " AND (Ngaydang BETWEEN '" + Function.convertdatetime(msktu.Text) + "' AND '" + Function.convertdatetime(mskden.Text) + "')";
            }

            load_datagrid(sql);
            lbbangchu.Text = "Bằng chữ:";
            txtdoanhthu.Text = "";
        }
        private void load_datagrid(string sql)
        {
            try
            {
                // Kiểm tra kết nối đã mở chưa, nếu chưa thì mở kết nối
                if (Class.Function.Conn == null || Class.Function.Conn.State != ConnectionState.Open)
                {
                    Class.Function.Connect();
                }

                // Lấy dữ liệu từ bảng vào DataTable
                DataTable dt = Class.Function.GetDataToTable(sql);

                // Gán DataTable vào DataGridView (giả sử tên DataGridView của bạn là dgvSanPham)
                dgriddoanhthu.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi xảy ra
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            // Khai báo biến tổng nhuận bút và khởi tạo giá trị ban đầu bằng 0
            decimal tongNhuanBut = 0;

            // Duyệt qua từng dòng trong DataGridView
            foreach (DataGridViewRow row in dgriddoanhthu.Rows)
            {
                tongNhuanBut += Convert.ToDecimal(row.Cells["Nhuanbut"].Value);
            }

            txtdoanhthu.Text = tongNhuanBut.ToString();
            lbbangchu.Text = "Bằng chữ: " + Function.ChuyenSoSangChu(txtdoanhthu.Text);
        }

        private void rdtheongay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdtheongay.Checked)
            {

                rdtheokhoang.Checked = false;

            }
            if (rdtheongay.Checked)
            {
                msktu.Enabled = false;
                mskden.Enabled = false;
                msktu.Text = mskden.Text = null;
            }
            else
            {
                msktu.Enabled = true;
                mskden.Enabled = true;
            }
        }

        private void rdtheokhoang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdtheokhoang.Checked)
            {

                rdtheongay.Checked = false;

            }
            if (rdtheokhoang.Checked)
            {
                msktheongay.Enabled = false;
                msktheongay.Text = null;
            }
            else
            {
                msktheongay.Enabled = true;
            }
        }
        private void ResetValues()
        {
            txtmalangui.Text = "";
            cboloaibao.Text = "";
            cbotheloai.Text = "";
            txtkhachhang.Text = "";
            cbonhanvien.Text = "";
            msktheongay.Text = "";
            msktu.Text = "";
            mskden.Text = "";
            rdtheongay = null;
            rdtheokhoang = null;
            txtdoanhthu.Text = "";
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();

            btnboqua.Enabled = true;
            lbbangchu.Text = "Bằng chữ:";
        }

        private void btninbaocao_Click(object sender, EventArgs e)
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
                exRange.Range["C2:E2"].Font.Size = 16;
                exRange.Range["C2:E2"].Font.Name = "Times new roman";
                exRange.Range["C2:E2"].Font.Bold = true;
                exRange.Range["C2:E2"].Font.ColorIndex = 3; // Màu đỏ
                exRange.Range["C2:E2"].MergeCells = true;
                exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["C2:E2"].Value = "HỢP ĐỒNG BÀI VIẾT";

                // Tạo dòng tiêu đề bảng
                exRange.Range["A11:K11"].Font.Bold = true;
                exRange.Range["A11:K11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A11:K11"].ColumnWidth = 12;

                exRange.Range["A11:A11"].Value = "STT";
                exRange.Range["B11:B11"].Value = "Mã HĐVB";
                exRange.Range["C11:C11"].Value = "Mã khách hàng";
                exRange.Range["D11:D11"].Value = "Mã thể loại";
                exRange.Range["E11:E11"].Value = "Mã báo";
                exRange.Range["F11:F11"].Value = "Tiêu đề";
                exRange.Range["G11:G11"].Value = "Nội dung";
                exRange.Range["H11:H11"].Value = "Mã nhân viên";
                exRange.Range["I11:I11"].Value = "Ngày đăng";
                exRange.Range["J11:J11"].Value = "Nhuận bút";
                exRange.Range["K11:K11"].Value = "Ngày ký";

                // Lấy dữ liệu từ DataGridView và điền vào bảng
                for (hang = 0; hang < dgriddoanhthu.Rows.Count; hang++)
                {
                    exSheet.Cells[hang + 12, 1] = hang + 1; // Điền số thứ tự vào cột 1 từ dòng 12
                    for (cot = 0; cot < dgriddoanhthu.Columns.Count; cot++)
                    {
                        exSheet.Cells[hang + 12, cot + 2] = dgriddoanhthu.Rows[hang].Cells[cot].Value?.ToString();
                    }
                }
                // Tính tổng nhuận bút
                decimal tongNhuanBut = 0;
                foreach (DataGridViewRow row in dgriddoanhthu.Rows)
                {
                    tongNhuanBut += Convert.ToDecimal(row.Cells["Nhuanbut"].Value);
                }

                // Hiển thị tổng nhuận bút
                exRange = exSheet.Cells[hang + 14, 10]; // Ô để hiển thị tổng nhuận bút (cột J)
                exRange.Font.Bold = true;
                exRange.Value2 = "Tổng Doanh Thu: " + tongNhuanBut.ToString("C");

                // Định dạng chữ ký nhân viên
                exRange = exSheet.Cells[hang + 17, 1]; // Ô A1 
                exRange.Range["A1:C1"].MergeCells = true;
                exRange.Range["A1:C1"].Font.Italic = true;
                exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A1:C1"].Value = "Hà Nội, " + DateTime.Now.ToString(" 'ngày' d 'tháng' M 'năm' yyyy");
                exRange.Range["A2:C2"].Font.Italic = true;
                exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A2:C2"].Value = "Nhân viên";

                // Đặt tên cho sheet và hiển thị Excel
                exSheet.Name = "Hợp đồng bài viết";
                exApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
