using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai5_3
{
    public partial class Form1 : Form
    {
        int rowindex = -1;
        String[] listsanpham = { "Áo Nam", "Áo nữ", "Áo cặp đôi", "Áo gió" };
        String[] listdonvitinh = { "Cái", "Cặp" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbLoaiSP.DataSource = listsanpham;
            cbDonViTinh.DataSource = listdonvitinh;

        }

        private void btnThoat_Click(object sender, EventArgs e)
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            double soluong, gia;
            try
            {
                if (!txtMaSP.Text.Length.Equals(3))
                {
                    throw new Exception("Mã san pham khong duoc de trong");
                }
                if (this.checkMaSP(txtMaSP.Text) == false)
                {
                    throw new Exception("Mã sản phẩm đã tồn tại");
                }
                if (txtTenSP.Text.Length.Equals(0))
                {
                    throw new Exception("Tên sản phẩm khong được đe trong");
                }

                if (!double.TryParse(txtSoLuong.Text, out soluong))
                {
                    throw new Exception("So luong khong phải số");
                }
                if (!double.TryParse(txtGia.Text, out gia))
                {
                    throw new Exception("Gia khong phải số");
                }
                string masp = txtMaSP.Text;
                string tensp = txtTenSP.Text;
                string donvitinh = cbDonViTinh.Text;
                string loaisp = cbLoaiSP.Text;

                double thanhtien = (double)soluong * (double)gia;



                int row = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[row].Cells["MaSP"].Value = masp;
                dgvDanhSach.Rows[row].Cells["TenSP"].Value = tensp;
                dgvDanhSach.Rows[row].Cells["LoaiSP"].Value = loaisp;
                dgvDanhSach.Rows[row].Cells["SoLuong"].Value = soluong;
                dgvDanhSach.Rows[row].Cells["Gia"].Value = gia;
                dgvDanhSach.Rows[row].Cells["ThanhTien"].Value = thanhtien;
                dgvDanhSach.Rows[row].Cells["DonViTinh"].Value = donvitinh;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông bao");
            }

        }
        public bool checkMaSP(string masv)
        {
            if (dgvDanhSach.Rows.Count == 0)
            {
                return true;
            }
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaSP"].Value.ToString() == masv)
                {
                    return false;
                }
            }
            return true;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if (rowindex != -1 && rowindex < dgvDanhSach.Rows.Count - 1)
            {
                txtMaSP.Text = dgvDanhSach.Rows[rowindex].Cells["MaSP"].Value.ToString();
                txtTenSP.Text = dgvDanhSach.Rows[rowindex].Cells["TenSP"].Value.ToString();
                txtSoLuong.Text = dgvDanhSach.Rows[rowindex].Cells["Soluong"].Value.ToString();
                txtGia.Text = dgvDanhSach.Rows[rowindex].Cells["Gia"].Value.ToString();



                string loaisp = dgvDanhSach.Rows[rowindex].Cells["loaiSP"].Value.ToString();
                int i = 0;
                while (i < listsanpham.Length && listsanpham[i] != loaisp)
                {
                    i++;

                }
                cbLoaiSP.SelectedIndex = i;

                string donvitinh = dgvDanhSach.Rows[rowindex].Cells["DonViTinh"].Value.ToString();
                int a = 0;
                while (i < listdonvitinh.Length && listdonvitinh[a] != donvitinh)
                {
                    a++;
                }
                cbDonViTinh.SelectedIndex = a;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            double soluong, gia;
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chua chon sinh vien can sua!");
                }
                if (!txtMaSP.Text.Length.Equals(3))
                {
                    throw new Exception("Ma san pham khong duoc de trong");
                }
                if (this.checkMaSP(txtMaSP.Text) == false && txtMaSP.Text != dgvDanhSach.Rows[rowindex].Cells["MaSP"].Value.ToString())
                {
                    throw new Exception("Mã san pham da ton tai");
                }
                if (txtTenSP.Text.Length.Equals(0))
                {
                    throw new Exception("Ten san pham  khong dược đe trong");
                }
                if (!double.TryParse(txtSoLuong.Text, out soluong))
                {
                    throw new Exception("So luong khong phải số");
                }
                if (!double.TryParse(txtGia.Text, out gia))
                {
                    throw new Exception("Gia khong phải số");
                }

                string masp = txtMaSP.Text;
                string tensp = txtTenSP.Text;
                string donvitinh = cbDonViTinh.Text;
                string loaisp = cbLoaiSP.Text;
                double thanhtien = (double)soluong * (double)gia;



                dgvDanhSach.Rows[rowindex].Cells["MaSP"].Value = masp;
                dgvDanhSach.Rows[rowindex].Cells["TenSP"].Value = tensp;
                dgvDanhSach.Rows[rowindex].Cells["LoaiSP"].Value = loaisp;
                dgvDanhSach.Rows[rowindex].Cells["SoLuong"].Value = soluong;
                dgvDanhSach.Rows[rowindex].Cells["Gia"].Value = gia;
                dgvDanhSach.Rows[rowindex].Cells["ThanhTien"].Value = thanhtien;
                dgvDanhSach.Rows[rowindex].Cells["DonViTinh"].Value = donvitinh;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chon sinh vien can xóa!");
                }
                dgvDanhSach.Rows.RemoveAt(rowindex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông bao");
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {


            string selectedValue = cbLoaiSP.SelectedItem.ToString();

            DataView dv = new DataView(dgvDanhSach.DataSource as DataTable);
            dv.RowFilter = $"LoaiSP = '{selectedValue}'";


        }

    }
    }
