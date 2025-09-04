namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 6
            //Adicione ao carro um método para atualizar o ano, com validação.
            //Classe: Carro
            //Novo método: public void AtualizarAno(int novoAno)
            //Só altera se for um ano válido (>= 1886 e <= ano atual).
            //Uso no Main:
            Carro c = new Carro("VW", "Gol", 2010);
            c.ExibirDetalhes();
            c.AtualizarAno(2026);
            c.ExibirDetalhes();
            c.AtualizarAno(2021);
            c.ExibirDetalhes();
            //Saída esperada:
            //Ano inválido para o carro.
            //Carro: VW Gol (2021)
        }
    }
    public class Carro
    {
        private string _marca;
        private string _modelo;
        private int _ano;
        public string Marca { get; private set; }

        public string Modelo { get; private set; }
        public int Ano { get; private set; }
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
        public void AtualizarAno(int ano)
        {
            _ano = ano;
        }
    }
}
