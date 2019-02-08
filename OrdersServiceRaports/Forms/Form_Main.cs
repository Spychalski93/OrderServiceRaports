using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersServiceRaports
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void linkLabelXml_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Formularze.FormPictureXml form = new Formularze.FormPictureXml();
            form.Show();
        }

        private void linkLabelCsv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Formularze.FormPictureCsv form = new Formularze.FormPictureCsv();
            form.Show();
        }

        private void button_LoadFile_Click(object sender, EventArgs e)
        {
            Formularze.Form_LoadFile form = new Formularze.Form_LoadFile();
            form.ShowDialog();           

        }

        private void button_Raports_Click(object sender, EventArgs e)
        {
            Formularze.Form_Raports form = new Formularze.Form_Raports();
            form.ShowDialog();
        }
    }
}
