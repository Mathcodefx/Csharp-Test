/* programa de teste usando static members, simulando compra de dolares */ 

using ConversorDolar;
using System;
using System.Globalization;

namespace CotaçaoDolar
{
    class Program
    {
        static void Main(String[]Args)
        {
            

            Console.WriteLine("Qual é a cotação do dolar? ");
            double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dolares para comprar? ");
            double Quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.Conversor(Preco, Quantidade);


            Console.WriteLine("Valor a ser pago em reais = "+ result.ToString("F2", CultureInfo.InvariantCulture));


        }



    }



}