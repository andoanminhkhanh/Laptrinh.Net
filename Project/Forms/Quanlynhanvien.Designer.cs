namespace Project.Forms
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
            this.label1.Location = new System.Drawing.Point(753, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // chknu
            // 
            this.chknu.AutoSize = true;
            this.chknu.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chknu.Location = new System.Drawing.Point(570, 293);
            this.chknu.Name = "chknu";
            this.chknu.Size = new System.Drawing.Size(76, 42);
            this.chknu.TabIndex = 57;
            this.chknu.Text = "Nữ";
            this.chknu.UseVisualStyleBackColor = true;
            this.chknu.Click += new System.EventHandler(this.chknu_Click);
            // 
            // chknam
            // 
            this.chknam.AutoSize = true;
            this.chknam.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chknam.Location = new System.Drawing.Point(454, 293);
            this.chknam.Name = "chknam";
            this.chknam.Size = new System.Drawing.Size(98, 42);
            this.chknam.TabIndex = 56;
            this.chknam.Text = "Nam";
            this.chknam.UseVisualStyleBackColor = true;
            this.chknam.Click += new System.EventHandler(this.chknam_Click);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtemail.Location = new System.Drawing.Point(1427, 322);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(281, 38);
            this.txtemail.TabIndex = 55;
            // 
            // mskmobile
            // 
            this.mskmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mskmobile.Location = new System.Drawing.Point(1427, 277);
            this.mskmobile.Mask = "(999) 000-0000";
            this.mskmobile.Name = "mskmobile";
            this.mskmobile.Size = new System.Drawing.Size(281, 38);
            this.mskmobile.TabIndex = 54;
            // 
            // mskdienthoai
            // 
            this.mskdienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mskdienthoai.Location = new System.Drawing.Point(1427, 227);
            this.mskdienthoai.Mask = "(999) 000-0000";
            this.mskdienthoai.Name = "mskdienthoai";
            this.mskdienthoai.Size = new System.Drawing.Size(281, 38);
            this.mskdienthoai.TabIndex = 53;
            // 
            // mskngaysinh
            // 
            this.mskngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mskngaysinh.Location = new System.Drawing.Point(454, 341);
            this.mskngaysinh.Mask = "00/00/0000";
            this.mskngaysinh.Name = "mskngaysinh";
            this.mskngaysinh.Size = new System.Drawing.Size(274, 38);
            this.mskngaysinh.TabIndex = 52;
            this.mskngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtdiachi.Location = new System.Drawing.Point(1427, 179);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(281, 38);
            this.txtdiachi.TabIndex = 51;
            // 
            // cbochuyenmon
            // 
            this.cbochuyenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbochuyenmon.FormattingEnabled = true;
            this.cbochuyenmon.Location = new System.Drawing.Point(955, 338);
            this.cbochuyenmon.Name = "cbochuyenmon";
            this.cbochuyenmon.Size = new System.Drawing.Size(273, 39);
            this.cbochuyenmon.TabIndex = 50;
            // 
            // cbochucvu
            // 
            this.cbochucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbochucvu.FormattingEnabled = true;
            this.cbochucvu.Location = new System.Drawing.Point(955, 293);
            this.cbochucvu.Name = "cbochucvu";
            this.cbochucvu.Size = new System.Drawing.Size(273, 39);
            this.cbochucvu.TabIndex = 49;
            // 
            // cbotrinhdo
            // 
            this.cbotrinhdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbotrinhdo.FormattingEnabled = true;
            this.cbotrinhdo.Location = new System.Drawing.Point(955, 250);
            this.cbotrinhdo.Name = "cbotrinhdo";
            this.cbotrinhdo.Size = new System.Drawing.Size(273, 39);
            this.cbotrinhdo.TabIndex = 48;
            // 
            // cbophongban
            // 
            this.cbophongban.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbophongban.FormattingEnabled = true;
            this.cbophongban.Location = new System.Drawing.Point(955, 199);
            this.cbophongban.Name = "cbophongban";
            this.cbophongban.Size = new System.Drawing.Size(273, 39);
            this.cbophongban.TabIndex = 47;
            // 
            // cbomabao
            // 
            this.cbomabao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbomabao.FormattingEnabled = true;
            this.cbomabao.Location = new System.Drawing.Point(1427, 370);
            this.cbomabao.Name = "cbomabao";
            this.cbomabao.Size = new System.Drawing.Size(281, 39);
            this.cbomabao.TabIndex = 46;
            // 
            // txttennv
            // 
            this.txttennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttennv.Location = new System.Drawing.Point(454, 249);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(274, 38);
            this.txttennv.TabIndex = 45;
            // 
            // txtmanv
            // 
            this.txtmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmanv.Location = new System.Drawing.Point(454, 196);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(274, 38);
            this.txtmanv.TabIndex = 44;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(193, 433);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(1658, 348);
            this.DataGridView.TabIndex = 43;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(1276, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 38);
            this.label14.TabIndex = 42;
            this.label14.Text = "Điện thoại";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(301, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 38);
            this.label13.TabIndex = 41;
            this.label13.Text = "Giới tính";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(1276, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 38);
            this.label12.TabIndex = 40;
            this.label12.Text = "Mobile";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(1276, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 38);
            this.label11.TabIndex = 39;
            this.label11.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(299, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 38);
            this.label10.TabIndex = 38;
            this.label10.Text = "Ngày sinh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(1276, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 38);
            this.label9.TabIndex = 37;
            this.label9.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(768, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 38);
            this.label8.TabIndex = 36;
            this.label8.Text = "Chức vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(768, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 38);
            this.label7.TabIndex = 35;
            this.label7.Text = "Trình độ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(768, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 38);
            this.label6.TabIndex = 34;
            this.label6.Text = "Phòng ban";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(304, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 38);
            this.label5.TabIndex = 33;
            this.label5.Text = "Tên NV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(768, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 38);
            this.label4.TabIndex = 32;
            this.label4.Text = "Chuyên môn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(1276, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 38);
            this.label3.TabIndex = 31;
            this.label3.Text = "Mã báo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(306, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 38);
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
            this.btnthoat.Location = new System.Drawing.Point(1588, 843);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnthoat.Size = new System.Drawing.Size(120, 54);
            this.btnthoat.TabIndex = 70;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.UseVisualStyleBackColor = false;
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
            this.btnluu.Location = new System.Drawing.Point(1108, 843);
            this.btnluu.Name = "btnluu";
            this.btnluu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnluu.Size = new System.Drawing.Size(120, 54);
            this.btnluu.TabIndex = 69;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.UseVisualStyleBackColor = false;
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
            this.btnxoa.Location = new System.Drawing.Point(608, 843);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnxoa.Size = new System.Drawing.Size(120, 54);
            this.btnxoa.TabIndex = 68;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.UseVisualStyleBackColor = false;
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
            this.btnboqua.Location = new System.Drawing.Point(1341, 843);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnboqua.Size = new System.Drawing.Size(140, 54);
            this.btnboqua.TabIndex = 67;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnboqua.UseVisualStyleBackColor = false;
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
            this.btnsua.Location = new System.Drawing.Point(870, 843);
            this.btnsua.Name = "btnsua";
            this.btnsua.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnsua.Size = new System.Drawing.Size(120, 54);
            this.btnsua.TabIndex = 65;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.UseVisualStyleBackColor = false;
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
            this.btnthem.Location = new System.Drawing.Point(349, 843);
            this.btnthem.Name = "btnthem";
            this.btnthem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnthem.Size = new System.Drawing.Size(120, 54);
            this.btnthem.TabIndex = 64;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.UseVisualStyleBackColor = false;
            // 
            // Quanlynhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1882, 889);
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