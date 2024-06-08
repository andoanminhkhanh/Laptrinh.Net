namespace Project.Forms
{
    partial class Hopdongbaiviet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTim = new System.Windows.Forms.Button();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.cbMahopdong = new System.Windows.Forms.ComboBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThembaiviet = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblBangchu = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNhuanbut = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgridHopdongbaiviet = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.mskNgaydang = new System.Windows.Forms.MaskedTextBox();
            this.cbMatheloai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbMabao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTieude = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNoidung = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.txtNgayky = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbLVHD = new System.Windows.Forms.ComboBox();
            this.txtTenkhach = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblLVHD = new System.Windows.Forms.Label();
            this.txtMakhach = new System.Windows.Forms.TextBox();
            this.txtMahopdong = new System.Windows.Forms.TextBox();
            this.mskDidong = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cbManhanvien = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDidong = new System.Windows.Forms.Label();
            this.mskDienthoai = new System.Windows.Forms.MaskedTextBox();
            this.lblDienthoai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridHopdongbaiviet)).BeginInit();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(419, 136);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(41, 20);
            this.btnTim.TabIndex = 47;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(588, 27);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(115, 23);
            this.txtDiachi.TabIndex = 40;
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(507, 29);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(49, 15);
            this.lblDiachi.TabIndex = 39;
            this.lblDiachi.Text = "Địa chỉ: ";
            // 
            // cbMahopdong
            // 
            this.cbMahopdong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMahopdong.FormattingEnabled = true;
            this.cbMahopdong.Location = new System.Drawing.Point(94, 426);
            this.cbMahopdong.Name = "cbMahopdong";
            this.cbMahopdong.Size = new System.Drawing.Size(119, 23);
            this.cbMahopdong.TabIndex = 52;
            this.cbMahopdong.DropDown += new System.EventHandler(this.cbMahopdong_DropDown);
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.btnIn);
            this.gb2.Controls.Add(this.btnTimkiem);
            this.gb2.Controls.Add(this.cbMahopdong);
            this.gb2.Controls.Add(this.btnDong);
            this.gb2.Controls.Add(this.label13);
            this.gb2.Controls.Add(this.btnHuy);
            this.gb2.Controls.Add(this.btnLuu);
            this.gb2.Controls.Add(this.btnThembaiviet);
            this.gb2.Controls.Add(this.btnThem);
            this.gb2.Controls.Add(this.lblBangchu);
            this.gb2.Controls.Add(this.txtTongtien);
            this.gb2.Controls.Add(this.label14);
            this.gb2.Controls.Add(this.txtNhuanbut);
            this.gb2.Controls.Add(this.label10);
            this.gb2.Controls.Add(this.dgridHopdongbaiviet);
            this.gb2.Controls.Add(this.label4);
            this.gb2.Controls.Add(this.mskNgaydang);
            this.gb2.Controls.Add(this.cbMatheloai);
            this.gb2.Controls.Add(this.label7);
            this.gb2.Controls.Add(this.label9);
            this.gb2.Controls.Add(this.cbMabao);
            this.gb2.Controls.Add(this.label5);
            this.gb2.Controls.Add(this.txtTieude);
            this.gb2.Controls.Add(this.label8);
            this.gb2.Controls.Add(this.txtNoidung);
            this.gb2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb2.Location = new System.Drawing.Point(72, 237);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(731, 487);
            this.gb2.TabIndex = 51;
            this.gb2.TabStop = false;
            this.gb2.Text = "Thông tin hợp đồng";
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Image = global::Project.Properties.Resources._535198__1_;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.Location = new System.Drawing.Point(510, 391);
            this.btnIn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnIn.Name = "btnIn";
            this.btnIn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnIn.Size = new System.Drawing.Size(100, 29);
            this.btnIn.TabIndex = 67;
            this.btnIn.Text = "In hợp đồng";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDong.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Image = global::Project.Properties.Resources.pngtree_shutdown_vector_icon_png_image_3722547__1_;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.Location = new System.Drawing.Point(624, 390);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDong.Name = "btnDong";
            this.btnDong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDong.Size = new System.Drawing.Size(65, 31);
            this.btnDong.TabIndex = 66;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Image = global::Project.Properties.Resources.images__1___1_;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.Location = new System.Drawing.Point(384, 391);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnHuy.Size = new System.Drawing.Size(114, 29);
            this.btnHuy.TabIndex = 65;
            this.btnHuy.Text = "Hủy hợp đồng";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Image = global::Project.Properties.Resources.pngtree_save_vector_icon_png_image_3758949__2_;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.Location = new System.Drawing.Point(305, 391);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLuu.Size = new System.Drawing.Size(65, 29);
            this.btnLuu.TabIndex = 63;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThembaiviet
            // 
            this.btnThembaiviet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThembaiviet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThembaiviet.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnThembaiviet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThembaiviet.Image = global::Project.Properties.Resources.plus_24844_1280__1___2_;
            this.btnThembaiviet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThembaiviet.Location = new System.Drawing.Point(90, 391);
            this.btnThembaiviet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThembaiviet.Name = "btnThembaiviet";
            this.btnThembaiviet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnThembaiviet.Size = new System.Drawing.Size(91, 29);
            this.btnThembaiviet.TabIndex = 62;
            this.btnThembaiviet.Text = "Thêm bài viết";
            this.btnThembaiviet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThembaiviet.UseVisualStyleBackColor = false;
            this.btnThembaiviet.Click += new System.EventHandler(this.btnThembaiviet_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = global::Project.Properties.Resources.plus_24844_1280__1___2_;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(191, 391);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnThem.Size = new System.Drawing.Size(104, 29);
            this.btnThem.TabIndex = 59;
            this.btnThem.Text = "Thêm hợp đồng";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblBangchu
            // 
            this.lblBangchu.AutoSize = true;
            this.lblBangchu.Location = new System.Drawing.Point(6, 367);
            this.lblBangchu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBangchu.Name = "lblBangchu";
            this.lblBangchu.Size = new System.Drawing.Size(63, 15);
            this.lblBangchu.TabIndex = 61;
            this.lblBangchu.Text = "Bằng chữ: ";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(539, 361);
            this.txtTongtien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(150, 23);
            this.txtTongtien.TabIndex = 60;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(466, 364);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 15);
            this.label14.TabIndex = 59;
            this.label14.Text = "Tổng tiền";
            // 
            // txtNhuanbut
            // 
            this.txtNhuanbut.Location = new System.Drawing.Point(440, 62);
            this.txtNhuanbut.Name = "txtNhuanbut";
            this.txtNhuanbut.Size = new System.Drawing.Size(117, 23);
            this.txtNhuanbut.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(366, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 37;
            this.label10.Text = "Nhuận bút:";
            // 
            // dgridHopdongbaiviet
            // 
            this.dgridHopdongbaiviet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridHopdongbaiviet.Location = new System.Drawing.Point(9, 182);
            this.dgridHopdongbaiviet.Name = "dgridHopdongbaiviet";
            this.dgridHopdongbaiviet.RowHeadersWidth = 51;
            this.dgridHopdongbaiviet.Size = new System.Drawing.Size(680, 170);
            this.dgridHopdongbaiviet.TabIndex = 14;
            this.dgridHopdongbaiviet.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridHopdongbaiviet_CellDoubleClick);
            this.dgridHopdongbaiviet.Click += new System.EventHandler(this.dgridHopdongbaiviet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mã thể loại:";
            // 
            // mskNgaydang
            // 
            this.mskNgaydang.Location = new System.Drawing.Point(440, 22);
            this.mskNgaydang.Mask = "00/00/0000";
            this.mskNgaydang.Name = "mskNgaydang";
            this.mskNgaydang.Size = new System.Drawing.Size(114, 23);
            this.mskNgaydang.TabIndex = 38;
            this.mskNgaydang.ValidatingType = typeof(System.DateTime);
            // 
            // cbMatheloai
            // 
            this.cbMatheloai.FormattingEnabled = true;
            this.cbMatheloai.Location = new System.Drawing.Point(166, 23);
            this.cbMatheloai.Name = "cbMatheloai";
            this.cbMatheloai.Size = new System.Drawing.Size(142, 23);
            this.cbMatheloai.TabIndex = 23;
            this.cbMatheloai.SelectedIndexChanged += new System.EventHandler(this.cbMatheloai_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tiêu đề:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "Ngày đăng: ";
            // 
            // cbMabao
            // 
            this.cbMabao.FormattingEnabled = true;
            this.cbMabao.Location = new System.Drawing.Point(166, 62);
            this.cbMabao.Name = "cbMabao";
            this.cbMabao.Size = new System.Drawing.Size(142, 23);
            this.cbMabao.TabIndex = 35;
            this.cbMabao.SelectedIndexChanged += new System.EventHandler(this.cbMabao_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Mã báo:";
            // 
            // txtTieude
            // 
            this.txtTieude.Location = new System.Drawing.Point(90, 101);
            this.txtTieude.Name = "txtTieude";
            this.txtTieude.Size = new System.Drawing.Size(600, 23);
            this.txtTieude.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Nội dung:";
            // 
            // txtNoidung
            // 
            this.txtNoidung.Location = new System.Drawing.Point(90, 143);
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.Size = new System.Drawing.Size(600, 23);
            this.txtNoidung.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 426);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 15);
            this.label13.TabIndex = 49;
            this.label13.Text = "Mã hợp đồng:";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Location = new System.Drawing.Point(224, 426);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(65, 25);
            this.btnTimkiem.TabIndex = 58;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.txtNgayky);
            this.gb1.Controls.Add(this.label15);
            this.gb1.Controls.Add(this.btnTim);
            this.gb1.Controls.Add(this.txtDiachi);
            this.gb1.Controls.Add(this.lblDiachi);
            this.gb1.Controls.Add(this.txtEmail);
            this.gb1.Controls.Add(this.label12);
            this.gb1.Controls.Add(this.cbLVHD);
            this.gb1.Controls.Add(this.txtTenkhach);
            this.gb1.Controls.Add(this.label11);
            this.gb1.Controls.Add(this.lblLVHD);
            this.gb1.Controls.Add(this.txtMakhach);
            this.gb1.Controls.Add(this.txtMahopdong);
            this.gb1.Controls.Add(this.mskDidong);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.lblEmail);
            this.gb1.Controls.Add(this.cbManhanvien);
            this.gb1.Controls.Add(this.label6);
            this.gb1.Controls.Add(this.lblDidong);
            this.gb1.Controls.Add(this.mskDienthoai);
            this.gb1.Controls.Add(this.lblDienthoai);
            this.gb1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.Location = new System.Drawing.Point(72, 53);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(745, 176);
            this.gb1.TabIndex = 50;
            this.gb1.TabStop = false;
            this.gb1.Text = "Thông tin chung";
            // 
            // txtNgayky
            // 
            this.txtNgayky.Location = new System.Drawing.Point(90, 143);
            this.txtNgayky.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNgayky.Name = "txtNgayky";
            this.txtNgayky.Size = new System.Drawing.Size(119, 23);
            this.txtNgayky.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 146);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 15);
            this.label15.TabIndex = 48;
            this.label15.Text = "Ngày ký:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(588, 68);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(114, 23);
            this.txtEmail.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 15);
            this.label12.TabIndex = 29;
            // 
            // cbLVHD
            // 
            this.cbLVHD.FormattingEnabled = true;
            this.cbLVHD.Location = new System.Drawing.Point(588, 105);
            this.cbLVHD.Name = "cbLVHD";
            this.cbLVHD.Size = new System.Drawing.Size(114, 23);
            this.cbLVHD.TabIndex = 37;
            // 
            // txtTenkhach
            // 
            this.txtTenkhach.Location = new System.Drawing.Point(327, 23);
            this.txtTenkhach.Name = "txtTenkhach";
            this.txtTenkhach.Size = new System.Drawing.Size(133, 23);
            this.txtTenkhach.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(236, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Tên khách:";
            // 
            // lblLVHD
            // 
            this.lblLVHD.AutoSize = true;
            this.lblLVHD.Location = new System.Drawing.Point(507, 107);
            this.lblLVHD.Name = "lblLVHD";
            this.lblLVHD.Size = new System.Drawing.Size(62, 15);
            this.lblLVHD.TabIndex = 36;
            this.lblLVHD.Text = "Mã LVHĐ: ";
            // 
            // txtMakhach
            // 
            this.txtMakhach.Location = new System.Drawing.Point(90, 105);
            this.txtMakhach.Name = "txtMakhach";
            this.txtMakhach.Size = new System.Drawing.Size(119, 23);
            this.txtMakhach.TabIndex = 23;
            // 
            // txtMahopdong
            // 
            this.txtMahopdong.Location = new System.Drawing.Point(90, 25);
            this.txtMahopdong.Name = "txtMahopdong";
            this.txtMahopdong.Size = new System.Drawing.Size(119, 23);
            this.txtMahopdong.TabIndex = 1;
            // 
            // mskDidong
            // 
            this.mskDidong.Location = new System.Drawing.Point(327, 64);
            this.mskDidong.Mask = "(999) 000-0000";
            this.mskDidong.Name = "mskDidong";
            this.mskDidong.Size = new System.Drawing.Size(134, 23);
            this.mskDidong.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã hợp đồng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã khách:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(507, 66);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "Email: ";
            // 
            // cbManhanvien
            // 
            this.cbManhanvien.FormattingEnabled = true;
            this.cbManhanvien.Location = new System.Drawing.Point(90, 64);
            this.cbManhanvien.Name = "cbManhanvien";
            this.cbManhanvien.Size = new System.Drawing.Size(119, 23);
            this.cbManhanvien.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Mã nhân viên: ";
            // 
            // lblDidong
            // 
            this.lblDidong.AutoSize = true;
            this.lblDidong.Location = new System.Drawing.Point(236, 66);
            this.lblDidong.Name = "lblDidong";
            this.lblDidong.Size = new System.Drawing.Size(55, 15);
            this.lblDidong.TabIndex = 33;
            this.lblDidong.Text = "Di động: ";
            // 
            // mskDienthoai
            // 
            this.mskDienthoai.Location = new System.Drawing.Point(327, 107);
            this.mskDienthoai.Mask = "(999) 000-0000";
            this.mskDienthoai.Name = "mskDienthoai";
            this.mskDienthoai.Size = new System.Drawing.Size(134, 23);
            this.mskDienthoai.TabIndex = 31;
            // 
            // lblDienthoai
            // 
            this.lblDienthoai.AutoSize = true;
            this.lblDienthoai.Location = new System.Drawing.Point(235, 105);
            this.lblDienthoai.Name = "lblDienthoai";
            this.lblDienthoai.Size = new System.Drawing.Size(64, 15);
            this.lblDienthoai.TabIndex = 32;
            this.lblDienthoai.Text = "Điện thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 30);
            this.label1.TabIndex = 47;
            this.label1.Text = "HỢP ĐỒNG BÀI VIẾT";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(582, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 59;
            // 
            // Hopdongbaiviet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(871, 780);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb2);
            this.Name = "Hopdongbaiviet";
            this.Text = "Hợp đồng bài viết";
            this.Load += new System.EventHandler(this.Hopdongbaiviet_Load);
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridHopdongbaiviet)).EndInit();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.ComboBox cbMahopdong;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.TextBox txtNhuanbut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgridHopdongbaiviet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskNgaydang;
        private System.Windows.Forms.ComboBox cbMatheloai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbMabao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTieude;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNoidung;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbLVHD;
        private System.Windows.Forms.TextBox txtTenkhach;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblLVHD;
        private System.Windows.Forms.TextBox txtMakhach;
        private System.Windows.Forms.TextBox txtMahopdong;
        private System.Windows.Forms.MaskedTextBox mskDidong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cbManhanvien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDidong;
        private System.Windows.Forms.MaskedTextBox mskDienthoai;
        private System.Windows.Forms.Label lblDienthoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBangchu;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThembaiviet;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtNgayky;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1;
    }
}