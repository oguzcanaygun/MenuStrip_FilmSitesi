using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _55_MenuStrip
{
    public partial class FullFilmİzleHD : Form
    {
        public FullFilmİzleHD()
        {
            InitializeComponent();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void geceModuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Oguzcan Aygun tarafından yapılmıstır","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yenidenBaşlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void indianaJonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Indına Jones Kutsal Hazine Avcıları";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=XkkzKHCx154");
        }

        private void pSILoveYouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "P.S I Love You";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=CZzW6_hR068");
        }

        private void aynıYıldızınAltındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Aynı Yıldızın Altında";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=aQnlngjZG48");            
        }

        private void korkuSeansıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Korku Seansı";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=5u5A471adxg");
        }

        private void uzayYolcularıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Uzay Yolcuları";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=8GKyQ1S5594");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
