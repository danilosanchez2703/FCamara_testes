using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio06
{
    public partial class frmCalculo : Form
    {
        public frmCalculo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal ladoA = 0;
            decimal ladoB = 0;
            decimal area = 0;
            decimal perimetro = 0;

            if (ValidaValores(out ladoA, out ladoB))
            {
                TRetangulo retangulo = new TRetangulo(ladoA, ladoB);
                area = retangulo.CalcularArea();
                perimetro = retangulo.CalcularPerimetro();

                MessageBox.Show("Necessários " + area.ToString()+"m² de Piso e "+perimetro.ToString()+"m de Rodapé.");
            }
        }

        private bool ValidaValores(out decimal AladoA, out decimal AladoB)
        {
            decimal ladoA = 0;
            decimal ladoB = 0;
            AladoA = 0;
            AladoB = 0;

            bool retorno = true;

            if (!decimal.TryParse(txtLadoA.Text, out ladoA) || (!decimal.TryParse(txtLadoB.Text, out ladoB)))
            {
                MessageBox.Show("Valores digitados inválidos!");
                retorno = false;
            }
            if (retorno && ((ladoA < 1) || (ladoB < 1)))
            {
                MessageBox.Show("Favor informar valores maiores que zero!");
                retorno = false;
            }

            if (retorno)
            {
                AladoA = ladoA;
                AladoB = ladoB;
            }

            return retorno;
        }
    }
}
