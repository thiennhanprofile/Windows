using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_1
{
    public partial class Form1 : Form
    {
        string[] dansachkhoa = { "CNTT", "QTKD", "Kế Toán", "Ngoại Ngữ", };
        private int rowchoose;
        private DataGridView dgvDanhSach;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.MaxDate = DateTime.Now;
            loadKhoa();
        }
        private void loadKhoa()
        { 
            cbKhoa.DataSource = dansachkhoa;
            cbKhoa.SelectedItem = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSV.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên phải đúng 10 ký tự");
                }
                if (txtHoTen.Text.Length < 2)
                { throw new Exception("Họ tên sinh vien ít nhất 2 ký tự"); }
                //Lấy thong tin
                string masv = txtMaSV.Text;
                string hoten = txtHoTen.Text;
                string ngaysinh = dtpNgaySinh.Text;
                string khoa = cbKhoa.Text;
                //Lưu dữ liệu vào lưới
                int rowindex = dgvDanhSach1.Rows.Add(); //Add tạo mới 1 Hang, tra ve vị trí them
                dgvDanhSach1.Rows[rowindex].Cells["MaSV"].Value = masv;
                dgvDanhSach1.Rows[rowindex].Cells["HoTen"].Value = hoten;
                dgvDanhSach1.Rows[rowindex].Cells["NgaySinh"].Value = ngaysinh;
                dgvDanhSach1.Rows[rowindex].Cells["Khoa"].Value = khoa;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn thoát không?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowchoose == -1 || rowchoose >= dgvDanhSach1.Rows.Count - 1)
                {
                    throw new Exception("Chưa chon sinh vien can cap nhật");
                }
                if (txtMaSV.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên phải đúng 10 ký tự");
                }
                if (txtHoTen.Text.Length < 2)
                {
                    throw new Exception("Ho ten sinh vien ít nhất 2 ký tự");
                }

                //Lấy thông tin
                string masv = txtMaSV.Text;
                string hoten = txtHoTen.Text;
                string ngaysinh = dtpNgaySinh.Text;
                string khoa = cbKhoa.Text;
                //Lưu dữ liệu vào lưới
                dgvDanhSach1.Rows[rowchoose].Cells["MaSV"].Value = masv;
                dgvDanhSach1.Rows[rowchoose].Cells["HoTen"].Value = hoten;
                dgvDanhSach1.Rows[rowchoose].Cells["NgaySinh"].Value = ngaysinh;
                dgvDanhSach1.Rows[rowchoose].Cells["Khoa"].Value = khoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowchoose == -1 || rowchoose >= dgvDanhSach1.Rows.Count - 1)
                {
                    throw new Exception("Chua chon sinh vien can cap nhật");
                }
                dgvDanhSach1.Rows.RemoveAt(rowchoose);
                rowchoose = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dgvDanhSach1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 || e.RowIndex < dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chon sinh viên");
                }
                rowchoose = e.RowIndex;
                txtMaSV.Text = dgvDanhSach.Rows[rowchoose].Cells["MaSV"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[rowchoose].Cells["HoTen"].Value.ToString();
                dtpNgaySinh.Text = dgvDanhSach.Rows[rowchoose].Cells["NgaySinh"].Value.ToString();
                cbKhoa.Text = dgvDanhSach.Rows[rowchoose].Cells["Khoa"].Value.ToString();
                btnCapNhap.Enabled = true;
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}