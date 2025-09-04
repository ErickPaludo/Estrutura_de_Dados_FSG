namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 4
            //Adicione ao produto um método para exibir seus dados.
            //Classe: Produto
            //Mesmo do exercício anterior
            //Método: public void ExibirInfo() → imprime nome e preço
            //Uso no Main:
            Produto p = new Produto("Camiseta", 80.0);
            p.ExibirInfo();
            //Saída esperada:
            //Produto: Camiseta - Preço: 80
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
        public void ExibirInfo()
        {
            Console.WriteLine($"Produto: {Nome} - Preço: {Preco}");
        }
    }

}
