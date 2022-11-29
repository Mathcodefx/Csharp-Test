/* Exercicio criando um vet e armazenando dados neles, depois mostrar os dados em ordem crescente */


using ExercVet;

namespace RoomVet
{
    class Program
    {
        static void Main(String[] args)
        {
            Info[] vet = new Info[10];

            Console.WriteLine("Quantos quartos serao ocupados? ");
            int n=int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Info(nome, email);

            }
            Console.WriteLine();
            Console.Write("Busy Rooms");

            for (int i = 1; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + ": " + vet[i]);
                }
            }        


            }

        }

    }


