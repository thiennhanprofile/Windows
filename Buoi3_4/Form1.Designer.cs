﻿namespace Buoi3_4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbSinhVien = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoaAll = new System.Windows.Forms.Button();
            this.btnThemAll = new System.Windows.Forms.Button();
            this.btnXoaSV = new System.Windows.Forms.Button();
            this.btnChonSV = new System.Windows.Forms.Button();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LvLop = new System.Windows.Forms.ListView();
            this.hoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.khoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1033, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm Sinh Viên";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(688, 33);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 50);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(877, 33);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 50);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(141, 44);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(368, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbSinhVien);
            this.groupBox2.Location = new System.Drawing.Point(17, 148);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(295, 366);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
            // 
            // lbSinhVien
            // 
            this.lbSinhVien.FormattingEnabled = true;
            this.lbSinhVien.ItemHeight = 16;
            this.lbSinhVien.Location = new System.Drawing.Point(8, 25);
            this.lbSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.lbSinhVien.Name = "lbSinhVien";
            this.lbSinhVien.Size = new System.Drawing.Size(277, 324);
            this.lbSinhVien.TabIndex = 0;
            this.lbSinhVien.Click += new System.EventHandler(this.lbSinhVien_Click);
            this.lbSinhVien.SelectedIndexChanged += new System.EventHandler(this.lbSinhVien_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoaAll);
            this.groupBox3.Controls.Add(this.btnThemAll);
            this.groupBox3.Controls.Add(this.btnXoaSV);
            this.groupBox3.Controls.Add(this.btnChonSV);
            this.groupBox3.Controls.Add(this.cbKhoa);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(320, 148);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(259, 366);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnXoaAll
            // 
            this.btnXoaAll.Location = new System.Drawing.Point(51, 262);
            this.btnXoaAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaAll.Name = "btnXoaAll";
            this.btnXoaAll.Size = new System.Drawing.Size(157, 28);
            this.btnXoaAll.TabIndex = 2;
            this.btnXoaAll.Text = "<<";
            this.btnXoaAll.UseVisualStyleBackColor = true;
            this.btnXoaAll.Click += new System.EventHandler(this.btnXoaAll_Click);
            // 
            // btnThemAll
            // 
            this.btnThemAll.Location = new System.Drawing.Point(51, 150);
            this.btnThemAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemAll.Name = "btnThemAll";
            this.btnThemAll.Size = new System.Drawing.Size(157, 28);
            this.btnThemAll.TabIndex = 2;
            this.btnThemAll.Text = ">>";
            this.btnThemAll.UseVisualStyleBackColor = true;
            this.btnThemAll.Click += new System.EventHandler(this.btnThemAll_Click);
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Location = new System.Drawing.Point(51, 206);
            this.btnXoaSV.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(157, 28);
            this.btnXoaSV.TabIndex = 2;
            this.btnXoaSV.Text = "<";
            this.btnXoaSV.UseVisualStyleBackColor = true;
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);
            // 
            // btnChonSV
            // 
            this.btnChonSV.Location = new System.Drawing.Point(51, 94);
            this.btnChonSV.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonSV.Name = "btnChonSV";
            this.btnChonSV.Size = new System.Drawing.Size(157, 28);
            this.btnChonSV.TabIndex = 2;
            this.btnChonSV.Text = ">";
            this.btnChonSV.UseVisualStyleBackColor = true;
            this.btnChonSV.Click += new System.EventHandler(this.btnChonSV_Click);
            // 
            // cbKhoa
            // 
            this.cbKhoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbKhoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Cơ Khí",
            "Quản trị kinh doanh",
            "Nhà hàng khách sạn",
            "Kế toán"});
            this.cbKhoa.Location = new System.Drawing.Point(13, 46);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(236, 24);
            this.cbKhoa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khoa";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LvLop);
            this.groupBox4.Location = new System.Drawing.Point(587, 148);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(464, 366);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sinh viên được chọn";
            // 
            // LvLop
            // 
            this.LvLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hoten,
            this.khoa});
            this.LvLop.HideSelection = false;
            this.LvLop.Location = new System.Drawing.Point(9, 25);
            this.LvLop.Margin = new System.Windows.Forms.Padding(4);
            this.LvLop.Name = "LvLop";
            this.LvLop.Size = new System.Drawing.Size(445, 324);
            this.LvLop.TabIndex = 0;
            this.LvLop.UseCompatibleStateImageBehavior = false;
            this.LvLop.View = System.Windows.Forms.View.Details;
            this.LvLop.SelectedIndexChanged += new System.EventHandler(this.LvLop_SelectedIndexChanged);
            // 
            // hoten
            // 
            this.hoten.Text = "Họ tên";
            this.hoten.Width = 138;
            // 
            // khoa
            // 
            this.khoa.Text = "Khoa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "THÊM SINH VIÊN VÀO LỚP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbSinhVien;
        private System.Windows.Forms.Button btnXoaAll;
        private System.Windows.Forms.Button btnThemAll;
        private System.Windows.Forms.Button btnXoaSV;
        private System.Windows.Forms.Button btnChonSV;
        private System.Windows.Forms.ListView LvLop;
        private System.Windows.Forms.ColumnHeader hoten;
        private System.Windows.Forms.ColumnHeader khoa;
    }
}

