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
    public partial class Zorluk : Form
    {

        public Zorluk()
        {
            InitializeComponent();
            
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Islemler islemler=new Islemler();
            islemler.Show();
            this.Hide();
        }

        private void Zorluk_Load(object sender, EventArgs e)
        {

        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
            if (bunifuRadioButton1.Checked == true)
            {
                Properties.Settings1.Default.zorluk = "kolay";
                Properties.Settings1.Default.Save();
            }
            else if (bunifuRadioButton2.Checked == true)
            {
                Properties.Settings1.Default.zorluk = "orta";
                Properties.Settings1.Default.Save();
            }
            else if (bunifuRadioButton3.Checked == true)
            {
                Properties.Settings1.Default.zorluk = "zor";
                Properties.Settings1.Default.Save();
            }
            loading loading = new loading();
            this.Hide();
            loading.Show();
            loading.Hide();
        }
    }
}
