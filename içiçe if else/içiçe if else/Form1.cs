using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace içiçe_if_else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string k_adi, sifre;
            k_adi = textBox1.Text;
            sifre = textBox2.Text;
            if (k_adi == "Kerem")
            {
                if (sifre == "Fenerbahçe")
                {
                    MessageBox.Show("Şifre Doğru,Giriş Başarılı");
                }
                else 
                {
                    MessageBox.Show("Şifre Yanlış Giriş Başarısız");
                    
                }
            }
            else 
            {
                MessageBox.Show("Giriş Başarısız");
                sayac = sayac + 1;
            }
            if (sayac == 3)
            {
                button1.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else 
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
