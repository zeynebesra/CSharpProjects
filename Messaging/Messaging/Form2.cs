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

namespace Messaging
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9KU9EUG;Initial Catalog=DbMessage;Integrated Security=True");


        private void btnAdd_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLKISILER where NUMARA=@p1 and SIFRE=@p2", baglanti);//p1 de ki num değeri aynı satırdakı sıfreye esitse
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 frm = new Form1();
                frm.numara = maskedTextBox1.Text;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi");
            }
            baglanti.Close();
        }
    }
}
