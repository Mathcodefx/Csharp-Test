using DadosFuncionario;
using System;
using System.Globalization;


namespace Program
{
    class DadosFuncionario
    {
        static void Main(String[] Args)
        {
            InfoFuncionarios f1 = new InfoFuncionarios();

            Console.Write("Nome: ");
            f1.Name = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Write("Funcionario: " +f1);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f1.AumentarSalario(porcent);
            Console.WriteLine();

            Console.WriteLine("Dados Atualizados: " + f1);



        }



    }



}