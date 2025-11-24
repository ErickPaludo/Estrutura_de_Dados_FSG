using System;

namespace Aula
{
    class Pessoa
    {
        private string _nome;
        private int _idade;

        public string Nome => _nome;
        public int Idade => _idade;

        public Pessoa(string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }
    }

    class Agenda
    {
        private Pessoa _contato;

        public Pessoa Contato => _contato;

        public Agenda(Pessoa contato)
        {
            _contato = contato;
        }

        public void MostrarContato()
        {
            Console.WriteLine($"Contato: {_contato.Nome}, {_contato.Idade} anos");
        }
    }

    class Program
    {
        static void Main()
        {
            Pessoa p = new Pessoa("Bianca", 22);
            Agenda a = new Agenda(p);
            a.MostrarContato();
        }
    }
}
