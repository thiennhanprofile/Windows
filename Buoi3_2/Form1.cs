using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_2
{
    public partial class Form1 : Form
    {
        private string stt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Ho ten sinh vien khong de trong !");
                }
                //Lay thong tin
                string hoten = txtHoTen.Text;
                string masv = txtMaSV.Text;
                string ngaysinh = txtNgaySinh.Text;
                string gioitinh =(rbNam.Checked) ? "Nam": "Nu";
                string sothich = null;
                if (cbDuLich.Checked)
                {
                    sothich += "Du lich";
                }
                if (cbTheThao.Checked)
                {
                    sothich += "The thao";
                }
                if (cbMuaSam.Checked)
                {
                    sothich += "Mua sam";
                }
                if (sothich != null)
                {
                    sothich = "So thich:" + sothich;
                }
                //Xuat thong tin
                txtDanhSach.Text += stt + "Ho ten: " + hoten + "\tNgay sinh :" + ngaysinh + "\tGioi tinh: " + gioitinh +"\t"+ sothich + "\r\n";
                //stt++;
            }
            catch(Exception ex)
            {
                lblThongBao.Text = ex.Message;
            }
        }

        private void txtDanhSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtDanhSach.Text="";
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

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

        private void lblSoThich_Click(object sender, EventArgs e)
        {

        }
    }
}
