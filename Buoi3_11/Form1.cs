using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void lblSoA_Click(object sender, EventArgs e)
        {

        }
        private void lblSoB_Click(object sender, EventArgs e)
        {

        }



        private void txtSoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKetQua_Click(object sender, EventArgs e)
        {

        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtSoA.Text,out a))
                {
                    throw new Exception("So A khong duoc de trong hoac phai la so !"); 
                }
                if (!double.TryParse(txtSoB.Text, out b))
                {
                    throw new Exception("So B khong duoc de trong hoac phai la so !");
                }
                txtKetQua.Text = (a + b).ToString();
            }
            catch (Exception ex)
            {
                txtKetQua.Text=ex.Message;
            }

        }
        private void btnTru_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    double a, b;
                    if (!double.TryParse(txtSoA.Text, out a))
                    {
                        throw new Exception("So A khong duoc de trong hoac phai la so !");
                    }
                    if (!double.TryParse(txtSoB.Text, out b))
                    {
                        throw new Exception("So B khong duoc de trong hoac phai la so !");
                    }
                    txtKetQua.Text = (a - b).ToString();
                }
                catch (Exception ex)
                {
                    txtKetQua.Text = ex.Message;
                }

            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    double a, b;
                    if (!double.TryParse(txtSoA.Text, out a))
                    {
                        throw new Exception("So A khong duoc de trong hoac phai la so !");
                    }
                    if (!double.TryParse(txtSoB.Text, out b))
                    {
                        throw new Exception("So B khong duoc de trong hoac phai la so !");
                    }
                    txtKetQua.Text = (a * b).ToString();
                }
                catch (Exception ex)
                {
                    txtKetQua.Text = ex.Message;
                }

            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    double a, b;
                    if (!double.TryParse(txtSoA.Text, out a))
                    {
                        throw new Exception("So A khong duoc de trong hoac phai la so !");
                    }
                    if (!double.TryParse(txtSoB.Text, out b))
                    {
                        throw new Exception("So B khong duoc de trong hoac phai la so !");
                    }
                    txtKetQua.Text = (a / b).ToString();
                }
                catch (Exception ex)
                {
                    txtKetQua.Text = ex.Message;
                }

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
