namespace Project.Forms
{
    partial class Phongban
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.txttenphong = new System.Windows.Forms.TextBox();
            this.cbomabao = new System.Windows.Forms.ComboBox();
            this.mskdienthoai = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(634, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHÒNG BAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(52, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(453, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điện thoại";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(453, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã báo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(52, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên phòng";
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(179, 40);
            this.txtmaphong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(202, 32);
            this.txtmaphong.TabIndex = 5;
            // 
            // txttenphong
            // 
            this.txttenphong.Location = new System.Drawing.Point(179, 107);
            this.txttenphong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Size = new System.Drawing.Size(202, 32);
            this.txttenphong.TabIndex = 6;
            // 
            // cbomabao
            // 
            this.cbomabao.FormattingEnabled = true;
            this.cbomabao.Location = new System.Drawing.Point(585, 38);
            this.cbomabao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbomabao.Name = "cbomabao";
            this.cbomabao.Size = new System.Drawing.Size(200, 34);
            this.cbomabao.TabIndex = 7;
            // 
            // mskdienthoai
            // 
            this.mskdienthoai.Location = new System.Drawing.Point(585, 107);
            this.mskdienthoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskdienthoai.Mask = "(999) 000-0000";
            this.mskdienthoai.Name = "mskdienthoai";
            this.mskdienthoai.Size = new System.Drawing.Size(200, 32);
            this.mskdienthoai.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmaphong);
            this.groupBox1.Controls.Add(this.txttenphong);
            this.groupBox1.Controls.Add(this.cbomabao);
            this.groupBox1.Controls.Add(this.mskdienthoai);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(338, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(836, 160);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phòng ban";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(191, 309);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(1141, 344);
            this.DataGridView.TabIndex = 10;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
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
            this.btnthoat.Location = new System.Drawing.Point(1084, 709);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnthoat.Size = new System.Drawing.Size(90, 44);
            this.btnthoat.TabIndex = 36;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click_1);
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
            this.btnluu.Location = new System.Drawing.Point(784, 709);
            this.btnluu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnluu.Name = "btnluu";
            this.btnluu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnluu.Size = new System.Drawing.Size(90, 44);
            this.btnluu.TabIndex = 35;
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
            this.btnxoa.Location = new System.Drawing.Point(480, 709);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnxoa.Size = new System.Drawing.Size(90, 44);
            this.btnxoa.TabIndex = 34;
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
            this.btnboqua.Location = new System.Drawing.Point(923, 709);
            this.btnboqua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnboqua.Size = new System.Drawing.Size(105, 44);
            this.btnboqua.TabIndex = 33;
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
            this.btnsua.Location = new System.Drawing.Point(628, 709);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnsua.Size = new System.Drawing.Size(90, 44);
            this.btnsua.TabIndex = 31;
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
            this.btnthem.Location = new System.Drawing.Point(338, 709);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnthem.Size = new System.Drawing.Size(90, 44);
            this.btnthem.TabIndex = 30;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // Phongban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1155, 817);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Phongban";
            this.Text = "Phongban";
            this.Load += new System.EventHandler(this.Phongban_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.TextBox txttenphong;
        private System.Windows.Forms.ComboBox cbomabao;
        private System.Windows.Forms.MaskedTextBox mskdienthoai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
    }
}