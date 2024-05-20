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
            this.mnuQuanlynhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucvu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChuyenmon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrinhdo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucnang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuQuanlyKhachhang,
            this.mnuQuanlynhanvien,
            this.mnuBao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Quản lý Khách hàng";
            // 
            // MnuQuanlyKhachhang
            // 
            this.MnuQuanlyKhachhang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKhachhang,
            this.mnuLvhd});
            this.MnuQuanlyKhachhang.Name = "MnuQuanlyKhachhang";
            this.MnuQuanlyKhachhang.Size = new System.Drawing.Size(154, 24);
            this.MnuQuanlyKhachhang.Text = "Quản lý Khách hàng";
            // 
            // mnuKhachhang
            // 
            this.mnuKhachhang.Name = "mnuKhachhang";
            this.mnuKhachhang.Size = new System.Drawing.Size(219, 26);
            this.mnuKhachhang.Text = "Khách hàng";
            this.mnuKhachhang.Click += new System.EventHandler(this.mnuKhachhang_Click);
            // 
            // mnuLvhd
            // 
            this.mnuLvhd.Name = "mnuLvhd";
            this.mnuLvhd.Size = new System.Drawing.Size(219, 26);
            this.mnuLvhd.Text = "Lĩnh vực hoạt động";
            this.mnuLvhd.Click += new System.EventHandler(this.mnuLvhd_Click);
            // 
            // mnuQuanlynhanvien
            // 
            this.mnuQuanlynhanvien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChucvu,
            this.mnuChuyenmon,
            this.mnuTrinhdo});
            this.mnuQuanlynhanvien.Name = "mnuQuanlynhanvien";
            this.mnuQuanlynhanvien.Size = new System.Drawing.Size(140, 24);
            this.mnuQuanlynhanvien.Text = "Quản lý nhân viên";
            // 
            // mnuChucvu
            // 
            this.mnuChucvu.Name = "mnuChucvu";
            this.mnuChucvu.Size = new System.Drawing.Size(224, 26);
            this.mnuChucvu.Text = "Chức vụ";
            this.mnuChucvu.Click += new System.EventHandler(this.chứcVụToolStripMenuItem_Click);
            // 
            // mnuChuyenmon
            // 
            this.mnuChuyenmon.Name = "mnuChuyenmon";
            this.mnuChuyenmon.Size = new System.Drawing.Size(224, 26);
            this.mnuChuyenmon.Text = "Chuyên môn";
            this.mnuChuyenmon.Click += new System.EventHandler(this.chuyênMônToolStripMenuItem_Click);
            // 
            // mnuTrinhdo
            // 
            this.mnuTrinhdo.Name = "mnuTrinhdo";
            this.mnuTrinhdo.Size = new System.Drawing.Size(224, 26);
            this.mnuTrinhdo.Text = "Trình độ";
            this.mnuTrinhdo.Click += new System.EventHandler(this.trinhdoToolStripMenuItem_Click);
            // 
            // mnuBao
            // 
            this.mnuBao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChucnang});
            this.mnuBao.Name = "mnuBao";
            this.mnuBao.Size = new System.Drawing.Size(49, 24);
            this.mnuBao.Text = "Báo";
            // 
            // mnuChucnang
            // 
            this.mnuChucnang.Name = "mnuChucnang";
            this.mnuChucnang.Size = new System.Drawing.Size(224, 26);
            this.mnuChucnang.Text = "Chức năng";
            this.mnuChucnang.Click += new System.EventHandler(this.chứcNăngToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem mnuQuanlynhanvien;
        private System.Windows.Forms.ToolStripMenuItem mnuChucvu;
        private System.Windows.Forms.ToolStripMenuItem mnuBao;
        private System.Windows.Forms.ToolStripMenuItem mnuChucnang;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenmon;
        private System.Windows.Forms.ToolStripMenuItem mnuTrinhdo;
    }
}

