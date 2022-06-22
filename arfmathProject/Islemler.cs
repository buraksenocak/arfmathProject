using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arfmathProject
{
    public partial class Islemler : Form
    {
        public Islemler()
        {
            InitializeComponent();
        }
        public Zorluk zorluk = new Zorluk();
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Properties.Settings1.Default.islem = "toplama";
            Properties.Settings1.Default.Save();
            this.Hide();
            zorluk.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Properties.Settings1.Default.islem = "çıkarma";
            Properties.Settings1.Default.Save();
            this.Hide();
            zorluk.Show();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Properties.Settings1.Default.islem = "çarpma";
            Properties.Settings1.Default.Save();
            this.Hide();
            zorluk.Show();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            Properties.Settings1.Default.islem = "bölme";
            Properties.Settings1.Default.Save();
            this.Hide();
            zorluk.Show();
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            Properties.Settings1.Default.islem = "karışık";
            Properties.Settings1.Default.Save();
            this.Hide();
            zorluk.Show();
        }
    }
}
