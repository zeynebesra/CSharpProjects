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

namespace Test_Trigger
{
    public partial class Form1 : Form
    {
        // * Trigger Kullanarak Veri Tabanı Yedek Tablosu Oluşturma *
        // Veri tabanında oluş. bilgilerinden oluşan tablo üzerinde ekle-sil işlemlerinin
        // trigger sorgular kullanılarak mevcut kitap sayısının tutulması ayrıca oluşturulan
        // kitap tablosunun ekleme ve silme işlemlerinin ardından başka bir tablo oluşturularak yedeklenmesi 

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9KU9EUG;Initial Catalog=Test;Integrated Security=True");

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKITAPLAR (AD,YAZAR,SAYFA,YAYINEVI,TUR) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYazar.Text);
            komut.Parameters.AddWithValue("@p3", txtSayfa.Text);
            komut.Parameters.AddWithValue("@p4", txtYayınevi.Text);
            komut.Parameters.AddWithValue("@p5", txtTur.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sisteme Eklendi");
            listele();
            sayac();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from TBLKITAPLAR where ID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap sistemden silindi");
            listele();
            sayac();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            sayac();
        }

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLKITAPLAR", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void sayac()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tblsayac", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblKitap.Text = " Kitap Adet  : " + dr[0].ToString();
            }
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSayfa.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtYayınevi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtTur.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}
