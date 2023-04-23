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

namespace Petrol_Stok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // PETROL  AKARYAKIT STOK TAKİP SİSTEMİ
        // yakıt stok takibi, akaryakıt alım satım işlemleri, işlemlerin veri tabanına kaydedilmesi, istasyonunun güncel yakıt miktarları 


        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9KU9EUG;Initial Catalog=DbAkaryakit;Integrated Security=True");

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void temizle()
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
        }

        void listele()
        {
            // V/MaxKursunsuz95
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLBENZIN where PETROLTUR='V/MaxKursunsuz95'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblKursunsuz.Text = dr[3].ToString();
                progressBar1.Value = int.Parse(dr[4].ToString());
                lblKursunsuzL.Text = dr[4].ToString();
            }
            baglanti.Close();

            // V/MaxDiesel
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from TBLBENZIN where PETROLTUR='V/MaxDiesel'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblDiesel.Text = dr2[3].ToString();
                progressBar2.Value = int.Parse(dr2[4].ToString());
                lblDieselL.Text = dr2[4].ToString();
            }
            baglanti.Close();


            // V/ProDiesel
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from TBLBENZIN where PETROLTUR='V/ProDiesel'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblProDiesel.Text = dr3[3].ToString();
                progressBar3.Value = int.Parse(dr3[4].ToString());
                lblProDieselL.Text = dr3[4].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select*from TBLKASA", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblKasa.Text = dr6[0].ToString();
            }
            baglanti.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        // V/MaxKursunsuz95
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz, litre, tutar;
            kursunsuz = Convert.ToDouble(lblKursunsuz.Text);
            litre = Convert.ToDouble(numericUpDown1.Value);
            tutar = kursunsuz * litre;
            txtKursunsuzF.Text = tutar.ToString();
        }

        // V/MaxDiesel
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double maxdiesel, litre, tutar;
            maxdiesel = Convert.ToDouble(lblDiesel.Text);
            litre = Convert.ToDouble(numericUpDown2.Value);
            tutar = maxdiesel * litre;
            txtMaxDieselF.Text = tutar.ToString();

        }

        // V/ProDiesel
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double prodiesel, litre, tutar;
            prodiesel = Convert.ToDouble(lblProDiesel.Text);
            litre = Convert.ToDouble(numericUpDown3.Value);
            tutar = prodiesel * litre;
            txtProDieselF.Text = tutar.ToString();
        }

        // Depo Doldur
        private void button1_Click(object sender, EventArgs e)
        {

            if (numericUpDown1.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU, LITRE, FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", textPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "V/MaxKursunsuz95");
                komut.Parameters.AddWithValue("@p3", numericUpDown1.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtKursunsuzF.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();


                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtKursunsuzF.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();


                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK-@p1 where PETROLTUR='V/MaxKursunsuz95'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown1.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Gerçekleşti");
                listele();
                temizle();
            }


        }
    }
}
