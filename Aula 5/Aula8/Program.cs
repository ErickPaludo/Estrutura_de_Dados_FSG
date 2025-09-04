namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 8
            //Crie um programa que simule uma conta bancária com depósito e saque.
            //Classe: ContaBancaria
            //Atributos privados: _titular (string), _saldo (double)
            //Propriedades públicas: Titular, Saldo (get somente)
            //Construtor: public ContaBancaria(string titular, double saldoInicial)
            //Métodos:
            //Depositar(double valor)
            //Sacar(double valor) (retorna bool)
            //Uso no Main:
            ContaBancaria c = new ContaBancaria("Ana", 100.0);
            c.Depositar(50);
            bool ok = c.Sacar(120);
            Console.WriteLine($"Saque realizado? {ok}. Saldo: {c.Saldo}");
            //Saída esperada:
            //Saque realizado? True. Saldo: 30
        }
    }
    public class ContaBancaria
    {
        private string _titular;
        private double _saldo;
        public string Titular { get { return _titular; } private set; }
        public double Saldo { get { return _saldo; } private set; }

        public ContaBancaria(string titular, double saldo)
        {
            _titular = titular;
            _saldo = saldo;
        }
        public void Depositar(double valor)
        {
            _saldo += valor;
        }
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
                return false;

            _saldo -= valor;
            return true;
        }
    }
}
