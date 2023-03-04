using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        char operador = ' ';
        decimal n1 = 0;
        decimal n2 = 0;
        int cont = 0;
        int igual = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void Resultado()
        {
            switch (operador)
            {
                case '-':
                    n1 = n1 - n2;
                    break;
                case '/':
                    n1 = n1 / n2;
                    break;
                case '*':
                    n1 = n1 * n2;
                    break;
                case '+':
                    n1 = n1 + n2;
                    break;
            }
        }

        public void operacao(char simbolo)
        {
            if (cont > 0)
            {
                n2 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                Resultado();
                operador = simbolo;
                txtResult.Text += simbolo;
                txtOperacao.Text += txtResult.Text;
            }
            else if (cont == 0)
            {
                operador = simbolo;
                n1 = decimal.Parse(txtOperacao.Text, CultureInfo.InvariantCulture);
                txtOperacao.Text += simbolo;
                txtResult.Text = "";

            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (cont > 0)
            {
                txtResult.Text += "0";
            }
            else
            {
                txtResult.Text += "0";
                txtOperacao.Text = txtResult.Text;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (cont > 0)
            {
                txtResult.Text += "1";
            }
            else
            {
                txtResult.Text += "1";
                txtOperacao.Text = txtResult.Text;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (cont > 0)
            {
                txtResult.Text += "2";
            }
            else
            {
                txtResult.Text += "2";
                txtOperacao.Text = txtResult.Text;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (cont > 0)
            {
                txtResult.Text += "3";
            }
            else
            {
                txtResult.Text += "3";
                txtOperacao.Text = txtResult.Text;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (cont > 0)
            {
                txtResult.Text += "4";
            }
            else
            {
                txtResult.Text += "4";
                txtOperacao.Text = txtResult.Text;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (cont > 0)
            {
                txtResult.Text += "5";
            }
            else
            {
                txtResult.Text += "5";
                txtOperacao.Text = txtResult.Text;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (cont > 0)
            {
                txtResult.Text += "6";
            }
            else
            {
                txtResult.Text += "6";
                txtOperacao.Text = txtResult.Text;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (cont > 0)
            {
                txtResult.Text += "7";
            }
            else
            {
                txtResult.Text += "7";
                txtOperacao.Text = txtResult.Text;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (cont > 0)
            {
                txtResult.Text += "8";
            }
            else
            {
                txtResult.Text += "8";
                txtOperacao.Text = txtResult.Text;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (cont > 0)
            {
                txtResult.Text += "9";
            }
            else
            { 
                txtResult.Text += "9";
                txtOperacao.Text = txtResult.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            txtOperacao.Text = "";
            cont = 0;
            igual = 0;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (igual == 0)
            {
                operacao('+');
            }
            else
            {
                txtOperacao.Text = txtResult.Text;
                operacao('+');
            }
            cont++;
            txtResult.Text = "";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (igual == 0)
            {
                operacao('-');
            }
            else
            {
                txtOperacao.Text = txtResult.Text;
                operacao('-');
            }
            cont++;
            txtResult.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (igual == 0)
            {
                operacao('/');
            }
            else
            {
                txtOperacao.Text = txtResult.Text;
                operacao('/');
            }
            cont++;
            txtResult.Text = "";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (igual == 0)
            {
                operacao('*');
            }
            else
            {
                txtOperacao.Text = txtResult.Text;
                operacao('*');
            }
            cont++;
            txtResult.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            n2 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
            txtOperacao.Text += txtResult.Text;
            Resultado();
                txtResult.Text = n1.ToString().Replace(",", ".");
            igual++;
            cont = 0;
        }

        private void btnDeci_Click(object sender, EventArgs e)
        {
            if (cont > 0)
            {
                txtResult.Text += ".";
            }
            else
            {
                txtResult.Text += ".";
                txtOperacao.Text = txtResult.Text;
            }
        }
    }
    }


