using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersServiceRaports.Formularze
{
    public partial class Form_LoadFile : Form
    {
        public Form_LoadFile()
        {
            InitializeComponent();
        }

        private void button__Click(object sender, EventArgs e)
        {
            listView_ReadOrdered.Items.Clear();
            foreach (var order in Order.orders)
            {
                ListViewItem item = new ListViewItem(order.ClientId);
                item.SubItems.Add(order.RequestId + "");
                item.SubItems.Add(order.Name + "");
                item.SubItems.Add(order.Quantity + "");
                item.SubItems.Add(order.Price + "");

                listView_ReadOrdered.Items.Add(item);
                label_EditAnnouncements.ForeColor = Color.Green;
                label_EditAnnouncements.Text = "Wyświetlono aktualne zamówienia";
            }

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                ReadDate.ReadDateFromCsv.ReadFileCsv(@textBox_FilePath.Text);
                textBox_FilePath.Text = "";
                label_EditAnnouncements.ForeColor = Color.Green;
                label_EditAnnouncements.Text = "Wczytano prawidłowe zamówienia z pliku" + "\n";
                label_EditAnnouncementsBadLoad.ForeColor = Color.Red;
                label_EditAnnouncementsBadLoad.Text =ReadDate.ReadDateFromCsv.message;
            }
            catch (ArgumentNullException ae)
            {
                label_EditAnnouncements.ForeColor = Color.Red;
                label_EditAnnouncements.Text = "" + ae.Message ;
            }
                           
        }


    }
}