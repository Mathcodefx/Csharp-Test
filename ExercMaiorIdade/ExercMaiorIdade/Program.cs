/*Implemente um programa no qual o usuário deverá informar o nome e a idade de três pessoas. O programa deverá informar o nome da pessoa que possuir a maior idade.
Regras que deverão ser seguidas para a implementação do algoritmo:
É obrigatório o uso de classe para representar uma pessoa e a mesma deverá possuir como propriedades (características) um nome e uma idade.
A classe também deverá possuir um método chamado ExibirDados. Esse método deverá exibir o nome e a idade da pessoa em questão.
Ao implementar a classe é obrigatório implementar dois construtores (Sobrecarga), um que não recebe parâmetro algum e outro que irá receber o nome e a idade de uma pessoa.*/



namespace ExercMaiorIdade
{
    class Program
    {
        static void Main(String[] Arg)
        {
            Pessoa info1 = new Pessoa();
            Console.WriteLine("Dados da pessoa N°1: ");
            Console.Write("Nome: ");
            info1.Name = Console.ReadLine();
            Console.Write("Idade: ");
            info1.Age=int.Parse(Console.ReadLine());

            Pessoa info2 = new Pessoa();
            Console.WriteLine("Dados da pessoa N°2: ");
            Console.Write("Nome: ");
            info2.Name = Console.ReadLine();
            Console.Write("Idade: ");
            info2.Age = int.Parse(Console.ReadLine());

            Pessoa info3 = new Pessoa();
            Console.WriteLine("Dados da pessoa N°3: ");
            Console.Write("Nome: ");
            info3.Name = Console.ReadLine();
            Console.Write("Idade: ");
            info3.Age = int.Parse(Console.ReadLine());


            if (info1.Age > info2.Age && info1.Age > info3.Age)
            {
                Console.WriteLine("Maior pessoa: ");
                info1.ExibirDados();

            } else if (info2.Age > info1.Age && info2.Age > info3.Age)
            {
                Console.WriteLine("Maior pessoa: ");
                info2.ExibirDados();
            }
            else
            {
                Console.WriteLine("Maior pessoa: ");
                info3.ExibirDados();
            }

        }





    }


}

