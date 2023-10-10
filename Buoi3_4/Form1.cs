using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_4
{
    public partial class Form1 : Form
    {
        private int chon;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbSinhVien.Items.Add("Nguyễn Thiện Nhân");
            lbSinhVien.Items.Add("Nguyễn Minh Lâm");
            lbSinhVien.Items.Add("Nguyễn Vă Chính");
            lbSinhVien.Items.Add("Nguyễn Hữu Danh");
            lbSinhVien.Items.Add("Nguyễn Văn En");
            cbKhoa.SelectedIndex = 0;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHoTen.Text.Length.Equals(0))
                {
                    throw new Exception("Vui lòng nhập họ tên !");

                }
                string hoten = txtHoTen.Text;
                lbSinhVien.Items.Add(hoten);
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChonSV_Click(object sender, EventArgs e)
        {
            if(chon !=1)
            {
                string hoten = lbSinhVien.SelectedItems.ToString();
                string khoa= cbKhoa.SelectedItem.ToString();

                ListViewItem item= new ListViewItem(hoten);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = khoa });
                LvLop.Items.Add(item);
                lbSinhVien.Items.RemoveAt(lbSinhVien.SelectedIndex);
                chon = -1;
            }
        }

        private void btnThemAll_Click(object sender, EventArgs e)
        {
            int count = lbSinhVien.Items.Count;
            for (int vt=0; vt<count; vt++)
            {
                string khoa = cbKhoa.SelectedItem.ToString() ;
                string hoten = lbSinhVien.Items[vt].ToString();
                ListViewItem item= new ListViewItem(hoten) ;
                item.SubItems.Add (new ListViewItem.ListViewSubItem() { Text = khoa});
                LvLop.Items.Add(item);
            }
            lbSinhVien.Items.Clear();
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in LvLop.Items)
            {
                if (item.Selected)

                {
                    LvLop.Items.Remove(item);
                    lbSinhVien.Items.Add(item.Text);
                }    
            }    
        }

        private void btnXoaAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in LvLop.Items)
            {
                {
                    LvLop.Items.Remove(item);
                    lbSinhVien.Items.Add(item.Text);
                }
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

        private void LvLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    
