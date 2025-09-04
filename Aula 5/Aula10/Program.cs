namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 10
            //Crie um programa para cadastrar livros.
            //Classe: Livro
            //Atributos privados: _titulo (string), _autor (string)
            //Propriedades públicas: Titulo, Autor
            //Construtor: public Livro(string titulo, string autor)
            //Método: ExibirInfo()
            //Uso no Main:
            //Livro l = new Livro("O Guia do Mochileiro", "Douglas Adams");
            //l.ExibirInfo();
            //Saída esperada:
            //"O Guia do Mochileiro" de Douglas Adams
        }
    }
    public class Livro
    {
        private string _titular;
        private double _saldo;
        public string Titular { get { return _titular; } }
        public double Saldo { get { return _saldo; } }

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
