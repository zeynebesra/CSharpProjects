using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Access_Ingilizce_Kelime_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\w10\OneDrive - IZU\Masaüstü\dbKelime2.mdb");
        Random rast = new Random();
        int sure = 90;
        int kelime = 0; 

        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
            TxtTurkce.Focus();
            timer1.Start();
        }

        void getir()
        {
            int sayi;
            sayi = rast.Next(1, 2490);
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtInglizce.Text = dr[1].ToString();
                LblCevap.Text = dr[2].ToString();
                LblCevap.Text = LblCevap.Text.ToLower();
            }
            baglanti.Close();
        }

        private void TxtTurkce_TextChanged(object sender, EventArgs e)
        {
            if (TxtTurkce.Text == LblCevap.Text)
            {
                kelime++;
                lblKelime.Text = kelime.ToString();
                getir();
                TxtTurkce.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            LblSure.Text = sure.ToString();
            if (sure==0)
            {
                TxtTurkce.Enabled = false;
                TxtInglizce.Enabled = false;
                timer1.Stop();

            }
        }
    }
}
