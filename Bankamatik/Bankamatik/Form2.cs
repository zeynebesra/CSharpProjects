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

namespace Bankamatik
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9KU9EUG;Initial Catalog=DbBanka;Integrated Security=True");
        public string hesap;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            //gönderilen hesabın para artısı
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLHESAP set BAKIYE=BAKIYE+@p1 where HESAPNO=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", decimal.Parse(txtTutar.Text));
            komut.Parameters.AddWithValue("@p2", mskHesap.Text);
            komut.ExecuteNonQuery();

            //gonderilen hesabın para azalısı
            SqlCommand komut2 = new SqlCommand("update TBLHESAP set BAKIYE=BAKIYE-@k1 where HESAPNO=@k2", baglanti);
            komut2.Parameters.AddWithValue("@k1", decimal.Parse(txtTutar.Text));
            komut2.Parameters.AddWithValue("@k2", hesap);
            komut2.ExecuteNonQuery();

            //hareket tablosu
            SqlCommand komut3 = new SqlCommand("insert into TBLHAREKETLER (GONDEREN, ALICI, TUTAR) values(@t1,@t2,@t3)", baglanti);
            komut3.Parameters.AddWithValue("@t1", lblHesapNo.Text);
            komut3.Parameters.AddWithValue("@t2", mskHesap.Text);
            komut3.Parameters.AddWithValue("@t3", decimal.Parse(txtTutar.Text));
            komut3.ExecuteNonQuery();

            MessageBox.Show("işlem gerçekleşti");

            baglanti.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblHesapNo.Text = hesap;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLKISILER where HESAPNO=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[1] + " " + dr[2];
                lblTC.Text = dr[3].ToString();
                lblTel.Text = dr[4].ToString();
            }
            baglanti.Close();
        }
    }
}
