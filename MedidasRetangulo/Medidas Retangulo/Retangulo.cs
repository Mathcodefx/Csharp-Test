using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medidas_Retangulo
{
    internal class Medidas
    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return 2.0 * (Altura + Largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Altura*Altura) + (Largura*Largura));
        }

    }
}
