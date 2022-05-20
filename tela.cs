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

namespace ex001
{
    public partial class tela : Form
    {

        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";

        public tela()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tela_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor1 = Decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            operacao = "SOMA";
            lblOpc.Text = txtResultado.Text + " + ";
            txtResultado.Text = "";
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            valor2 = Decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                lblOpc.Text += txtResultado.Text + " = ";
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            } else if(operacao == "SUB"){
                lblOpc.Text += txtResultado.Text + " = ";
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            } else if (operacao=="MULT")
            {
                lblOpc.Text += txtResultado.Text + " = ";
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }else if(operacao == "DIV")
            {
                lblOpc.Text += txtResultado.Text + " = ";
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valor1 = Decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            operacao = "SUB";
            lblOpc.Text = txtResultado.Text + " - ";
            txtResultado.Text = "";
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            valor1 = Decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            operacao = "MULT";
            lblOpc.Text = txtResultado.Text + " x ";
            txtResultado.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            valor1 = Decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            operacao = "DIV";
            lblOpc.Text = txtResultado.Text + " / ";
            txtResultado.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblOpc.Text = "";
        }
    }
}
