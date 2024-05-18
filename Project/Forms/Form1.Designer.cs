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
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyênMônToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trinhdoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuQuanlyKhachhang,
            this.quảnLýNhânViênToolStripMenuItem,
            this.báoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(900, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Quản lý Khách hàng";
            // 
            // MnuQuanlyKhachhang
            // 
            this.MnuQuanlyKhachhang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKhachhang,
            this.mnuLvhd});
            this.MnuQuanlyKhachhang.Name = "MnuQuanlyKhachhang";
            this.MnuQuanlyKhachhang.Size = new System.Drawing.Size(186, 29);
            this.MnuQuanlyKhachhang.Text = "Quản lý Khách hàng";
            // 
            // mnuKhachhang
            // 
            this.mnuKhachhang.Name = "mnuKhachhang";
            this.mnuKhachhang.Size = new System.Drawing.Size(268, 34);
            this.mnuKhachhang.Text = "Khách hàng";
            this.mnuKhachhang.Click += new System.EventHandler(this.mnuKhachhang_Click);
            // 
            // mnuLvhd
            // 
            this.mnuLvhd.Name = "mnuLvhd";
            this.mnuLvhd.Size = new System.Drawing.Size(268, 34);
            this.mnuLvhd.Text = "Lĩnh vực hoạt động";
            this.mnuLvhd.Click += new System.EventHandler(this.mnuLvhd_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcVụToolStripMenuItem,
            this.chuyênMônToolStripMenuItem,
            this.trinhdoToolStripMenuItem});
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(170, 29);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // chứcVụToolStripMenuItem
            // 
            this.chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            this.chứcVụToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.chứcVụToolStripMenuItem.Text = "Chức vụ";
            this.chứcVụToolStripMenuItem.Click += new System.EventHandler(this.chứcVụToolStripMenuItem_Click);
            // 
            // chuyênMônToolStripMenuItem
            // 
            this.chuyênMônToolStripMenuItem.Name = "chuyênMônToolStripMenuItem";
            this.chuyênMônToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.chuyênMônToolStripMenuItem.Text = "Chuyên môn";
            this.chuyênMônToolStripMenuItem.Click += new System.EventHandler(this.chuyênMônToolStripMenuItem_Click);
            // 
            // trinhdoToolStripMenuItem
            // 
            this.trinhdoToolStripMenuItem.Name = "trinhdoToolStripMenuItem";
            this.trinhdoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.trinhdoToolStripMenuItem.Text = "Trình độ";
            this.trinhdoToolStripMenuItem.Click += new System.EventHandler(this.trinhdoToolStripMenuItem_Click);
            // 
            // báoToolStripMenuItem
            // 
            this.báoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.báoToolStripMenuItem.Name = "báoToolStripMenuItem";
            this.báoToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.báoToolStripMenuItem.Text = "Báo";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            this.chứcNăngToolStripMenuItem.Click += new System.EventHandler(this.chứcNăngToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyênMônToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trinhdoToolStripMenuItem;
    }
}

