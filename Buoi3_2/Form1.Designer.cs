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
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN SINH VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbNhapTT
            // 
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
            this.gbNhapTT.Controls.Add(this.txtNgaySinh);
            this.gbNhapTT.Controls.Add(this.txtHoTen);
            this.gbNhapTT.Controls.Add(this.txtMaSV);
            this.gbNhapTT.Location = new System.Drawing.Point(39, 75);
            this.gbNhapTT.Name = "gbNhapTT";
            this.gbNhapTT.Size = new System.Drawing.Size(329, 339);
            this.gbNhapTT.TabIndex = 1;
            this.gbNhapTT.TabStop = false;
            this.gbNhapTT.Text = "Nhập thông tin";
            this.gbNhapTT.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(233, 194);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(45, 20);
            this.rbNu.TabIndex = 4;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(104, 194);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(57, 20);
            this.rbNam.TabIndex = 4;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // cbMuaSam
            // 
            this.cbMuaSam.AutoSize = true;
            this.cbMuaSam.Location = new System.Drawing.Point(104, 294);
            this.cbMuaSam.Name = "cbMuaSam";
            this.cbMuaSam.Size = new System.Drawing.Size(84, 20);
            this.cbMuaSam.TabIndex = 3;
            this.cbMuaSam.Text = "Mua sắm";
            this.cbMuaSam.UseVisualStyleBackColor = true;
            // 
            // cbDuLich
            // 
            this.cbDuLich.AutoSize = true;
            this.cbDuLich.Location = new System.Drawing.Point(104, 268);
            this.cbDuLich.Name = "cbDuLich";
            this.cbDuLich.Size = new System.Drawing.Size(69, 20);
            this.cbDuLich.TabIndex = 3;
            this.cbDuLich.Text = "Du lịch";
            this.cbDuLich.UseVisualStyleBackColor = true;
            // 
            // cbTheThao
            // 
            this.cbTheThao.AutoSize = true;
            this.cbTheThao.Location = new System.Drawing.Point(104, 242);
            this.cbTheThao.Name = "cbTheThao";
            this.cbTheThao.Size = new System.Drawing.Size(82, 20);
            this.cbTheThao.TabIndex = 3;
            this.cbTheThao.Text = "Thể thao";
            this.cbTheThao.UseVisualStyleBackColor = true;
            // 
            // lblSoThich
            // 
            this.lblSoThich.AutoSize = true;
            this.lblSoThich.Location = new System.Drawing.Point(7, 279);
            this.lblSoThich.Name = "lblSoThich";
            this.lblSoThich.Size = new System.Drawing.Size(54, 16);
            this.lblSoThich.TabIndex = 2;
            this.lblSoThich.Text = "Sở thích";
            this.lblSoThich.Click += new System.EventHandler(this.lblSoThich_Click);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(7, 198);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(54, 16);
            this.lblGioiTinh.TabIndex = 2;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(7, 153);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(67, 16);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(6, 94);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(46, 16);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(7, 38);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(81, 16);
            this.lblMaSV.TabIndex = 2;
            this.lblMaSV.Text = "Mã sinh viên";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(104, 147);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(210, 22);
            this.txtNgaySinh.TabIndex = 1;
            this.txtNgaySinh.Text = "18/08/2003";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(104, 88);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(210, 22);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.Text = "Nguyễn Thiện Nhân";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(104, 33);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(210, 22);
            this.txtMaSV.TabIndex = 0;
            this.txtMaSV.Text = "2121110116";
            this.txtMaSV.TextChanged += new System.EventHandler(this.txtMaSV_TextChanged);
            // 
            // gbChucNang
            // 
            this.gbChucNang.Controls.Add(this.btnThoat);
            this.gbChucNang.Controls.Add(this.btnXoa);
            this.gbChucNang.Controls.Add(this.btnThem);
            this.gbChucNang.Location = new System.Drawing.Point(433, 75);
            this.gbChucNang.Name = "gbChucNang";
            this.gbChucNang.Size = new System.Drawing.Size(355, 76);
            this.gbChucNang.TabIndex = 2;
            this.gbChucNang.TabStop = false;
            this.gbChucNang.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(250, 32);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(157, 32);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa DS";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(19, 33);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 23);
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
            this.gbDanhSach.Location = new System.Drawing.Point(433, 189);
            this.gbDanhSach.Name = "gbDanhSach";
            this.gbDanhSach.Size = new System.Drawing.Size(355, 225);
            this.gbDanhSach.TabIndex = 3;
            this.gbDanhSach.TabStop = false;
            this.gbDanhSach.Text = "Danh sách";
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Location = new System.Drawing.Point(88, 84);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 16);
            this.lblThongBao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // txtDanhSach
            // 
            this.txtDanhSach.Location = new System.Drawing.Point(19, 39);
            this.txtDanhSach.Multiline = true;
            this.txtDanhSach.Name = "txtDanhSach";
            this.txtDanhSach.Size = new System.Drawing.Size(306, 153);
            this.txtDanhSach.TabIndex = 0;
            this.txtDanhSach.TextChanged += new System.EventHandler(this.txtDanhSach_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDanhSach);
            this.Controls.Add(this.gbChucNang);
            this.Controls.Add(this.gbNhapTT);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
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
    }
}

