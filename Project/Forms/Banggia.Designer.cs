﻿namespace Project.Forms
{
    partial class Banggia
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbomabao = new System.Windows.Forms.ComboBox();
            this.cbomaqc = new System.Windows.Forms.ComboBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG GIÁ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã QC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã báo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đơn giá";
            // 
            // cbomabao
            // 
            this.cbomabao.FormattingEnabled = true;
            this.cbomabao.Location = new System.Drawing.Point(116, 40);
            this.cbomabao.Name = "cbomabao";
            this.cbomabao.Size = new System.Drawing.Size(323, 28);
            this.cbomabao.TabIndex = 5;
            // 
            // cbomaqc
            // 
            this.cbomaqc.FormattingEnabled = true;
            this.cbomaqc.Location = new System.Drawing.Point(116, 99);
            this.cbomaqc.Name = "cbomaqc";
            this.cbomaqc.Size = new System.Drawing.Size(323, 28);
            this.cbomaqc.TabIndex = 6;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(116, 161);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(323, 27);
            this.txtdongia.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbomabao);
            this.groupBox1.Controls.Add(this.cbomaqc);
            this.groupBox1.Controls.Add(this.txtdongia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(156, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 220);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TT Bảng giá";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(97, 318);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(641, 172);
            this.DataGridView.TabIndex = 9;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Image = global::Project.Properties.Resources.pngtree_shutdown_vector_icon_png_image_3722547__1_1;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.Location = new System.Drawing.Point(747, 574);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnthoat.Size = new System.Drawing.Size(75, 40);
            this.btnthoat.TabIndex = 36;
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
            this.btnluu.Image = global::Project.Properties.Resources.pngtree_save_vector_icon_png_image_3758949__2_;
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluu.Location = new System.Drawing.Point(472, 574);
            this.btnluu.Name = "btnluu";
            this.btnluu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnluu.Size = new System.Drawing.Size(75, 40);
            this.btnluu.TabIndex = 35;
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
            this.btnxoa.Image = global::Project.Properties.Resources.images__1___1_;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.Location = new System.Drawing.Point(188, 574);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnxoa.Size = new System.Drawing.Size(75, 40);
            this.btnxoa.TabIndex = 34;
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
            this.btnboqua.Image = global::Project.Properties.Resources._87754cae9952a8f0bd5f0ac47a62854a_t;
            this.btnboqua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnboqua.Location = new System.Drawing.Point(608, 574);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnboqua.Size = new System.Drawing.Size(75, 40);
            this.btnboqua.TabIndex = 33;
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
            this.btnsua.Image = global::Project.Properties.Resources.images__2___1_;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.Location = new System.Drawing.Point(337, 574);
            this.btnsua.Name = "btnsua";
            this.btnsua.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnsua.Size = new System.Drawing.Size(75, 40);
            this.btnsua.TabIndex = 31;
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
            this.btnthem.Image = global::Project.Properties.Resources.plus_24844_1280__1___2_;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.Location = new System.Drawing.Point(43, 574);
            this.btnthem.Name = "btnthem";
            this.btnthem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnthem.Size = new System.Drawing.Size(75, 40);
            this.btnthem.TabIndex = 30;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.UseVisualStyleBackColor = false;
            // 
            // Banggia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 744);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Banggia";
            this.Text = "Banggia";
            this.Load += new System.EventHandler(this.Banggia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbomabao;
        private System.Windows.Forms.ComboBox cbomaqc;
        private System.Windows.Forms.TextBox txtdongia;
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