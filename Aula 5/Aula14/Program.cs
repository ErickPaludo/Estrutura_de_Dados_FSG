using System;

namespace Aula
{
    class Cachorro
    {
        private string _nome;
        private string _raca;

        public string Nome => _nome;
        public string Raca => _raca;

        public Cachorro(string nome, string raca)
        {
            _nome = nome;
            _raca = raca;
        }

        public void Latir()
        {
            Console.WriteLine($"Au Au! Eu sou {_nome} ({_raca}).");
        }
    }

    class Program
    {
        static void Main()
        {
            Cachorro c1 = new Cachorro("Toby", "SRD");
            Cachorro c2 = new Cachorro("Luna", "Labrador");

            c1.Latir();
            c2.Latir();
        }
    }
}
