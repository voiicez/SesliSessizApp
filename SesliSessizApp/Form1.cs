using SesliSessizApp.Services;

namespace SesliSessizApp
{
    public partial class Form1 : Form
    {
        StringIslemleriService _servis = new StringIslemleriService();
        public Form1()
        {
            InitializeComponent();
        }

        private void bBul_Click(object sender, EventArgs e)
        {
            rtbSonuc.Text = _servis.SesliSessizHarfBul(tbKelime.Text, rbSesli.Checked);

        }

        private void rtbSonuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            tbKelime.Text = ""; // yada tbKelime.Clear()
            rbSesli.Checked = true;
            rtbSonuc.Text = "";
        }

        
    }
}