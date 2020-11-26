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
    public partial class ValorAbsoluto : Form
    {
        public ValorAbsoluto()
        {
            InitializeComponent();
        }

        private void btnValorAbsoluto_Click(object sender, EventArgs e)
        {
            int resultado = CalcularValorAbsolutoMatriz(Convert.ToInt32(txtValor.Text));
        }

        private int CalcularValorAbsolutoMatriz(int valor)
        {
            int valorinicial = 1;
            int  [,] matrix = new int [valor,valor];

            for (int i = 0; i < valor; i++)
            {
                for (int j = 0; j < valor; j++)
                {
                    Random r = new Random();

                    matrix[i,j] = r.Next(valorinicial, 100);
                    valorinicial += matrix[i, j];
                }
            }


            int diagonalIzqDer = 0;
            int diagonalDerIzq = 0 ;
            for (int i = 0; i < valor; i++)
            {
                for (int j = i; j <= valor; j++)
                {
                    diagonalIzqDer += matrix[i, j]; 
                    break;
                }
            }
            int band = valor -1 ;
            for (int i = 0; i < valor; i++)
            {
                for (int j = band; j >= 0; j--)
                {
                    diagonalDerIzq += matrix[i, j]; //= valorInicial + 1;
                    break;
                }
                band--;
            }



            return (diagonalIzqDer - diagonalIzqDer);
        }

       

    }
}
