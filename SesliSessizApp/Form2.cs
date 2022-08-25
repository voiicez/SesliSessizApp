using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SesliSessizApp.Services;

namespace SesliSessizApp
{
    public partial class Form2 : Form
    {
        StringIslemleriService _servis = new StringIslemleriService();
        public Form2()
        {
            InitializeComponent();
        }

        private void bBul_Click(object sender, EventArgs e)
        {
            rtbCumle.Text = _servis.IlkHarfleriBuyut(tbCumle.Text);
        }

        private void rtbCumle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
