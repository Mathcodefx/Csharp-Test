using Medidas_Retangulo;
using System;
using System.Globalization;


namespace Retangulo
{
    class program
    {
        static void Main(String[] Args)
        {
            Medidas r1 = new Medidas();

            Console.WriteLine("Entre a altura e largura do retangulo: ");
            r1.Altura=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + r1.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + r1.Perimetro().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + r1.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }


    }


}