using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DadosFuncionario
{
    internal class InfoFuncionarios
    {

        public String Name;
        public double SalarioBruto;
        public double Imposto;
       
        

        public double Salario()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcent)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcent / 100.0);
        }

        public override string ToString()
        {
            return Name
            + ", R$ "
            + Salario().ToString("F2", CultureInfo.InvariantCulture);
        }






    }
}
