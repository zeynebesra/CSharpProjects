using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RSS_Veri_Cekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void haberiCek(string link)
        {
            listBox1.Items.Clear();
            XmlTextReader xmloku = new XmlTextReader(link);
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            haberiCek("https://www.cnnturk.com/feed/rss/turkiye/news");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            haberiCek("https://feeds.bbci.co.uk/turkce/rss.xml");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            haberiCek("https://www.gzt.com/rss");
        }
    }
}
