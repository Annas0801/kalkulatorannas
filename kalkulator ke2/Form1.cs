using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator_ke2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            labelhasil.Text = "";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Di Isi Dahulu");

            }
            else
            {
                int a, b, c;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = a + b;
                this.labelhasil.Text = c.ToString();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            labelhasil.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Di Isi Dahulu");

            }
            else
            {
                int a, b, c;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = a - b;
                this.labelhasil.Text = c.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Di Isi Dahulu");

            }
            else
            {
                int a, b, c;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = a * b;
                this.labelhasil.Text = c.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Di Isi Dahulu");

            }
            else
            {
                int a, b, c;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = a / b;
                this.labelhasil.Text = c.ToString();
            }
        }
    }
}
