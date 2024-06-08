﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Class
{
    internal class Function
    {
        public static SqlConnection Conn;
        public static string connString;
        public static void Connect()
        {
            connString = "Data Source=DESKTOP-6P2TSJE\\SQLEXPRESS;Initial Catalog=LTNET;Integrated Security=True;Encrypt=False";
            Conn = new SqlConnection();
            Conn.ConnectionString = connString;
            Conn.Open();
        }
        public static void Disconnect()
        {
            if (Conn.State == System.Data.ConnectionState.Open)
            {
                Conn.Close();
                Conn.Dispose();
                Conn = null;
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            //SqlDataAdapter Mydata = new SqlDataAdapter(sql, Class.Function.Conn);
            //DataTable table = new DataTable();
            //Mydata.Fill(table);
            //return table;
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Class.Function.Conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            return table;
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Class.Function.Conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;
        }
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Class.Function.Conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Class.Function.Conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static void RunSql(string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = Class.Function.Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception loi)
            {
                MessageBox.Show(loi.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Function.Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Khong the xoa du lieu dang dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cmd.Dispose();
            cmd = null;
        }
        public static bool isdate(string d)
        {
            string[] parts = d.Split('/');
            if ((Convert.ToInt32(parts[0]) >= 1) && (Convert.ToInt32(parts[0]) <= 31) && (Convert.ToInt32(parts[1]) >= 1) && (Convert.ToInt32(parts[1]) <= 12) && (Convert.ToInt32(parts[2]) >= 1900))
                return true;
            else return false;
        }
        public static string convertdatetime(string d)
        {
            string[] parts = d.Split('/');
            string dt = string.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;
        }
        public static string CreateKey()
        {
            string lastEmployeeID = GetLastEmployeeID();
            if (string.IsNullOrEmpty(lastEmployeeID))
            {
                return "NV01"; // Nếu không có nhân viên nào, bắt đầu từ NV01
            }

            // Tách phần số từ mã nhân viên
            int numberPart = int.Parse(lastEmployeeID.Substring(2));
            numberPart++; // Tăng số lên 1

            // Tạo mã nhân viên mới
            return "NV" + numberPart.ToString("D2");
        }
        public static string CreateCustomerKey()
        {
            string lastCustomerID = GetLastCustomerID();
            if (string.IsNullOrEmpty(lastCustomerID))
            {
                return "KH01"; // Nếu không có nhân viên nào, bắt đầu từ NV01
            }
            // Tách phần số từ mã nhân viên
            int soPart = int.Parse(lastCustomerID.Substring(2));
            soPart++; // Tăng số lên 1

            // Tạo mã nhân viên mới
            return "KH" + soPart.ToString("D2");
        }
        private static string GetLastCustomerID()
        {
            string query = "SELECT TOP 1 MaKH FROM tblKhachhang ORDER BY MaKH DESC";

            SqlCommand cmd = new SqlCommand(query, Conn);
            object result = cmd.ExecuteScalar();
            return result != null ? result.ToString() : null;
        }

        private static string GetLastEmployeeID()
        {
            string query = "SELECT TOP 1 MaNV FROM tblNhanvien ORDER BY MaNV DESC";

            SqlCommand cmd = new SqlCommand(query, Conn);
            object result = cmd.ExecuteScalar();
            return result != null ? result.ToString() : null;
        }
        public static string CreateHDKey()
        {
            string lastHDID = GetLastHDID();
            if (string.IsNullOrEmpty(lastHDID))
            {
                return "HDBV01"; // Nếu không có nhân viên nào, bắt đầu từ NV01
            }
            // Tách phần số từ mã nhân viên
            int hdPart = int.Parse(lastHDID.Substring(2));
            hdPart++; // Tăng số lên 1

            // Tạo mã nhân viên mới
            return "HDVB" + hdPart.ToString("D2");
        }
        private static string GetLastHDID()
        {
            string query = "SELECT TOP 1 Malangui FROM tblKhachguibai ORDER BY Malangui DESC";

            SqlCommand cmd = new SqlCommand(query, Conn);
            object result = cmd.ExecuteScalar();
            return result != null ? result.ToString() : null;
        }
        public static string CreateHDQCKey()
        {
            string lastHDQCID = GetLastHDQCID();
            if (string.IsNullOrEmpty(lastHDQCID))
            {
                return "LQC01";
            }

            int hdqcPart = int.Parse(lastHDQCID.Substring(3));
            hdqcPart++; // Tăng số lên 1


            return "LQC" + hdqcPart.ToString("D2");
        }
        private static string GetLastHDQCID()
        {
            string query = "SELECT TOP 1 MalanQC FROM tblKhach_Quangcao ORDER BY MalanQC DESC";

            SqlCommand cmd = new SqlCommand(query, Conn);
            object result = cmd.ExecuteScalar();
            return result != null ? result.ToString() : null;
        }
        public static string ChuyenSoSangChu(string sNumber)
        {
            if (sNumber.Contains("."))
            {
                if (!decimal.TryParse(sNumber, out decimal dNumber))
                {
                    return "Số tiền không hợp lệ.";
                }
                sNumber = Math.Round(dNumber).ToString();
            }
            else
            {
                if (!decimal.TryParse(sNumber, out _))
                {
                    return "Số tiền không hợp lệ.";
                }
            }

            string[] mNumText = new string[]
            {
                "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín"
            };

            string[] mPowersText = new string[]
            {
                "", "nghìn", "triệu", "tỷ"
            };

            string result = "";
            int len = sNumber.Length;

            // Xử lý các nhóm ba chữ số
            for (int i = 0; i < len; i += 3)
            {
                int groupSize = Math.Min(3, len - i);
                string group = sNumber.Substring(len - i - groupSize, groupSize);
                if (!int.TryParse(group, out int number))
                {
                    return "Số tiền không hợp lệ.";
                }

                string groupResult = "";

                // Xử lý hàng đơn vị, chục và trăm
                for (int j = groupSize - 1; j >= 0; j--)
                {
                    int digit = number % 10;
                    number /= 10;

                    if (digit == 0)
                    {
                        // Bỏ qua các chữ số 0
                        if (j == 2 && groupResult != "")
                        {
                            groupResult = "không trăm " + groupResult;
                        }
                        else if (j == 1)
                        {
                            groupResult = "linh " + groupResult;
                        }
                    }
                    else
                    {
                        // Thêm vào chữ số
                        if (j == 2)
                        {
                            groupResult = mNumText[digit] + " trăm " + groupResult;
                        }
                        else if (j == 1)
                        {
                            if (digit == 1)
                            {
                                groupResult = "mười " + groupResult;
                            }
                            else
                            {
                                groupResult = mNumText[digit] + " mươi " + groupResult;
                            }
                        }
                        else
                        {
                            groupResult = mNumText[digit] + " " + groupResult;
                        }
                    }
                }

                // Thêm vào đơn vị (nghìn, triệu, tỷ)
                groupResult += " " + mPowersText[i / 3];

                // Nối vào kết quả chính
                if (result != "")
                {
                    if (groupResult.Trim() != "")
                    {
                        result = groupResult + " " + result;
                    }
                }
                else
                {
                    result = groupResult;
                }
            }

            // Viết hoa chữ cái đầu tiên
            result = char.ToUpper(result[0]) + result.Substring(1).Trim();

            return result + " đồng";
        }
    }
}

