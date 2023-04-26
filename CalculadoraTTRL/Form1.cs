using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraTTRL
{
    public partial class Form1 : Form
    {
        decimal a, b, resultado;
        string operacion = string.Empty;        

        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        public void validar(string dato,decimal numero)
        {
            if (resultado.Equals(0))
            {
                imprimir(dato);
                b = Convert.ToDecimal(pantalla.Text);
            }
            else
            {
                b = b + numero;
                imprimir(dato);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validar("1",1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            validar("2", 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            validar("3", 3);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
            //pantalla.Text = String.Empty;
            //pantalla.Text = "";
            a = 0;
            b = 0;
            resultado = 0;
            operacion = string.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            validar("4", 4);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SetOperation("+");
        }

        public void SetOperation(string symbol)
        {
            if (resultado.Equals(0))
            {
                a = Convert.ToDecimal(pantalla.Text);
                pantalla.Clear();
                operacion = symbol;
            }
            else
            {
                pantalla.Text = resultado.ToString()+" "+symbol;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            validar("5", 5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            validar("6", 6);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            validar("7", 7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            validar("8", 8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            validar("9", 9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            validar("0", 0);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            switch (operacion)
            {
                case "+":                    
                    resultado = a + b;
                    showResult();
                    break;
                case "-":
                    resultado = a - b;
                    showResult();
                    break;
                case "*":
                    resultado = a * b;
                    showResult();
                    break;
                case "/":
                    resultado = a / b;
                    showResult();
                    break;
                default:
                    break;
            }
        }

        public void showResult()
        {
            pantalla.Clear();
            imprimir(a.ToString() + " " + operacion + " " + b.ToString() + " = " + resultado);
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            SetOperation("-");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SetOperation("*");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SetOperation("/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void imprimir(string dato)
        {
            if (!dato.Equals(string.Empty))
            {
                pantalla.Text = pantalla.Text + dato;
            }
        }
    }
}
