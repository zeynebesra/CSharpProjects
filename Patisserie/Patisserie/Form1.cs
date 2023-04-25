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

namespace Patisserie
{
    public partial class Form1 : Form
    {
        // Pastahane Ürün Maliyetlendirme Sistemi
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9KU9EUG;Initial Catalog=DbPastane;Integrated Security=True");
        void malzemeListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLMALZEMELER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void urunListesi()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select * from TBLURUNLER", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
        void kasa()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("select * from TBLKASA", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }
        void urunler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLURUNLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbUrun.ValueMember = "URUNID";
            cmbUrun.DisplayMember = "AD";
            cmbUrun.DataSource = dt;
            baglanti.Close();
        }
        void malzemeler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from TBLMALZEMELER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMalzeme.ValueMember = "MALZEMEID";
            cmbMalzeme.DisplayMember = "AD";
            cmbMalzeme.DataSource = dt;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            malzemeListesi();
            urunler();
            malzemeler();
        }

        private void btnUrunList_Click(object sender, EventArgs e)
        {
            urunListesi();
        }

        private void btnMalzList_Click(object sender, EventArgs e)
        {
            malzemeListesi();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kasa();
        }

        private void btnMlzEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLMALZEMELER (AD,STOK,FIYAT,NOTLAR) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtMlzAd.Text.ToUpper());
                komut.Parameters.AddWithValue("@p2", decimal.Parse(txtMlzStok.Text));
                komut.Parameters.AddWithValue("@p3", decimal.Parse(txtMlzFiyat.Text));
                komut.Parameters.AddWithValue("@p4", txtMlzNot.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Malzeme Eklendi");
            }
            catch
            {
                MessageBox.Show("Bilgileri kontrol ediniz");
            }
            malzemeListesi();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (txtUrunMfiyat.Text != "" && txtUrunSfiyat.Text != "" && txtUrunStok.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLURUNLER (AD,MFIYAT,SFIYAT,STOK) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtUrunAd.Text.ToUpper());
                komut.Parameters.AddWithValue("@p2", decimal.Parse(txtUrunMfiyat.Text));
                komut.Parameters.AddWithValue("@p3", decimal.Parse(txtUrunSfiyat.Text));
                komut.Parameters.AddWithValue("@p4", Convert.ToInt32(txtUrunStok.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün eklendi");

                baglanti.Open();
                decimal cikti, girdi;
                cikti = Convert.ToDecimal(txtUrunStok.Text) * Convert.ToDecimal(txtUrunMfiyat.Text);
                girdi = (Convert.ToDecimal(txtUrunStok.Text) * Convert.ToDecimal(txtUrunSfiyat.Text)) - cikti;

                SqlCommand komut2 = new SqlCommand("insert into TBLKASA (GIRIS, CIKIS) values (@p5,@p6)", baglanti);
                komut2.Parameters.AddWithValue("@p5", girdi);
                komut2.Parameters.AddWithValue("@p6", cikti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLURUNLER (AD) values (@p1)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtUrunAd.Text.ToUpper());
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            urunListesi();
            urunler();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtUrunId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtUrunAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtUrunMfiyat.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtUrunSfiyat.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtUrunStok.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(MALIYET) from TBLFIRIN where URUNID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUrunId.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtUrunMfiyat.Text = dr[0].ToString();
            }
            baglanti.Close();
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLURUNLER set MFIYAT=@p1, SFIYAT=@p2, STOK=@p3 where AD=@p4", baglanti);
            komut.Parameters.AddWithValue("@p1", decimal.Parse(txtUrunMfiyat.Text));
            komut.Parameters.AddWithValue("@p2", decimal.Parse(txtUrunSfiyat.Text));
            komut.Parameters.AddWithValue("@p3", int.Parse(txtUrunStok.Text));
            komut.Parameters.AddWithValue("@p4", txtUrunAd.Text.ToUpper());
            komut.ExecuteNonQuery();
            MessageBox.Show("Ürün bilgisi güncellendi");
            baglanti.Close();

            baglanti.Open();
            decimal cikti, girdi;
            cikti = Convert.ToDecimal(txtUrunStok.Text) * Convert.ToDecimal(txtUrunMfiyat.Text);
            girdi = (Convert.ToDecimal(txtUrunStok.Text) * Convert.ToDecimal(txtUrunSfiyat.Text)) - cikti;

            SqlCommand komut2 = new SqlCommand("insert into TBLKASA (GIRIS, CIKIS) values (@p5,@p6)", baglanti);
            komut2.Parameters.AddWithValue("@p5", girdi);
            komut2.Parameters.AddWithValue("@p6", cikti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFIRIN(URUNID,MALZEMEID,MIKTAR,MALIYET) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbUrun.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbMalzeme.SelectedValue);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtMiktar.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtMaliyet.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme eklendi");
            listBox1.Items.Add(cmbMalzeme.Text + " - " + txtMaliyet.Text);
            txtMiktar.Text = "";
            txtMaliyet.Text = "";

        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;
            if (txtMiktar.Text == "")
            {
                txtMiktar.Text = "0";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLMALZEMELER where MALZEMEID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbMalzeme.SelectedValue);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtMaliyet.Text = dr[3].ToString();
            }
            baglanti.Close();

            if (cmbMalzeme.Text == "YUMURTA")
            {
                label11.Text = "ad.";
                maliyet = Convert.ToDouble(txtMaliyet.Text) * Convert.ToDouble(txtMiktar.Text);
                txtMaliyet.Text = maliyet.ToString();
            }
            else
            {
                label11.Text = "gr.";
                maliyet = Convert.ToDouble(txtMaliyet.Text) / 1000 * Convert.ToDouble(txtMiktar.Text);
                txtMaliyet.Text = maliyet.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from TBLMALZEMELER where AD = @p1", baglanti);
                komut.Parameters.AddWithValue("@p1", txtMlzAd.Text);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    txtMlzId.Text = dr[0].ToString();
                    txtMlzStok.Text = dr[2].ToString();
                    txtMlzFiyat.Text = dr[3].ToString();
                    txtMlzNot.Text = dr[4].ToString();
                }
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Bilgileri kontrol ediniz");
            }


        }
    }
}
