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
    }
}
