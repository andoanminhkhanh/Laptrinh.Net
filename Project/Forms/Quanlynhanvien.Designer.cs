﻿namespace Project.Forms
{
    partial class Quanlynhanvien
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
            this.label1 = new System.Windows.Forms.Label();
            this.chknu = new System.Windows.Forms.CheckBox();
            this.chknam = new System.Windows.Forms.CheckBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.mskmobile = new System.Windows.Forms.MaskedTextBox();
            this.mskdienthoai = new System.Windows.Forms.MaskedTextBox();
            this.mskngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.cbochuyenmon = new System.Windows.Forms.ComboBox();
            this.cbochucvu = new System.Windows.Forms.ComboBox();
            this.cbotrinhdo = new System.Windows.Forms.ComboBox();
            this.cbophongban = new System.Windows.Forms.ComboBox();
            this.cbomabao = new System.Windows.Forms.ComboBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(656, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // chknu
            // 
            this.chknu.AutoSize = true;
            this.chknu.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chknu.Location = new System.Drawing.Point(464, 299);
            this.chknu.Name = "chknu";
            this.chknu.Size = new System.Drawing.Size(90, 49);
            this.chknu.TabIndex = 57;
            this.chknu.Text = "Nữ";
            this.chknu.UseVisualStyleBackColor = true;
            this.chknu.Click += new System.EventHandler(this.chknu_Click);
            // 
            // chknam
            // 
            this.chknam.AutoSize = true;
            this.chknam.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chknam.Location = new System.Drawing.Point(332, 299);
            this.chknam.Name = "chknam";
            this.chknam.Size = new System.Drawing.Size(116, 49);
            this.chknam.TabIndex = 56;
            this.chknam.Text = "Nam";
            this.chknam.UseVisualStyleBackColor = true;
            this.chknam.Click += new System.EventHandler(this.chknam_Click);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtemail.Location = new System.Drawing.Point(1427, 336);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(316, 44);
            this.txtemail.TabIndex = 55;
            // 
            // mskmobile
            // 
            this.mskmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mskmobile.Location = new System.Drawing.Point(1427, 279);
            this.mskmobile.Mask = "(999) 000-0000";
            this.mskmobile.Name = "mskmobile";
            this.mskmobile.Size = new System.Drawing.Size(316, 44);
            this.mskmobile.TabIndex = 54;
            // 
            // mskdienthoai
            // 
            this.mskdienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mskdienthoai.Location = new System.Drawing.Point(1427, 216);
            this.mskdienthoai.Mask = "(999) 000-0000";
            this.mskdienthoai.Name = "mskdienthoai";
            this.mskdienthoai.Size = new System.Drawing.Size(316, 44);
            this.mskdienthoai.TabIndex = 53;
            // 
            // mskngaysinh
            // 
            this.mskngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mskngaysinh.Location = new System.Drawing.Point(332, 359);
            this.mskngaysinh.Mask = "00/00/0000";
            this.mskngaysinh.Name = "mskngaysinh";
            this.mskngaysinh.Size = new System.Drawing.Size(307, 44);
            this.mskngaysinh.TabIndex = 52;
            this.mskngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtdiachi.Location = new System.Drawing.Point(1427, 156);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(316, 44);
            this.txtdiachi.TabIndex = 51;
            // 
            // cbochuyenmon
            // 
            this.cbochuyenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbochuyenmon.FormattingEnabled = true;
            this.cbochuyenmon.Location = new System.Drawing.Point(896, 356);
            this.cbochuyenmon.Name = "cbochuyenmon";
            this.cbochuyenmon.Size = new System.Drawing.Size(307, 45);
            this.cbochuyenmon.TabIndex = 50;
            // 
            // cbochucvu
            // 
            this.cbochucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbochucvu.FormattingEnabled = true;
            this.cbochucvu.Location = new System.Drawing.Point(896, 299);
            this.cbochucvu.Name = "cbochucvu";
            this.cbochucvu.Size = new System.Drawing.Size(307, 45);
            this.cbochucvu.TabIndex = 49;
            // 
            // cbotrinhdo
            // 
            this.cbotrinhdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbotrinhdo.FormattingEnabled = true;
            this.cbotrinhdo.Location = new System.Drawing.Point(896, 245);
            this.cbotrinhdo.Name = "cbotrinhdo";
            this.cbotrinhdo.Size = new System.Drawing.Size(307, 45);
            this.cbotrinhdo.TabIndex = 48;
            // 
            // cbophongban
            // 
            this.cbophongban.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbophongban.FormattingEnabled = true;
            this.cbophongban.Location = new System.Drawing.Point(896, 182);
            this.cbophongban.Name = "cbophongban";
            this.cbophongban.Size = new System.Drawing.Size(307, 45);
            this.cbophongban.TabIndex = 47;
            // 
            // cbomabao
            // 
            this.cbomabao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbomabao.FormattingEnabled = true;
            this.cbomabao.Location = new System.Drawing.Point(1427, 396);
            this.cbomabao.Name = "cbomabao";
            this.cbomabao.Size = new System.Drawing.Size(316, 45);
            this.cbomabao.TabIndex = 46;
            // 
            // txttennv
            // 
            this.txttennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttennv.Location = new System.Drawing.Point(332, 244);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(307, 44);
            this.txttennv.TabIndex = 45;
            // 
            // txtmanv
            // 
            this.txtmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmanv.Location = new System.Drawing.Point(332, 178);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(307, 44);
            this.txtmanv.TabIndex = 44;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(169, 490);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(1574, 276);
            this.DataGridView.TabIndex = 43;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(1258, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 45);
            this.label14.TabIndex = 42;
            this.label14.Text = "Điện thoại";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(161, 299);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 45);
            this.label13.TabIndex = 41;
            this.label13.Text = "Giới tính";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(1258, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 45);
            this.label12.TabIndex = 40;
            this.label12.Text = "Mobile";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(1258, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 45);
            this.label11.TabIndex = 39;
            this.label11.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(158, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 45);
            this.label10.TabIndex = 38;
            this.label10.Text = "Ngày sinh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(1258, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 45);
            this.label9.TabIndex = 37;
            this.label9.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(686, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 45);
            this.label8.TabIndex = 36;
            this.label8.Text = "Chức vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(686, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 45);
            this.label7.TabIndex = 35;
            this.label7.Text = "Trình độ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(686, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 45);
            this.label6.TabIndex = 34;
            this.label6.Text = "Phòng ban";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(164, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 45);
            this.label5.TabIndex = 33;
            this.label5.Text = "Tên NV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(686, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 45);
            this.label4.TabIndex = 32;
            this.label4.Text = "Chuyên môn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(1258, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 45);
            this.label3.TabIndex = 31;
            this.label3.Text = "Mã báo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(167, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 45);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mã NV";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.Image = global::Project.Properties.Resources.pngtree_shutdown_vector_icon_png_image_3722547__1_1;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.Location = new System.Drawing.Point(1608, 852);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnthoat.Size = new System.Drawing.Size(135, 68);
            this.btnthoat.TabIndex = 70;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnluu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnluu.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnluu.Image = global::Project.Properties.Resources.pngtree_save_vector_icon_png_image_3758949__2_;
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluu.Location = new System.Drawing.Point(1046, 852);
            this.btnluu.Name = "btnluu";
            this.btnluu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnluu.Size = new System.Drawing.Size(135, 68);
            this.btnluu.TabIndex = 69;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnxoa.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.Image = global::Project.Properties.Resources.images__1___1_;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.Location = new System.Drawing.Point(456, 852);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnxoa.Size = new System.Drawing.Size(135, 68);
            this.btnxoa.TabIndex = 68;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btnboqua
            // 
            this.btnboqua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnboqua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnboqua.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnboqua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnboqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnboqua.Image = global::Project.Properties.Resources._87754cae9952a8f0bd5f0ac47a62854a_t;
            this.btnboqua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnboqua.Location = new System.Drawing.Point(1318, 852);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnboqua.Size = new System.Drawing.Size(158, 68);
            this.btnboqua.TabIndex = 67;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnboqua.UseVisualStyleBackColor = false;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsua.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsua.Image = global::Project.Properties.Resources.images__2___1_;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.Location = new System.Drawing.Point(750, 852);
            this.btnsua.Name = "btnsua";
            this.btnsua.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnsua.Size = new System.Drawing.Size(135, 68);
            this.btnsua.TabIndex = 65;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnthem.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.Image = global::Project.Properties.Resources.plus_24844_1280__1___2_;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.Location = new System.Drawing.Point(165, 852);
            this.btnthem.Name = "btnthem";
            this.btnthem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnthem.Size = new System.Drawing.Size(135, 68);
            this.btnthem.TabIndex = 64;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // Quanlynhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1836, 1050);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.chknu);
            this.Controls.Add(this.chknam);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.mskmobile);
            this.Controls.Add(this.mskdienthoai);
            this.Controls.Add(this.mskngaysinh);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.cbochuyenmon);
            this.Controls.Add(this.cbochucvu);
            this.Controls.Add(this.cbotrinhdo);
            this.Controls.Add(this.cbophongban);
            this.Controls.Add(this.cbomabao);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Quanlynhanvien";
            this.Text = "Quanlynhanvien";
            this.Load += new System.EventHandler(this.Quanlynhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chknu;
        private System.Windows.Forms.CheckBox chknam;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.MaskedTextBox mskmobile;
        private System.Windows.Forms.MaskedTextBox mskdienthoai;
        private System.Windows.Forms.MaskedTextBox mskngaysinh;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.ComboBox cbochuyenmon;
        private System.Windows.Forms.ComboBox cbochucvu;
        private System.Windows.Forms.ComboBox cbotrinhdo;
        private System.Windows.Forms.ComboBox cbophongban;
        private System.Windows.Forms.ComboBox cbomabao;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
    }
}