namespace Project
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuQuanlyKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLvhd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Phongban = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Nhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyênMônToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trinhdoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTheloai = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_QC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TTQC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_banggia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuQuanlyKhachhang,
            this.mnu_Phongban,
            this.báoToolStripMenuItem,
            this.mnu_QC});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Quản lý Khách hàng";
            // 
            // MnuQuanlyKhachhang
            // 
            this.MnuQuanlyKhachhang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKhachhang,
            this.mnuLvhd});
            this.MnuQuanlyKhachhang.Name = "MnuQuanlyKhachhang";
            this.MnuQuanlyKhachhang.Size = new System.Drawing.Size(126, 20);
            this.MnuQuanlyKhachhang.Text = "Quản lý Khách hàng";
            // 
            // mnuKhachhang
            // 
            this.mnuKhachhang.Name = "mnuKhachhang";
            this.mnuKhachhang.Size = new System.Drawing.Size(177, 22);
            this.mnuKhachhang.Text = "Khách hàng";
            this.mnuKhachhang.Click += new System.EventHandler(this.mnuKhachhang_Click);
            // 
            // mnuLvhd
            // 
            this.mnuLvhd.Name = "mnuLvhd";
            this.mnuLvhd.Size = new System.Drawing.Size(177, 22);
            this.mnuLvhd.Text = "Lĩnh vực hoạt động";
            this.mnuLvhd.Click += new System.EventHandler(this.mnuLvhd_Click);
            // 
            // mnu_Phongban
            // 
            this.mnu_Phongban.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Nhanvien,
            this.chứcVụToolStripMenuItem,
            this.chuyênMônToolStripMenuItem,
            this.trinhdoToolStripMenuItem,
            this.phòngBanToolStripMenuItem});
            this.mnu_Phongban.Name = "mnu_Phongban";
            this.mnu_Phongban.Size = new System.Drawing.Size(115, 20);
            this.mnu_Phongban.Text = "Quản lý nhân viên";
            // 
            // mnu_Nhanvien
            // 
            this.mnu_Nhanvien.Name = "mnu_Nhanvien";
            this.mnu_Nhanvien.Size = new System.Drawing.Size(143, 22);
            this.mnu_Nhanvien.Text = "Nhân viên";
            this.mnu_Nhanvien.Click += new System.EventHandler(this.mnu_Nhanvien_Click);
            // 
            // chứcVụToolStripMenuItem
            // 
            this.chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            this.chứcVụToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.chứcVụToolStripMenuItem.Text = "Chức vụ";
            this.chứcVụToolStripMenuItem.Click += new System.EventHandler(this.chứcVụToolStripMenuItem_Click);
            // 
            // chuyênMônToolStripMenuItem
            // 
            this.chuyênMônToolStripMenuItem.Name = "chuyênMônToolStripMenuItem";
            this.chuyênMônToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.chuyênMônToolStripMenuItem.Text = "Chuyên môn";
            this.chuyênMônToolStripMenuItem.Click += new System.EventHandler(this.chuyênMônToolStripMenuItem_Click);
            // 
            // trinhdoToolStripMenuItem
            // 
            this.trinhdoToolStripMenuItem.Name = "trinhdoToolStripMenuItem";
            this.trinhdoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.trinhdoToolStripMenuItem.Text = "Trình độ";
            this.trinhdoToolStripMenuItem.Click += new System.EventHandler(this.trinhdoToolStripMenuItem_Click);
            // 
            // phòngBanToolStripMenuItem
            // 
            this.phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            this.phòngBanToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.phòngBanToolStripMenuItem.Text = "Phòng ban";
            this.phòngBanToolStripMenuItem.Click += new System.EventHandler(this.phòngBanToolStripMenuItem_Click);
            // 
            // báoToolStripMenuItem
            // 
            this.báoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem,
            this.mnuTheloai});
            this.báoToolStripMenuItem.Name = "báoToolStripMenuItem";
            this.báoToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.báoToolStripMenuItem.Text = "Báo";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            this.chứcNăngToolStripMenuItem.Click += new System.EventHandler(this.chứcNăngToolStripMenuItem_Click);
            // 
            // mnuTheloai
            // 
            this.mnuTheloai.Name = "mnuTheloai";
            this.mnuTheloai.Size = new System.Drawing.Size(180, 22);
            this.mnuTheloai.Text = "Thể loại";
            this.mnuTheloai.Click += new System.EventHandler(this.mnuTheloai_Click);
            // 
            // mnu_QC
            // 
            this.mnu_QC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_TTQC,
            this.mnu_banggia});
            this.mnu_QC.Name = "mnu_QC";
            this.mnu_QC.Size = new System.Drawing.Size(77, 20);
            this.mnu_QC.Text = "Quảng cáo";
            // 
            // mnu_TTQC
            // 
            this.mnu_TTQC.Name = "mnu_TTQC";
            this.mnu_TTQC.Size = new System.Drawing.Size(147, 22);
            this.mnu_TTQC.Text = "TT Quảng cáo";
            this.mnu_TTQC.Click += new System.EventHandler(this.mnu_TTQC_Click);
            // 
            // mnu_banggia
            // 
            this.mnu_banggia.Name = "mnu_banggia";
            this.mnu_banggia.Size = new System.Drawing.Size(147, 22);
            this.mnu_banggia.Text = "Bảng giá";
            this.mnu_banggia.Click += new System.EventHandler(this.mnu_banggia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuQuanlyKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuLvhd;
        private System.Windows.Forms.ToolStripMenuItem mnu_Phongban;
        private System.Windows.Forms.ToolStripMenuItem chứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyênMônToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trinhdoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_Nhanvien;
        private System.Windows.Forms.ToolStripMenuItem mnu_QC;
        private System.Windows.Forms.ToolStripMenuItem mnu_TTQC;
        private System.Windows.Forms.ToolStripMenuItem mnu_banggia;
        private System.Windows.Forms.ToolStripMenuItem phòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTheloai;
    }
}

