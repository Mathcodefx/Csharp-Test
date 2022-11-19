using System.Globalization;


namespace BankAcc11
{
    class InfoBank
    {
        private string _titular;
        private int _conta;
        private double _saldo;
        private string _questao;
        private double _deposito;
        private double _saque;

        public InfoBank(string titular, int conta, double saldo)
        {
            _titular = titular; 
            _conta = conta; 
            _saldo = saldo;
        }

        public InfoBank()
        {

        }

        public string Nome
        {
            get { return _titular; }    
            set { _titular = value; }
        }

        public int Conta
        {
            get { return _conta; }
            set { _conta = value; }
        }

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public double ValorInicial
        {
            set { _deposito = value; }
        }

        public string Questao
        {
            set 
            { _questao = value;
                if (value == "S" || value == "s")
                {
                    Console.WriteLine("Qual valor do deposito inicial: ");
                    _deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                     double conta = _saldo + _deposito;
                    _saldo = conta;
                }
            }
        }

        public double Depositar()
        {
            _deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return _saldo += _deposito;

        }

        public double Saque()
        {
            _saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return _saldo -= _saque;
        }

        public override string ToString()
        {
            return
            "Conta: " + Conta + ", Titular:" + Nome 
                + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
