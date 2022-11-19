/* programa para pratica de "construtores, encapsulamento, properties e outros" */

using BankAcc11;
using System.Globalization;

namespace BankTest
{
    class Program
    {
        static void Main(String[] Args)
        {
            InfoBank p = new InfoBank("Titular", 0, 0);

            Console.Write("Nome do titular: ");
            p.Nome = Console.ReadLine();
            Console.Write("Insira os dados da conta: ");
            p.Conta = int.Parse(Console.ReadLine());
            Console.Write("Haverá um deposito inicial? (S/N)");
            p.Questao = Console.ReadLine();
            
            
            Console.WriteLine("Dados da Conta: ");
            Console.Write(p.ToString());
          
            Console.WriteLine();

            Console.Write("Entre com um valor para deposito: ");
            p.Depositar();
            Console.WriteLine("Dados atualizados: ");
            Console.Write(p.ToString());

            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            p.Saque();
            Console.WriteLine("Dados atualizados: ");
            Console.Write(p.ToString());












        }


    }


}