using System;

namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para cadastrar pessoas já no momento da criação do objeto.
            //Classe: Pessoa
            //Atributos privados: _nome (string), _idade (int)
            //Propriedades públicas: Nome (string), Idade (int)
            //Construtor: public Pessoa(string nome, int idade)
            //Uso no Main:
            Pessoa p1 = new Pessoa("João", 25);
            Pessoa p2 = new Pessoa("Carla", 30);
            Console.WriteLine($"Pessoa criada: {p1.Nome}, {p1.Idade} anos");
            Console.WriteLine($"Pessoa criada: {p2.Nome}, {p2.Idade} anos");
            //Saída esperada:
            //Pessoa criada: João, 25 anos
            //Pessoa criada: Carla, 30 anos
        }
    }
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }
        public Pessoa(string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }
    }
}
