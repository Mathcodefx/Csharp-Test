using NotasAluno;
using System;
using System.Globalization;

namespace Curso
{
    class AlunosNotas
    {
        static void Main(String[] Args)
        {
            Alunos aluno1 = new Alunos();
            Alunos aluno2 = new Alunos();

            Console.Write("Nome do Aluno: ");
            aluno1.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno1.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno1.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno1.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aluno1.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno1.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + aluno1.Restante().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }



        }



    }



}