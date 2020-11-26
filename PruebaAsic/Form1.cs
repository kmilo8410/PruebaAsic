using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaAsic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char Operador;
        private void btnResultado_Click(object sender, EventArgs e)
        {
            //txtEcuacion.Text = "1+2+4";
            if (!string.IsNullOrEmpty(txtEcuacion.Text))
            {

                string [] valores = txtEcuacion.Text.Split(this.Operador);
                switch (this.Operador)
                {
                    case '+':
                        txtEcuacion.Text = Suma(valores).ToString();
                        break;
                    case '-':
                        txtEcuacion.Text = Resta(valores).ToString();
                        break;
                    case '*':
                        txtEcuacion.Text = Multiplicar(valores).ToString();
                        break;
                    case '/':
                        txtEcuacion.Text = Dividir(valores).ToString();
                        break;

                }

            }           
        }

        //private decimal suma(decimal primerNumero, decimal segundoNumero)
        //{
        //    return (primerNumero + segundoNumero);
        //}
        private decimal Suma(string[] cadena)
        {
            decimal resultado = 0;
            for(int i =0; i < cadena.Length; i++)
            {
                resultado += Convert.ToDecimal(cadena[i]);
            }

            return resultado;
        }

        private decimal Resta(string[] cadena)
        {
            decimal resultado = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                resultado -= Convert.ToDecimal(cadena[i]);
            }

            return resultado;
        }

        private decimal Multiplicar(string[] cadena)
        {
            decimal resultado = 1;
            for (int i = 0; i < cadena.Length; i++)
            {
                resultado *= Convert.ToDecimal(cadena[i]);
            }

            return resultado;
        }

        private decimal Dividir(string[] cadena)
        {
            decimal resultado = Convert.ToDecimal(cadena[0]);
           
            for (int i = 1; i < cadena.Length; i++)
            {
                if(!cadena[i].Equals('0'))
                {
                    resultado /= Convert.ToDecimal(cadena[i]);
                }
                else
                {
                    resultado = 0;
                    break;
                }
            }

            return resultado;
        }

        private decimal RaizCaudrada(string[] cadena)
        {
            decimal resultado = 1;
            for (int i = 0; i < cadena.Length; i++)
            {
                resultado *= Convert.ToDecimal(cadena[i]);
            }

            return resultado;
        }
        private void btnSumar_Click(object sender, EventArgs e)
        {
            this.Operador = Convert.ToChar(btnSumar.Text.Substring(0, 1));
            txtEcuacion.Text += btnSumar.Text;
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            this.Operador = Convert.ToChar(btnRestar.Text.Substring(0,1));
            txtEcuacion.Text += btnRestar.Text;

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            this.Operador = Convert.ToChar(btnMultiplicar.Text.Substring(0, 1));
            txtEcuacion.Text += btnMultiplicar.Text;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            this.Operador = Convert.ToChar(btnDividir.Text.Substring(0, 1));
            txtEcuacion.Text += btnDividir.Text;

        }

        private void btnNumeroUno_Click(object sender, EventArgs e)
        {
            txtEcuacion.Text += btnNumeroUno.Text;
        }

        private void btnNumeroDos_Click(object sender, EventArgs e)
        {
            txtEcuacion.Text += btnNumeroDos.Text;

        }

        private void btnNumeroTres_Click(object sender, EventArgs e)
        {
            txtEcuacion.Text += btnNumeroTres.Text;

        }

        private void btnNumeroCuatro_Click(object sender, EventArgs e)
        {
            txtEcuacion.Text += btnNumeroCuatro.Text;

        }

        private void btnNumeroCinco_Click(object sender, EventArgs e)
        {
            txtEcuacion.Text += btnNumeroCinco.Text;

        }

        private void btnNumeroSeis_Click(object sender, EventArgs e)
        {
            txtEcuacion.Text += btnNumeroSeis.Text;

        }

        private void btnNumeroSiete_Click(object sender, EventArgs e)
        {
            txtEcuacion.Text += btnNumeroSiete.Text;

        }

        private void btnNumeroOcho_Click(object sender, EventArgs e)
        {
            txtEcuacion.Text += btnNumeroOcho.Text;

        }

        private void btnNumeroNueve_Click(object sender, EventArgs e)
        {
            txtEcuacion.Text += btnNumeroNueve.Text;
        }

        private void btnNumeroCero_Click(object sender, EventArgs e)
        {
            txtEcuacion.Text += btnNumeroCero.Text;
        }
    }

}

