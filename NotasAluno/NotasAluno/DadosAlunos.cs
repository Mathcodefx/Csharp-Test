using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasAluno
{
    internal class Alunos
    {
        public String Nome;
        public double nota1, nota2, nota3;
        
        public double NotaFinal()
        {
            return (nota1 + nota2 + nota3);
        }

        public bool Aprovado()
        {
            if (NotaFinal()>=60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Restante()
        {
            if (Aprovado())
            {
                return 0.00;
            }
            else
            {
                return 60-NotaFinal();
            }

        }
    }
}
