using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadListView();
        }
        void LoadListView()
        {




            ListViewItem item1 = new ListViewItem();
            item1.Text = "1";
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Cafe Sữa" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "20000" });

            ListViewItem item2 = new ListViewItem();
            item2.Text = "2";
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Cafe Đen" });
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "18000" });
            ListViewItem item3 = new ListViewItem();

            item3.Text = "3";
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Bạc Xỉu" });
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "23000" });



            lvDSM.Items.Add(item1);
            lvDSM.Items.Add(item2);
            lvDSM.Items.Add(item3);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ban = cbBan.SelectedItem.ToString();
            string tenmon = lvDSM.SelectedItems.ToString();
            string soluong = lvDSM.SelectedItems.ToString();
            string gia = lvDSM.SelectedItems.ToString();


            ListViewItem item = new ListViewItem(ban);
            item.SubItems.Add(tenmon);
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = soluong });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = gia });

            lvDSDM.Items.Add(item);


        }
    }
}
