
using System.Globalization;

namespace ListasCourse
{
    class Funcionarios
    {
       public string Nome { get; set; }
       public  double Salario { get; private set; }
       public int Id { get; set; }

     public Funcionarios(string nome, double salario, int id)
        {
            Id = id;
            Salario = salario;
            Nome = nome;
        }

        public void AumentarSalario(double porcentagem)
        {
            
             Salario+=Salario*porcentagem/100.0;
        }

      
        public override string ToString()
        {
            return
            "Id: " + Id + ", Nome:" + Nome
                + ", Salario: $" + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
