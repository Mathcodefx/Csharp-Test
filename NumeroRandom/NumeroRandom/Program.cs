/* criando sistema de numeros rands sem repetir os numeros */

using System;

namespace Testando
{
    class Program
    {
        static void Main(String[] Args)
        {
            Random NumRandom = new Random();


            Console.Write("Digite a quantidade de numeros a serem sorteados: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Digite o minimo de numeros a serem sorteados: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Digite o maximo de numeros a serem sorteados: ");
            int max = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" " + NumRandom.Next(min, max));
            }
        }



    }


}