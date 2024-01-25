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
    public partial class Calculadora : Form
    {
        

        public bool virgula = false;
        
        public string op = "";
       
        Operacoes Conta;
       


        public Calculadora()
        {
            InitializeComponent();

            Conta = new Operacoes();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text+= "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text+= "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text+= "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text+= "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text+= "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text+= "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conta.a=Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            virgula = false;
            op = "*";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Conta.a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            virgula = false;
            op = "-";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Conta.a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            virgula = false;
            op = "+";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Conta.a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            virgula = false;
            op = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") 
            {
                Conta.b = Convert.ToDouble(textBox1.Text);
            }
           
           
            switch (op)
            {
                case "+":
                    
                    double adicao = Conta.Adicao();
                   
                    textBox1.Text = Convert.ToString(adicao);
                   
                    break;

                case "-":

                    double subtracao= Conta.Subtracao();

                    textBox1.Text = Convert.ToString(subtracao);


                    break;
                
                case "*":

                    double mult = Conta.Mult();

                    textBox1.Text = Convert.ToString(mult);


                    break;

                case "/":
                    
                    double div = Conta.Div();

                    textBox1.Text = Convert.ToString(div);

                    break;

                case "Exponencial":

                    double Expo = Conta.Exponencial();

                    textBox1.Text = Convert.ToString(Expo);

                    break;

                
                case "Porcentagem":

                    double Porc = Conta.Porcentagem();

                    textBox1.Text = Convert.ToString(Porc);

                    break;



            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
           
            op = "";
            virgula = false;
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(virgula==false)
            {
                textBox1.Text += ",";
                virgula = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Conta.a = Convert.ToDouble(textBox1.Text);

            double raiz = Conta.Raiz();

            textBox1.Text = Convert.ToString(raiz);

            virgula = false;
           
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Conta.a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            virgula = false;
            op = "Exponencial";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Conta.a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            virgula = false;
            op = "Porcentagem";
        }
    }
}
