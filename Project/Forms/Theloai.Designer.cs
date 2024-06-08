namespace Project.Forms
{
    partial class mnuTheloai
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
            this.txtTentheloai = new System.Windows.Forms.TextBox();
            this.lblTenLVHD = new System.Windows.Forms.Label();
            this.lblMatheloai = new System.Windows.Forms.Label();
            this.txtMatheloai = new System.Windows.Forms.TextBox();
            this.lblTheloai = new System.Windows.Forms.Label();
            this.dgridTL = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgridTL)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTentheloai
            // 
            this.txtTentheloai.Location = new System.Drawing.Point(222, 137);
            this.txtTentheloai.Name = "txtTentheloai";
            this.txtTentheloai.Size = new System.Drawing.Size(290, 23);
            this.txtTentheloai.TabIndex = 24;
            // 
            // lblTenLVHD
            // 
            this.lblTenLVHD.AutoSize = true;
            this.lblTenLVHD.Location = new System.Drawing.Point(113, 137);
            this.lblTenLVHD.Name = "lblTenLVHD";
            this.lblTenLVHD.Size = new System.Drawing.Size(70, 15);
            this.lblTenLVHD.TabIndex = 23;
            this.lblTenLVHD.Text = "Tên thể loại:";
            // 
            // lblMatheloai
            // 
            this.lblMatheloai.AutoSize = true;
            this.lblMatheloai.Location = new System.Drawing.Point(113, 96);
            this.lblMatheloai.Name = "lblMatheloai";
            this.lblMatheloai.Size = new System.Drawing.Size(69, 15);
            this.lblMatheloai.TabIndex = 22;
            this.lblMatheloai.Text = "Mã thể loại:";
            // 
            // txtMatheloai
            // 
            this.txtMatheloai.Location = new System.Drawing.Point(222, 93);
            this.txtMatheloai.Name = "txtMatheloai";
            this.txtMatheloai.Size = new System.Drawing.Size(290, 23);
            this.txtMatheloai.TabIndex = 21;
            // 
            // lblTheloai
            // 
            this.lblTheloai.AutoSize = true;
            this.lblTheloai.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheloai.Location = new System.Drawing.Point(216, 29);
            this.lblTheloai.Name = "lblTheloai";
            this.lblTheloai.Size = new System.Drawing.Size(234, 31);
            this.lblTheloai.TabIndex = 20;
            this.lblTheloai.Text = "DANH MỤC THỂ LOẠI";
            // 
            // dgridTL
            // 
            this.dgridTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridTL.Location = new System.Drawing.Point(59, 177);
            this.dgridTL.Name = "dgridTL";
            this.dgridTL.RowHeadersWidth = 51;
            this.dgridTL.Size = new System.Drawing.Size(638, 226);
            this.dgridTL.TabIndex = 19;
            this.dgridTL.Click += new System.EventHandler(this.dgridTL_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Image = global::Project.Properties.Resources.pngtree_save_vector_icon_png_image_3758949__2_;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.Location = new System.Drawing.Point(371, 478);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLuu.Size = new System.Drawing.Size(91, 40);
            this.btnLuu.TabIndex = 37;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Image = global::Project.Properties.Resources.images__1___1_;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(258, 478);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnXoa.Size = new System.Drawing.Size(94, 40);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnBoqua
            // 
            this.btnBoqua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBoqua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBoqua.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnBoqua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoqua.Image = global::Project.Properties.Resources._87754cae9952a8f0bd5f0ac47a62854a_t;
            this.btnBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBoqua.Location = new System.Drawing.Point(482, 478);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBoqua.Size = new System.Drawing.Size(97, 40);
            this.btnBoqua.TabIndex = 35;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoqua.UseVisualStyleBackColor = false;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDong.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Image = global::Project.Properties.Resources.pngtree_shutdown_vector_icon_png_image_3722547__1_;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.Location = new System.Drawing.Point(613, 478);
            this.btnDong.Name = "btnDong";
            this.btnDong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDong.Size = new System.Drawing.Size(84, 40);
            this.btnDong.TabIndex = 34;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Image = global::Project.Properties.Resources.images__2___1_;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(148, 478);
            this.btnSua.Name = "btnSua";
            this.btnSua.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSua.Size = new System.Drawing.Size(89, 40);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = global::Project.Properties.Resources.plus_24844_1280__1___2_;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(50, 478);
            this.btnThem.Name = "btnThem";
            this.btnThem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnThem.Size = new System.Drawing.Size(75, 40);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // mnuTheloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 576);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTentheloai);
            this.Controls.Add(this.lblTenLVHD);
            this.Controls.Add(this.lblMatheloai);
            this.Controls.Add(this.txtMatheloai);
            this.Controls.Add(this.lblTheloai);
            this.Controls.Add(this.dgridTL);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "mnuTheloai";
            this.Text = "Thể loại";
            this.Load += new System.EventHandler(this.mnuTheloai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridTL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTentheloai;
        private System.Windows.Forms.Label lblTenLVHD;
        private System.Windows.Forms.Label lblMatheloai;
        private System.Windows.Forms.TextBox txtMatheloai;
        private System.Windows.Forms.Label lblTheloai;
        private System.Windows.Forms.DataGridView dgridTL;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}