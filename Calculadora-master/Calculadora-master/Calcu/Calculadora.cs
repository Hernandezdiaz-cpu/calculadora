using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcu
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.Cls_divi obj = new Clases.Cls_divi();
        Clases.Cls_multi obj2 = new Clases.Cls_multi();
        Clases.Cls_resta obj3 = new Clases.Cls_resta();
        Clases.Cls_suma obj4 = new Clases.Cls_suma();

        private void btnN0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btn_deci_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_mas_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btn_divi_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(textBox1.Text);

            double sum;
            double rest;
            double multi;
            double divi;

            switch(operador)
            {
                case "+":
                    sum = obj4.Sumar((primero), (segundo));
                    textBox1.Text = sum.ToString();
                    break;

                case "-":
                    rest = obj3.Restar((primero), (segundo));
                    textBox1.Text = rest.ToString();
                    break;

                case "*":
                    multi = obj2.Multiplicar((primero), (segundo));
                    textBox1.Text = multi.ToString();
                    break;

                case "/":
                    divi = obj.Dividir((primero), (segundo));
                    textBox1.Text = divi.ToString();
                    break;
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
                textBox1.Text = "";
            else
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }
    }
}
