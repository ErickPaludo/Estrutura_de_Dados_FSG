using System;

namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para criar uma pessoa e mostrar seu nome e idade.
            //Classe: Pessoa
            //Atributos privados: _nome(string), _idade(int)
            //Propriedades públicas: Nome(string), Idade(int) — com get/ set simples
            //Construtor: não obrigatório
            //Uso no Main
            Console.Write("Digite o nome: ");
            string n = Console.ReadLine();
            Console.Write("Digite a idade: ");
            int i = int.Parse(Console.ReadLine());
            Pessoa p = new Pessoa();
            p.Nome = n;
            p.Idade = i;
            Console.WriteLine($"Pessoa criada: {p.Nome}, {p.Idade} anos");
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
    }
}

