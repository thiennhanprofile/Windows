using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SinhVienDAO svDAO = new SinhVienDAO();
        KhoaDAO khDAO = new KhoaDAO();
        //Khai bao co hieu them va cap nhật
        string insertupdate = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaSV.Enabled = false;
            btnXoa.Enabled = false;
            loadDSSinhVien();
            loadDSKhoa();
            TongSinhVien();
        }
        private void loadDSSinhVien()
        { dgvDanhSach.DataSource = svDAO.getList(); }
        private void loadDSKhoa()
        {
            cbKhoa.DataSource = khDAO.getList();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }
        private void TongSinhVien()
        { txtTongSV.Text = svDAO.getCount().ToString(); }

        private void bthThem_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnLuu.Enabled = true;
            txtMaSV.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            txtMaSV.Enabled = false;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chon sinh vien");
                }
                txtMaSV.Text = dgvDanhSach.Rows[rowindex].Cells["MaSV"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[rowindex].Cells["HoTen"].Value.ToString();
                cbKhoa.Text = dgvDanhSach.Rows[rowindex].Cells["TenKhoa"].Value.ToString();
                txtDiemTB.Text = dgvDanhSach.Rows[rowindex].Cells["DiemTB"].Value.ToString();
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                double diemtb = 0;
                if (txtMaSV.Text.Length != 10)
                {
                    throw new Exception("Ma sinh vien 10 ký tự so");
                }
                if (!double.TryParse(txtDiemTB.Text, out diemtb))
                {
                    throw new Exception("Diem sinh vien so");
                }
                string masv = txtMaSV.Text;
                string hoten = txtHoTen.Text;
                int makhoa = int.Parse(cbKhoa.SelectedValue.ToString());
                SinhVien sv = new SinhVien(masv, hoten, makhoa, diemtb);
                switch (insertupdate)
                {
                    case "insert":
                        svDAO.InsertTwo(sv);
                        loadDSSinhVien();
                        TongSinhVien();
                        MessageBox.Show("Them thanh cong", "Thong bao");
                        break;
                    case "update":
                        svDAO.UpdateTwo(sv);
                        loadDSSinhVien();
                        TongSinhVien();
                        MessageBox.Show("Cap nhat thanh cong", "Thong bao");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSV.Text.Length != 10)
                { throw new Exception("Ma sinh vien khong đung"); }
                string masv = txtMaSV.Text;
                svDAO.DeleteTwo(masv);
                loadDSSinhVien();
                TongSinhVien();
                MessageBox.Show("Xoa thanh cong", "Thong bao");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            int makhoa = int.Parse(cbKhoa.SelectedValue.ToString());
            dgvDanhSach.DataSource = svDAO.getList(makhoa);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban muon thoat khong?", "Thong bao",
MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            {
                DialogResult result = MessageBox.Show("Ban muon thoat khong?", "Thong bao",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
    
