using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Kayit_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOgrenciDetay frm = new FormOgrenciDetay();
            frm.numara = maskedTextBox1.Text;
            frm.Show();
            
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "1111")
            {
                FormOgretmanDetay fr = new FormOgretmanDetay();
                fr.Show();
            }

        }
    }
}
