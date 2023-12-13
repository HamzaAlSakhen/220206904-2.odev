using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ogrenciler;
using System.Windows.Forms;

namespace Hamza_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Ogrenciler.Ogrenci ogrenci1 = new Ogrenciler.Ogrenci(); 
        //    ogrenci1.ID(textBox1);
        //    label2.Text = ogrenci1.ID; 
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Ogrenciler.Ogrenci ogrenci1 = new Ogrenciler.Ogrenci();
        //    ogrenci1.ID = Convert.ToInt32(textBox1.Text);
        //    label2.Text = ogrenci1.ID.ToString();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenciler.Ogrenci ogrenci1 = new Ogrenciler.Ogrenci();
            ogrenci1.ID = Convert.ToInt32(textBox1.Text);
            ogrenci1.ISIM = textBox2.Text;
            ogrenci1.DogumTarihi = textBox3.Text;
            ogrenci1.TELEFON = textBox4.Text;
            ogrenci1.BOLUM = textBox5.Text;

            label_id.Text = ogrenci1.ID.ToString();
            label_isim.Text = textBox2.Text.ToUpper();

            label_dogum.Text = textBox3.Text.Substring(0, 2);
            label_dogum.Text += "." + textBox3.Text.Substring(3, 2);
            label_dogum.Text += "." + textBox3.Text.Substring(6, 4);
            
            label_telefon.Text = textBox4.Text;

            label_bolum.Text = textBox5.Text.ToUpper();

            ogrenci1.vize = Convert.ToDouble(textBox_vize.Text);
            ogrenci1.final = Convert.ToDouble(textBox_final.Text);

            label_ortalama.Text = (ogrenci1.vize * 0.40 + ogrenci1.final * 0.60).ToString();


            //  label2.Text = textBox3.Text;
        }

        private void label_id_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_telefon_Click(object sender, EventArgs e)
        {

        }
    }
}
