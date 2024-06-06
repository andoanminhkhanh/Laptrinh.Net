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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTentheloai = new System.Windows.Forms.TextBox();
            this.lblTenLVHD = new System.Windows.Forms.Label();
            this.lblMatheloai = new System.Windows.Forms.Label();
            this.txtMatheloai = new System.Windows.Forms.TextBox();
            this.lblTheloai = new System.Windows.Forms.Label();
            this.dgridTL = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgridTL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(535, 421);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(61, 33);
            this.btnDong.TabIndex = 30;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click_1);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(440, 421);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(61, 33);
            this.btnBoqua.TabIndex = 29;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(345, 421);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(61, 33);
            this.btnLuu.TabIndex = 28;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(251, 421);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 33);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(157, 421);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(61, 33);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(59, 421);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(61, 33);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
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
            this.dgridTL.Size = new System.Drawing.Size(537, 226);
            this.dgridTL.TabIndex = 19;
            this.dgridTL.Click += new System.EventHandler(this.dgridTL_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mnuTheloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
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

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTentheloai;
        private System.Windows.Forms.Label lblTenLVHD;
        private System.Windows.Forms.Label lblMatheloai;
        private System.Windows.Forms.TextBox txtMatheloai;
        private System.Windows.Forms.Label lblTheloai;
        private System.Windows.Forms.DataGridView dgridTL;
        private System.Windows.Forms.Button button1;
    }
}