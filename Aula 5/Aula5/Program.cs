namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 5
            //Crie um programa para cadastrar carros e mostrar seus detalhes.
            //Classe: Carro
            //Atributos privados: _marca (string), _modelo (string), _ano (int)
            //Propriedades públicas: Marca, Modelo, Ano
            //Construtor: public Carro(string marca, string modelo, int ano)
            //Método: public void ExibirDetalhes()
            //Uso no Main:
            Carro c1 = new Carro("Toyota", "Corolla", 2020);
            Carro c2 = new Carro("Fiat", "Argo", 2022);
            c1.ExibirDetalhes();
            c2.ExibirDetalhes();
            //Saída esperada:
            //Carro: Toyota Corolla (2020)
            //Carro: Fiat Argo (2022)

        }   
    }
    public class Carro
    {
        private string _marca;
        private string _modelo;
        private int _ano;
        public string Marca { get;set; }

        public string Modelo { get; set; }
        public int Ano { get; set; }
        public Carro(string marca, string modelo, int ano)
        {
            _marca = marca;
            _modelo = modelo;
            _ano = ano;
        }
        public void ExibirDetalhes()
        {
            Console.WriteLine($"Carro: {_marca} {_modelo} ({_ano})");
        }
    }
}
