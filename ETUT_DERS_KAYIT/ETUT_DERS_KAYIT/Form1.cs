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

namespace ETUT_DERS_KAYIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9KU9EUG;Initial Catalog=DbEtut;Integrated Security=True");
        void dersListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLDERS", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

        }

        void etutListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLETUT", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLETUT (DERSID,OGRETMENID,TARIH,SAAT) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbDers.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbOgretmen.SelectedValue);
            komut.Parameters.AddWithValue("@p3", mskTarih.Text);
            komut.Parameters.AddWithValue("@p4", mskSaat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt oluşturuldu");
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLETUT set OGRENCIID=@p1, DURUM=@p2 where ID=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", txtOgrenci.Text);
            komut.Parameters.AddWithValue("@p2", "True");
            komut.Parameters.AddWithValue("@p3", txtEtutId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt öğrenciye verildi");
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            dersTekrarKontrol();
            if (dersDurum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLDERS (DERSAD) values (@p1)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtDers.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Ders ekleme başarılı!");
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Ders zaten kayıtlı!");
            }
        }

        bool dersDurum;
        bool ogrtDurum;
        void ogrtKontrol()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLOGRETMEN where AD=@p1 and SOYAD=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtOgrtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtOgrtSoyad.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                ogrtDurum = false;
            }
            else
            {
                ogrtDurum = true;
            }
            baglanti.Close();
        }

        void dersTekrarKontrol()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLDERS where DERSAD=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtDers.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                dersDurum = false;
            }
            else
            {
                dersDurum = true;
            }
            baglanti.Close();
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLOGRENCI (AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@p4", txtSınıf.Text);
            komut.Parameters.AddWithValue("@p5", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p6", txtMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci kaydedildi");
        }

        private void btnOgretmenEkle_Click(object sender, EventArgs e)
        {
            dersListesi();
            ogrtKontrol();

            if (ogrtDurum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLOGRETMEN (AD,SOYAD,BRANSID) values (@p1,@p2,@p3)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtOgrtAd.Text.ToUpper());
                komut.Parameters.AddWithValue("@p2", txtOgrtSoyad.Text.ToUpper());
                komut.Parameters.AddWithValue("@p3", cmbEkleDersAdı.ValueMember);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Öğretmen zaten kayıtlı");
            }
        }

        private void cmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select OGRTID,(AD+ ' ' +SOYAD) as 'ADSOYAD' from TBLOGRETMEN where BRANSID=" + cmbDers.SelectedValue, baglanti);//secilen degerin idsine göre
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbOgretmen.ValueMember = "OGRTID";
            cmbOgretmen.DisplayMember = "ADSOYAD";
            cmbOgretmen.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtEtutId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dersListesi();
            etutListesi();
        }
    }
}
