﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlis = 0;
       

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (e.KeyCode == Keys.Enter)
            {
               // textBox1.Enabled = false;
                switch (soruNo)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                           
                            button4.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                            
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                           
                            button8.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                            
                            button8.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            
                            button7.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                            
                            button7.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            
                            button6.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                            
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            
                            button24.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                            
                            button24.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            
                            button23.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                            
                            button23.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            
                            button22.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                            
                            button22.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            
                            button9.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                            
                            button9.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            
                            button5.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                           
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 10:
                        if (textBox1.Text == "içel")
                        {
                            
                            button12.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                           
                            button12.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            
                            button10.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                            
                            button10.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            
                            button11.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                            
                            button11.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            
                            button13.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                            
                            button13.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 14:
                        if (textBox1.Text == "mart")
                        {
                            
                            button14.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                            
                            button14.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            
                            button15.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                            
                            button15.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            
                            button16.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                            
                            button16.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 17:
                        if (textBox1.Text == "pırasa")
                        {
                            
                            button21.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                            
                            button21.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            
                            button20.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                            
                            button20.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 19:
                        if (textBox1.Text == "snake")
                        {
                            
                            button19.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                            
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 20:
                        if (textBox1.Text == "tarkan")
                        {
                           
                            button18.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                            
                            button18.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 21:
                        if (textBox1.Text == "umut")
                        {
                            
                            button17.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                           
                            button17.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 22:
                        if (textBox1.Text == "van")
                        {
                            
                            button1.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                            
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 23:
                        if (textBox1.Text == "yıldırım")
                        {
                            
                            button2.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                            
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;

                    case 24:
                        if (textBox1.Text == "zeytin")
                        {
                            
                            button3.BackColor = Color.Green;
                            dogru++;
                            labell.Text = dogru.ToString();
                        }
                        else
                        {
                           
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        textBox1.Text = "";
                        break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruNo++;
            this.Text = soruNo.ToString();

            if (soruNo ==1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                button4.BackColor = Color.Yellow;
            }
            if (soruNo == 2)
            {
                
                richTextBox1.Text = "Yeşilliği ünlü Marmara ilimiz?";
                button8.BackColor = Color.Yellow;
            }
            if (soruNo == 3)
            {
             
                richTextBox1.Text = "Müslümanlarn kutsal günü";
                button7.BackColor = Color.Yellow;
            }
            if (soruNo == 4)
            {
                
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                button6.BackColor = Color.Yellow;
            }
            if (soruNo == 5)
            {
                
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı?";
                button24.BackColor = Color.Yellow;
            }
            if (soruNo == 6)
            {
                
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                button23.BackColor = Color.Yellow;
            }
            if (soruNo == 7)
            {
                
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                button22.BackColor = Color.Yellow;
            }
            if (soruNo == 8)
            {
                
                richTextBox1.Text = "Öğrencilerin kötü karne getirdiğinde bakıştığı nesne?";
                button9.BackColor = Color.Yellow;
            }
            if (soruNo == 9)
            {
               
                richTextBox1.Text = "Gülü ile ünlü ilimiz";
                button5.BackColor = Color.Yellow;
            }
            if (soruNo == 10)
            {
                
                richTextBox1.Text = "Mersin ilimizin diğer adı?";
                button12.BackColor = Color.Yellow;
            }
            if (soruNo == 11)
            {
                
                richTextBox1.Text = "Askeri bir topluluk?";
                button10.BackColor = Color.Yellow;
            }
            if (soruNo == 12)
            {
               
                richTextBox1.Text = "Malatya ilimizin meşhur meyvesi?";
                button11.BackColor = Color.Yellow;
            }
            if (soruNo == 13)
            {
                
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen çiçek festivali?";
                button13.BackColor = Color.Yellow;
            }
            if (soruNo == 14)
            {
                
                richTextBox1.Text = "Yılın üçüncü ayı?";
                button14.BackColor = Color.Yellow;
            }
            if (soruNo == 15)
            {
                
                richTextBox1.Text = "Üflemeli bir müzik aleti?";
                button15.BackColor = Color.Yellow;
            }
            if (soruNo == 16)
            {
               
                richTextBox1.Text = "Halk şairi?";
                button16.BackColor = Color.Yellow;
            }
            if (soruNo == 17)
            {
                
                richTextBox1.Text = "Çocukların pek sevmediği pirinç, havuç gibi sebzeler ileyapılan yemek?";
                button21.BackColor = Color.Yellow;
            }
            if (soruNo == 18)
            {
                
                richTextBox1.Text = "11 ayın sultanı?";
                button20.BackColor = Color.Yellow;
            }
            if (soruNo == 19)
            {
                button25.Text = button19.Text;
                richTextBox1.Text = "İngilizcede yılan?";
                button19.BackColor = Color.Yellow;
            }
            if (soruNo == 20)
            {
               
                richTextBox1.Text = "Türkiye'nin megastarı?";
                button18.BackColor = Color.Yellow;
            }
            if (soruNo == 21)
            {
                
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
                button17.BackColor = Color.Yellow;
            }
            if (soruNo == 22)
            {
                
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
                button1.BackColor = Color.Yellow;
            }
            if (soruNo == 23)
            {
                
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
                button2.BackColor = Color.Yellow;
            }
            if (soruNo == 24)
            {
                
                richTextBox1.Text = "Daha çok Ege bölgesinde bulunan ve yağı da yapılan bir kahvaltı besini?";
                button3.BackColor = Color.Yellow;
            }
        }

    }
}
