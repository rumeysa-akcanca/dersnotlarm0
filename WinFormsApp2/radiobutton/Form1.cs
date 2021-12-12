using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                int sayı1, sayı2, sonuc;
                sayı1 = Convert.ToInt32(textBox1.Text);
                sayı2 = Convert.ToInt32(textBox2.Text);
                sonuc = sayı1 + sayı2;
                label1.Text = sonuc.ToString();
                //label1.Visible = false;
            }
            else if (radioButton2.Checked)
            {
                int sayı1, sayı2, sonuc;
                sayı1 = Convert.ToInt32(textBox1.Text);
                sayı2 = Convert.ToInt32(textBox2.Text);
                sonuc = sayı1 - sayı2;
                label2.Text = sonuc.ToString();

            }
            else if (radioButton3.Checked)
            {
                int sayı1, sayı2, sonuc;
                sayı1 = Convert.ToInt32(textBox1.Text);
                sayı2 = Convert.ToInt32(textBox2.Text);
                sonuc = sayı1 * sayı2;
                label3.Text = sonuc.ToString();

            }

            else
            {
                int sayı1, sayı2, sonuc;
                sayı1 = Convert.ToInt32(textBox1.Text);
                sayı2 = Convert.ToInt32(textBox2.Text);
                sonuc = sayı1 - sayı2;
                label4.Text = sonuc.ToString();


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ekran önüne geldiğinde yapılması istenen şeyler
        }
    }
}
