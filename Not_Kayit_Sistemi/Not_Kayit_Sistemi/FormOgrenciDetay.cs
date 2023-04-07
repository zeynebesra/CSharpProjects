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

namespace Not_Kayit_Sistemi
{
    public partial class FormOgrenciDetay : Form
    {
        public FormOgrenciDetay()
        {
            InitializeComponent();
        }

        public string numara;

        // Data Source=DESKTOP-9KU9EUG;Initial Catalog=DbNotKayit;Integrated Security=True

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9KU9EUG;Initial Catalog=DbNotKayit;Integrated Security=True");
        private void FormOgrenciDetay_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select*From TBLDERS where OGRNUMARA=@p1", baglanti);

            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                
                lblAdsoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                lblSinav1.Text = dr[4].ToString();
                lblSinav2.Text = dr[5].ToString();
                lblSinav3.Text = dr[6].ToString();
                lblOrt.Text = dr[7].ToString();
                if (dr[8].ToString() == "True")
                {
                    lblDurum.Text = "Geçti";
                }
                else
                {
                    lblDurum.Text = "Kaldı";
                }

            }



            baglanti.Close();

        }
    }
}
