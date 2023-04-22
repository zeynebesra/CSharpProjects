using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervasyon_Sistemi
{
    public partial class Form1 : Form
    {
        // * Veri Tabanı ile Yolcu Bilet Rezervasyon & Kayıt Sistemi *
        // Bilet rezervasyon, yolcu kayıt ve sefer oluşturma sistemi örneklendirilmiştir.
        // Bu sistem ile yeni otobus seferleri oluşturulabilecek, mevcut seferler sorgulanabilecek, bilet rezervasyonu yapılırken yolcunun daha önce firmada kaydı olup olmadığı sorgulanacak
        // ve kayıtlı ise bilgileri daha önceki kayıt üzerinden çekilecek, kayıtlı değilse yolcunun bilgilerinin kayıt edilmesi sağlanacaktır.

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9KU9EUG;Initial Catalog=DbYolcuBilet;Integrated Security=True");

        void seferListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLSEFERBILGI", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        bool yolcuDurum;
        void yolcuKontrol()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select TC from TBLYOLCUBILGI where TC=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", mskSeferTc.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    yolcuDurum = true;
                }
                else
                {
                    yolcuDurum = false;
                }
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Doğru bilgi giriniz");
            }


        }


        // Yolcu oluştur
        private void button11_Click(object sender, EventArgs e)
        {
            yolcuKontrol();
            if (yolcuDurum == false)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLYOLCUBILGI(AD,SOYAD,TELEFON,TC,CINSIYET,MAIL) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", mskTel.Text);
                komut.Parameters.AddWithValue("@p4", mskTc.Text);
                komut.Parameters.AddWithValue("@p5", cmbCins.ValueMember);
                komut.Parameters.AddWithValue("@p6", txtMail.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yollcu Bilgisi Kaydedildi");
            }
            else
            {
                MessageBox.Show("Yolcu zaten kayıtlı!");
            }
        }


        // Sefer oluştur
        private void button12_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLSEFERBILGI (KALKIS,VARIS,TARIH,SAAT,KAPTAN,FIYAT) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKalkis.Text);
            komut.Parameters.AddWithValue("@p2", txtVaris.Text);
            komut.Parameters.AddWithValue("@p3", mskTarih.Text);
            komut.Parameters.AddWithValue("@p4", mskSaat.Text);
            komut.Parameters.AddWithValue("@p5", mskKaptan.Text);
            komut.Parameters.AddWithValue("@p6", txtfiyat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sefer Bilgisi Kaydedildi");
            seferListesi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            seferListesi();
        }


        // Rezervasyon Yap 
        private void button16_Click(object sender, EventArgs e)
        {
            yolcuKontrol();

            if (yolcuDurum == true)
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLSEFERDETAY (SEFERNO,YOLCUTC,KOLTUK) values (@p1,@p2,@p3)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtRezSeferNo.Text);
                komut.Parameters.AddWithValue("@p2", mskSeferTc.Text);
                komut.Parameters.AddWithValue("@p3", txtKoltukNo.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Rezervasyon oluşturuldu");

            }
            else
            {
                MessageBox.Show("Önce yolcu bilgilerini kaydedin!");
            }
        }


        void yolcuBilgi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLYOLCUBILGI where TC=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", mskSeferTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                mskTel.Text = dr[3].ToString();
                mskTc.Text = dr[4].ToString();
                txtMail.Text = dr[6].ToString();
            }
            else
            {
                MessageBox.Show("Kullanıcı kaydı bulunamadı");
            }
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtRezSeferNo.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }


        // Kaptan
        private void button13_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKAPTAN (KAPTANNO,ADSOYAD,TELEFON) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKaptanNo.Text);
            komut.Parameters.AddWithValue("@p2", txtKaptanad.Text);
            komut.Parameters.AddWithValue("@p3", mskKaptanTel.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaptan Bilgisi Kaydedildi");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yolcuBilgi();

        }
    }
}
