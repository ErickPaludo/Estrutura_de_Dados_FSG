namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 9
            //Adicione método para exibir saldo da conta.
            //Classe: ContaBancaria
            //Novo método: ExibirSaldo()
            //Uso no Main:
            ContaBancaria c = new ContaBancaria("João", 200.0);
            c.ExibirSaldo();
            c.Depositar(100);
            c.ExibirSaldo();
            //Saída esperada:
            //Titular: João - Saldo: 200
            //Titular: João - Saldo: 300
        } 
    }
    public class ContaBancaria
    {
        private string _titular;
        private double _saldo;
        public string Titular { get { return _titular; }}
        public double Saldo { get { return _saldo; }}

        public ContaBancaria(string titular, double saldo)
        {
            _titular = titular;
            _saldo = saldo;
        }
        public void ExibirSaldo() { Console.WriteLine($"Titular: {_titular} - Saldo: {_saldo}"); }
        public void Depositar(double valor)
        {
            _saldo += valor;
        }
    }

}
