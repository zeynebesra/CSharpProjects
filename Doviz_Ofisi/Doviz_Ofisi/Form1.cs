using System;
using System.Windows.Forms;
using System.Xml;

namespace Doviz_Ofisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDosya = new XmlDocument();
            xmlDosya.Load(bugun);

            string dolaralis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lblDolarAlis.Text = dolaralis;

            string dolarsatis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lblDolarSatis.Text = dolarsatis;

            string euroalis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lblEuroAlis.Text = euroalis;

            string eurosatis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lblEuroSatis.Text = eurosatis;
        }

        private void btnDolarAl_Click(object sender, EventArgs e)
        {
            TxtKur.Text = lblDolarAlis.Text;
        }

        private void btnDolarSat_Click(object sender, EventArgs e)
        {
            TxtKur.Text = lblDolarSatis.Text;
        }

        private void btnEuroAl_Click(object sender, EventArgs e)
        {
            TxtKur.Text = lblEuroAlis.Text;
        }

        private void btnEuroSat_Click(object sender, EventArgs e)
        {
            TxtKur.Text = lblEuroSatis.Text;
        }

        private void BtnSatisYap_Click(object sender, EventArgs e)
        {
            try
            {
                double kur, miktar, tutar;
                kur = Convert.ToDouble(TxtKur.Text);
                miktar = Convert.ToDouble(TxtMiktar.Text);
                tutar = kur * miktar;
                TxtTutar.Text = tutar.ToString();
                TxtKalan.Text = "";
            }
            catch 
            {

                MessageBox.Show("İlgili alanları doldurunuz");
            }
            
        }

        private void TxtKur_TextChanged(object sender, EventArgs e)
        {
            TxtKur.Text = TxtKur.Text.Replace(".", ",");
        }

        private void btnSatisYap2_Click(object sender, EventArgs e)
        {
            try
            {
                double kur = Convert.ToDouble(TxtKur.Text);
                int miktar = Convert.ToInt32(TxtMiktar.Text);
                int tutar = Convert.ToInt32(miktar / kur);
                TxtTutar.Text = tutar.ToString();
                double kalan;
                kalan = miktar % kur;
                TxtKalan.Text = kalan.ToString();
            }
            catch
            {
                MessageBox.Show("İlgili alanları doldurunuz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
