/* Fazer um programa para ler um numero inteiro de dados (id, nome e salario) de funcionarios. Não pode haver repetição de id.
 * Depois efetuar um aumento no salarios atraves da id */


using ListasCourse;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(String[] Args)
        {
            Console.WriteLine("Quantos funcionarios serao registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionarios> list = new List<Funcionarios>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionario # " + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());
                list.Add(new Funcionarios(nome, salario, id));
            }
            Console.WriteLine();


            Console.Write("Entre com o empregado que ira receber a porcentagem: ");
            int searchId = int.Parse(Console.ReadLine());

            Funcionarios emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentarSalario(percentage);
            }
            else
            {
                Console.WriteLine("Essa id não existe!");
            }

            Console.WriteLine("Lista atualizada de empregados:");
            foreach (Funcionarios obj in list)
            {
                Console.WriteLine(obj);
            }


        }









    }
}