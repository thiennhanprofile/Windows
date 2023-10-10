namespace Buoi3_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbNhapTT = new System.Windows.Forms.GroupBox();
            this.txtNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.txtMaSV = new System.Windows.Forms.MaskedTextBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.cbMuaSam = new System.Windows.Forms.CheckBox();
            this.cbDuLich = new System.Windows.Forms.CheckBox();
            this.cbTheThao = new System.Windows.Forms.CheckBox();
            this.lblSoThich = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.gbChucNang = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gbDanhSach = new System.Windows.Forms.GroupBox();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDanhSach = new System.Windows.Forms.TextBox();
            this.gbNhapTT.SuspendLayout();
            this.gbChucNang.SuspendLayout();
            this.gbDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(213, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN SINH VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbNhapTT
            // 
            this.gbNhapTT.Controls.Add(this.txtNgaySinh);
            this.gbNhapTT.Controls.Add(this.txtMaSV);
            this.gbNhapTT.Controls.Add(this.rbNu);
            this.gbNhapTT.Controls.Add(this.rbNam);
            this.gbNhapTT.Controls.Add(this.cbMuaSam);
            this.gbNhapTT.Controls.Add(this.cbDuLich);
            this.gbNhapTT.Controls.Add(this.cbTheThao);
            this.gbNhapTT.Controls.Add(this.lblSoThich);
            this.gbNhapTT.Controls.Add(this.lblGioiTinh);
            this.gbNhapTT.Controls.Add(this.lblNgaySinh);
            this.gbNhapTT.Controls.Add(this.lblHoTen);
            this.gbNhapTT.Controls.Add(this.lblMaSV);
            this.gbNhapTT.Controls.Add(this.txtHoTen);
            this.gbNhapTT.Location = new System.Drawing.Point(29, 61);
            this.gbNhapTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbNhapTT.Name = "gbNhapTT";
            this.gbNhapTT.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbNhapTT.Size = new System.Drawing.Size(247, 275);
            this.gbNhapTT.TabIndex = 1;
            this.gbNhapTT.TabStop = false;
            this.gbNhapTT.Text = "Nhập thông tin";
            this.gbNhapTT.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(78, 119);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNgaySinh.Mask = "00/00/0000";
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(69, 20);
            this.txtNgaySinh.TabIndex = 5;
            this.txtNgaySinh.ValidatingType = typeof(System.DateTime);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(78, 26);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaSV.Mask = "2100000000";
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(158, 20);
            this.txtMaSV.TabIndex = 10;
            this.txtMaSV.ValidatingType = typeof(int);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(175, 158);
            this.rbNu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 4;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(78, 158);
            this.rbNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 4;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // cbMuaSam
            // 
            this.cbMuaSam.AutoSize = true;
            this.cbMuaSam.Location = new System.Drawing.Point(78, 239);
            this.cbMuaSam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMuaSam.Name = "cbMuaSam";
            this.cbMuaSam.Size = new System.Drawing.Size(69, 17);
            this.cbMuaSam.TabIndex = 3;
            this.cbMuaSam.Text = "Mua sắm";
            this.cbMuaSam.UseVisualStyleBackColor = true;
            // 
            // cbDuLich
            // 
            this.cbDuLich.AutoSize = true;
            this.cbDuLich.Location = new System.Drawing.Point(78, 218);
            this.cbDuLich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDuLich.Name = "cbDuLich";
            this.cbDuLich.Size = new System.Drawing.Size(59, 17);
            this.cbDuLich.TabIndex = 3;
            this.cbDuLich.Text = "Du lịch";
            this.cbDuLich.UseVisualStyleBackColor = true;
            // 
            // cbTheThao
            // 
            this.cbTheThao.AutoSize = true;
            this.cbTheThao.Location = new System.Drawing.Point(78, 197);
            this.cbTheThao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTheThao.Name = "cbTheThao";
            this.cbTheThao.Size = new System.Drawing.Size(69, 17);
            this.cbTheThao.TabIndex = 3;
            this.cbTheThao.Text = "Thể thao";
            this.cbTheThao.UseVisualStyleBackColor = true;
            // 
            // lblSoThich
            // 
            this.lblSoThich.AutoSize = true;
            this.lblSoThich.Location = new System.Drawing.Point(5, 227);
            this.lblSoThich.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoThich.Name = "lblSoThich";
            this.lblSoThich.Size = new System.Drawing.Size(48, 13);
            this.lblSoThich.TabIndex = 2;
            this.lblSoThich.Text = "Sở thích";
            this.lblSoThich.Click += new System.EventHandler(this.lblSoThich_Click);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(5, 161);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(47, 13);
            this.lblGioiTinh.TabIndex = 2;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(5, 124);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(54, 13);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(4, 76);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(39, 13);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(5, 31);
            this.lblMaSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(67, 13);
            this.lblMaSV.TabIndex = 2;
            this.lblMaSV.Text = "Mã sinh viên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(78, 72);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(158, 20);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.Text = "Nguyễn Thiện Nhân";
            // 
            // gbChucNang
            // 
            this.gbChucNang.Controls.Add(this.btnThoat);
            this.gbChucNang.Controls.Add(this.btnXoa);
            this.gbChucNang.Controls.Add(this.btnThem);
            this.gbChucNang.Location = new System.Drawing.Point(325, 61);
            this.gbChucNang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbChucNang.Name = "gbChucNang";
            this.gbChucNang.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbChucNang.Size = new System.Drawing.Size(266, 62);
            this.gbChucNang.TabIndex = 2;
            this.gbChucNang.TabStop = false;
            this.gbChucNang.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(188, 26);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(56, 19);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(118, 26);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(56, 19);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa DS";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(14, 27);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 19);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm vào DS";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gbDanhSach
            // 
            this.gbDanhSach.AccessibleName = "";
            this.gbDanhSach.Controls.Add(this.lblThongBao);
            this.gbDanhSach.Controls.Add(this.label2);
            this.gbDanhSach.Controls.Add(this.txtDanhSach);
            this.gbDanhSach.Location = new System.Drawing.Point(325, 154);
            this.gbDanhSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDanhSach.Name = "gbDanhSach";
            this.gbDanhSach.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDanhSach.Size = new System.Drawing.Size(266, 183);
            this.gbDanhSach.TabIndex = 3;
            this.gbDanhSach.TabStop = false;
            this.gbDanhSach.Text = "Danh sách";
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Location = new System.Drawing.Point(66, 68);
            this.lblThongBao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 13);
            this.lblThongBao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // txtDanhSach
            // 
            this.txtDanhSach.Location = new System.Drawing.Point(14, 32);
            this.txtDanhSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDanhSach.Multiline = true;
            this.txtDanhSach.Name = "txtDanhSach";
            this.txtDanhSach.Size = new System.Drawing.Size(230, 125);
            this.txtDanhSach.TabIndex = 0;
            this.txtDanhSach.TextChanged += new System.EventHandler(this.txtDanhSach_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.gbDanhSach);
            this.Controls.Add(this.gbChucNang);
            this.Controls.Add(this.gbNhapTT);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbNhapTT.ResumeLayout(false);
            this.gbNhapTT.PerformLayout();
            this.gbChucNang.ResumeLayout(false);
            this.gbDanhSach.ResumeLayout(false);
            this.gbDanhSach.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbNhapTT;
        private System.Windows.Forms.GroupBox gbChucNang;
        private System.Windows.Forms.GroupBox gbDanhSach;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.CheckBox cbMuaSam;
        private System.Windows.Forms.CheckBox cbDuLich;
        private System.Windows.Forms.CheckBox cbTheThao;
        private System.Windows.Forms.Label lblSoThich;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtDanhSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.MaskedTextBox txtNgaySinh;
        private System.Windows.Forms.MaskedTextBox txtMaSV;
    }
}

