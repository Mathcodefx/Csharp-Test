using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDolar
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double Conversor(double Preco, double Quantidade)
        {
            double total = Preco * Quantidade;
            return total + total * Iof / 100.0;
        }
    }
}
