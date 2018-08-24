using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    public class TRetangulo
    {
        public decimal LadoA { get; set; }
        public decimal LadoB { get; set; }

        public void MudarValorLados()
        {
            decimal ladoAOld = LadoA;
            LadoA = LadoB;
            LadoB = ladoAOld;
        }

        public decimal CalcularArea()
        {
            return (LadoA * LadoB);
        }

        public decimal CalcularPerimetro()
        {
            return (2 * (LadoA + LadoB));
        }

        public TRetangulo (decimal ALadoA, decimal ALadoB)
        {
            if (ALadoA < 0)
            {
                ALadoA = 0;
            }

            if (ALadoB < 0)
            {
                ALadoB = 0;
            }
            LadoA = ALadoA;
            LadoB = ALadoB;

        }

    }
}
