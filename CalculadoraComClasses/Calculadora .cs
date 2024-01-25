using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public bool soma;
        public bool subtracao;
        public bool multiplicacao;
        public bool divisao;
        public bool virgula;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (soma== false )
            {
                TextBox1.Text += "+";
                soma= true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (divisao == false)
            {
                TextBox1.Text += "/";
                divisao= true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "6";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (virgula == false)
            {
                TextBox1.Text += ",";
                virgula = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            TextBox1.Text+= "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (subtracao == false)
            {
                TextBox1.Text += "-";
                subtracao = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (multiplicacao == false)
            {
                TextBox1.Text += "X";
                multiplicacao= true;
            }
        }
    }
}
