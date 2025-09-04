namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 3
            //Crie um programa para cadastrar um produto e mostrar seu nome e preço.
            //Classe: Produto
            //Atributos privados: _nome (string), _preco (double)
            //Propriedades públicas: Nome, Preco
            //Construtor: public Produto(string nome, double preco)
            //Uso no Main:
            Console.Write("Nome do produto: ");
            string n = Console.ReadLine();
            Console.Write("Preço: ");
            double pr = double.Parse(Console.ReadLine());
            Produto prod = new Produto(n, pr);
            Console.WriteLine($"Produto: {prod.Nome} - Preço: {prod.Preco}");
            //Saída esperada:
            //Nome do produto: Caneca
            //Preço: 39.9
            //Produto: Caneca - Preço: 39,9
        }
    }
    public class Produto
    {
        private string _nome;
        private double _preco;
        public string Nome
        {
            get
            {
                return _nome;
            }
        }  
        public double Preco
        {
            get
            {
                return _preco;
            }
        }
        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
        }
    }
}
