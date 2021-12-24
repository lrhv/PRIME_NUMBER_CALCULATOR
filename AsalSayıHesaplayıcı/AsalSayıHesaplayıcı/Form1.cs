using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsalSayıHesaplayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int sayac = 0;
            listBox1.Items.Clear();
            int x = Convert.ToInt32(domainUpDown1.Text);
            if (x < 0)
            {
                MessageBox.Show("Eksi sayı için asallık hesaplanamaz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(x < 2)
            {
                MessageBox.Show("Asal sayı bulunamadı!","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 2; i <= x; i++)
                {
                    int kontrol = 0;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            kontrol++;
                            break;
                        }
                    }
                    if (kontrol == 0)
                    {
                        listBox1.Items.Add(i);
                        sayac++;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

