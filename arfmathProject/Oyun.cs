using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace arfmathProject
{
    public partial class Oyun : Form
    {
        Random rnd = new Random();
        string[] Maths = { "Topla", "Çıkart", "Çarp", "Böl" };
        public int sonuc;
        public int NumX;
        public int NumY;
        public int yanlislar=0,dogrular=0;
        public Oyun()
        {
            InitializeComponent();
            OyunuKur();
            zorluklariyaz();
            bunifuTextBox1.Focus();
        }

        
        private void Oyun_Load(object sender, EventArgs e)
        {
            
        }
        private int yuksekskor = 0;
        private void yuksekskoryazdir()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=arfmathdb;Integrated Security=True");
            baglanti.Open();
            if (Properties.Settings1.Default.zorluk == "kolay" && Properties.Settings1.Default.islem == "toplama")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tbltoplamakolay", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
            }
            if (Properties.Settings1.Default.zorluk == "orta" && Properties.Settings1.Default.islem == "toplama")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tbltoplamaorta", baglanti);
                
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
            }
            if (Properties.Settings1.Default.zorluk == "zor" && Properties.Settings1.Default.islem == "toplama")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tbltoplamazor", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
            }
            if (Properties.Settings1.Default.zorluk == "kolay" && Properties.Settings1.Default.islem == "çıkarma")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblcikarmakolay", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
            }
            if (Properties.Settings1.Default.zorluk == "orta" && Properties.Settings1.Default.islem == "çıkarma")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblcikarmaorta", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
            }
            if (Properties.Settings1.Default.zorluk == "zor" && Properties.Settings1.Default.islem == "çıkarma")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblcikarmazor", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
            }
            if (Properties.Settings1.Default.zorluk == "kolay" && Properties.Settings1.Default.islem == "çarpma")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblcarpmakolay", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
            }
            if (Properties.Settings1.Default.zorluk == "orta" && Properties.Settings1.Default.islem == "çarpma")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblcarpmaorta", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
            }
            if (Properties.Settings1.Default.zorluk == "zor" && Properties.Settings1.Default.islem == "çarpma")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblcarpmazorr", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
            }
            if (Properties.Settings1.Default.zorluk == "kolay" && Properties.Settings1.Default.islem == "bölme")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblbolmekolay", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
            }
            if (Properties.Settings1.Default.zorluk == "orta" && Properties.Settings1.Default.islem == "bölme")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblbolmeorta", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
            }
            if (Properties.Settings1.Default.zorluk == "zor" && Properties.Settings1.Default.islem == "bölme")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblbolmezor", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
            }
            if (Properties.Settings1.Default.zorluk == "kolay" && Properties.Settings1.Default.islem == "karışık")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblkarisikkolay", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
            }
            if (Properties.Settings1.Default.zorluk == "orta" && Properties.Settings1.Default.islem == "karışık")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblkarisikorta", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
            }
            if (Properties.Settings1.Default.zorluk == "zor" && Properties.Settings1.Default.islem == "karışık")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblkarisikzor", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
            }
            baglanti.Close();
        }
        private void yuksekskorekle()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=arfmathdb;Integrated Security=True");
            baglanti.Open();
            if (Properties.Settings1.Default.zorluk == "kolay" && Properties.Settings1.Default.islem == "toplama")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tbltoplamakolay", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                if (yuksekskor<dogrular)
                {
                    SqlCommand ekle2 = new SqlCommand("INSERT INTO tbltoplamakolay (skor) VALUES (@skor)",baglanti);
                    ekle2.Parameters.AddWithValue("@skor", dogrular);
                    ekle2.ExecuteNonQuery();
                    lblmaxskor.Text = dogrular.ToString();
                }
            }
            if (Properties.Settings1.Default.zorluk == "orta" && Properties.Settings1.Default.islem == "toplama")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tbltoplamaorta", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
                if (yuksekskor < dogrular)
                {
                    SqlCommand ekle2 = new SqlCommand("INSERT INTO tbltoplamaorta (skor) VALUES (@skor)", baglanti);
                    ekle2.Parameters.AddWithValue("@skor", dogrular);
                    ekle2.ExecuteNonQuery();
                    lblmaxskor.Text = dogrular.ToString();
                }
            }
            if (Properties.Settings1.Default.zorluk == "zor" && Properties.Settings1.Default.islem == "toplama")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tbltoplamazor", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
                if (yuksekskor < dogrular)
                {
                    SqlCommand ekle2 = new SqlCommand("INSERT INTO tbltoplamazor (skor) VALUES (@skor)", baglanti);
                    ekle2.Parameters.AddWithValue("@skor", dogrular);
                    ekle2.ExecuteNonQuery();
                    lblmaxskor.Text = dogrular.ToString();
                }
            }
            if (Properties.Settings1.Default.zorluk == "kolay" && Properties.Settings1.Default.islem == "çıkarma")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblcikarmakolay", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
                if (yuksekskor < dogrular)
                {
                    SqlCommand ekle2 = new SqlCommand("INSERT INTO tblcikarmakolay (skor) VALUES (@skor)", baglanti);
                    ekle2.Parameters.AddWithValue("@skor", dogrular);
                    ekle2.ExecuteNonQuery();
                    lblmaxskor.Text = dogrular.ToString();
                }
            }
            if (Properties.Settings1.Default.zorluk == "orta" && Properties.Settings1.Default.islem == "çıkarma")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblcikarmaorta", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
                if (yuksekskor < dogrular)
                {
                    SqlCommand ekle2 = new SqlCommand("INSERT INTO tblcikarmaorta (skor) VALUES (@skor)", baglanti);
                    ekle2.Parameters.AddWithValue("@skor", dogrular);
                    ekle2.ExecuteNonQuery();
                    lblmaxskor.Text = dogrular.ToString();
                }
            }
            if (Properties.Settings1.Default.zorluk == "zor" && Properties.Settings1.Default.islem == "çıkarma")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblcikarmazor", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
                if (yuksekskor < dogrular)
                {
                    SqlCommand ekle2 = new SqlCommand("INSERT INTO tblcikarmazor (skor) VALUES (@skor)", baglanti);
                    ekle2.Parameters.AddWithValue("@skor", dogrular);
                    ekle2.ExecuteNonQuery();
                    lblmaxskor.Text = dogrular.ToString();
                }
            }
            if (Properties.Settings1.Default.zorluk == "kolay" && Properties.Settings1.Default.islem == "çarpma")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblcarpmakolay", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
                if (yuksekskor < dogrular)
                {
                    SqlCommand ekle2 = new SqlCommand("INSERT INTO tblcarpmakolay (skor) VALUES (@skor)", baglanti);
                    ekle2.Parameters.AddWithValue("@skor", dogrular);
                    ekle2.ExecuteNonQuery();
                    lblmaxskor.Text = dogrular.ToString();
                }
            }
            if (Properties.Settings1.Default.zorluk == "orta" && Properties.Settings1.Default.islem == "çarpma")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblcarpmaorta", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
                if (yuksekskor < dogrular)
                {
                    SqlCommand ekle2 = new SqlCommand("INSERT INTO tblcarpmaorta (skor) VALUES (@skor)", baglanti);
                    ekle2.Parameters.AddWithValue("@skor", dogrular);
                    ekle2.ExecuteNonQuery();
                    lblmaxskor.Text = dogrular.ToString();
                }
            }
            if (Properties.Settings1.Default.zorluk == "zor" && Properties.Settings1.Default.islem == "çarpma")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblcarpmazor", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
                if (yuksekskor < dogrular)
                {
                    SqlCommand ekle2 = new SqlCommand("INSERT INTO tblcarpmazor (skor) VALUES (@skor)", baglanti);
                    ekle2.Parameters.AddWithValue("@skor", dogrular);
                    ekle2.ExecuteNonQuery();
                    lblmaxskor.Text = dogrular.ToString();
                }

            }
            if (Properties.Settings1.Default.zorluk == "kolay" && Properties.Settings1.Default.islem == "bölme")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblbolmekolay", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
                if (yuksekskor < dogrular)
                {
                    SqlCommand ekle2 = new SqlCommand("INSERT INTO tblbolmekolay (skor) VALUES (@skor)", baglanti);
                    ekle2.Parameters.AddWithValue("@skor", dogrular);
                    ekle2.ExecuteNonQuery();
                    lblmaxskor.Text = dogrular.ToString();
                }
            }
            if (Properties.Settings1.Default.zorluk == "orta" && Properties.Settings1.Default.islem == "bölme")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblbolmeorta", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
                if (yuksekskor < dogrular)
                {
                    SqlCommand ekle2 = new SqlCommand("INSERT INTO tblbolmeorta (skor) VALUES (@skor)", baglanti);
                    ekle2.Parameters.AddWithValue("@skor", dogrular);
                    ekle2.ExecuteNonQuery();
                    lblmaxskor.Text = dogrular.ToString();
                }
            }
            if (Properties.Settings1.Default.zorluk == "zor" && Properties.Settings1.Default.islem == "bölme")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblbolmezor", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
                if (yuksekskor < dogrular)
                {
                    SqlCommand ekle2 = new SqlCommand("INSERT INTO tblbolmezor (skor) VALUES (@skor)", baglanti);
                    ekle2.Parameters.AddWithValue("@skor", dogrular);
                    ekle2.ExecuteNonQuery();
                    lblmaxskor.Text = dogrular.ToString();
                }
            }
            if (Properties.Settings1.Default.zorluk == "kolay" && Properties.Settings1.Default.islem == "karışık")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblkarisikkolay", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
                if (yuksekskor < dogrular)
                {
                    SqlCommand ekle2 = new SqlCommand("INSERT INTO tblkarisikkolay (skor) VALUES (@skor)", baglanti);
                    ekle2.Parameters.AddWithValue("@skor", dogrular);
                    ekle2.ExecuteNonQuery();
                    lblmaxskor.Text = dogrular.ToString();
                }
            }
            if (Properties.Settings1.Default.zorluk == "orta" && Properties.Settings1.Default.islem == "karışık")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblkarisikorta", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
                if (yuksekskor < dogrular)
                {
                    SqlCommand ekle2 = new SqlCommand("INSERT INTO tblkarisikorta (skor) VALUES (@skor)", baglanti);
                    ekle2.Parameters.AddWithValue("@skor", dogrular);
                    ekle2.ExecuteNonQuery();
                    lblmaxskor.Text = dogrular.ToString();
                }
            }
            if (Properties.Settings1.Default.zorluk == "zor" && Properties.Settings1.Default.islem == "karışık")
            {
                SqlCommand ekle = new SqlCommand("SELECT MAX(skor) FROM tblkarisikzor", baglanti);
                yuksekskor = (int)ekle.ExecuteScalar();
                lblmaxskor.Text = yuksekskor.ToString();
                if (yuksekskor < dogrular)
                {
                    SqlCommand ekle2 = new SqlCommand("INSERT INTO tblkarisikzor (skor) VALUES (@skor)", baglanti);
                    ekle2.Parameters.AddWithValue("@skor", dogrular);
                    ekle2.ExecuteNonQuery();
                    lblmaxskor.Text = dogrular.ToString();
                }
            }
            baglanti.Close();
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            int kullaniciCevap = Convert.ToInt32(bunifuTextBox1.Text);
            if (bunifuTextBox1.Text=="")
            {
                MessageBox.Show("Sayı değeri giriniz!");
            }
            else if (kullaniciCevap == sonuc)
            {
                
                OyunuKur();
                dogrular += 1;
                lblmevcutskor.Text = dogrular.ToString();
                bunifuTextBox1.Focus();
            }
            else
            {
                OyunuKur();
                yanlislar += 1;
                label3.Text += "X ";
                bunifuTextBox1.Focus();
                if (yanlislar==3)
                {
                    yuksekskorekle();
                    yanlislar = 0;
                    dogrular = 0;
                    lblmevcutskor.Text = "0";
                    label3.Text = "";
                    MessageBox.Show("Oyun Bitti!");
                }
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }
        private void zorluklariyaz()
        {
            if (Properties.Settings1.Default.zorluk == "kolay")
            {
                NumX = rnd.Next(0, 10);
                NumY = rnd.Next(0, 10);
            }
            else if (Properties.Settings1.Default.zorluk == "orta")
            {
                NumX = rnd.Next(9, 100);
                NumY = rnd.Next(9, 100);
            }
            else if (Properties.Settings1.Default.zorluk == "zor")
            {
                NumX = rnd.Next(99, 1000);
                NumY = rnd.Next(99, 1000);
            }
        }

        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {
            Zorluk zorluk=new Zorluk();
            this.Hide();
            zorluk.Show();
        }

        private void bunifuTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!bunifuTextBox1.AcceptsReturn)
                {
                    bunifuButton1.PerformClick();
                }
            }
        }

        private void OyunuKur()//islemin ne olduğunu 
        {
            yuksekskoryazdir();
            zorluklariyaz();
            if (Properties.Settings1.Default.islem == "toplama")
            {
                sonuc = NumX + NumY;
                lblislem.Text = "+";
            }
            if (Properties.Settings1.Default.islem == "çıkarma")
            {
                sonuc = NumX - NumY;
                lblislem.Text = "-";
            }
            if (Properties.Settings1.Default.islem == "çarpma")
            {
                sonuc = NumX * NumY;
                lblislem.Text = "*";
            }
            if (Properties.Settings1.Default.islem == "bölme")
            {
                sonuc = NumX / NumY;
                lblislem.Text = "/";
            }
            if (Properties.Settings1.Default.islem == "karışık") 
            {
                switch (Maths[rnd.Next(0, Maths.Length)])
                {
                    case "Topla":
                        sonuc = NumX + NumY;
                        lblislem.Text = "+";
                        break;

                    case "Çıkart":
                        sonuc = NumX - NumY;
                        lblislem.Text = "-";
                        break;

                    case "Çarp":
                        sonuc = NumX * NumY;
                        lblislem.Text = "x";
                        break;
                    case "Böl":
                        sonuc = NumX / NumY;
                        lblislem.Text = "/";
                        break;

                }
            }
            bunifuTextBox1.Text = null;

            
            lblx.Text = NumX.ToString();
            lbly.Text = NumY.ToString();
            this.Refresh();
        }

    }
}

