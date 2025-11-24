namespace Aula
{
    using System;

    class Funcionario
    {
        private string _nome;
        private double _salario;

        public string Nome => _nome;
        public double Salario => _salario;

        public Funcionario(string nome, double salario)
        {
            _nome = nome;
            _salario = salario;
        }

        public void AumentarSalario(double percentual)
        {
            _salario += _salario * (percentual / 100);
        }
    }

    class Program
    {
        static void Main()
        {
            Funcionario f = new Funcionario("Rita", 3000);
            f.AumentarSalario(10);
            Console.WriteLine($"{f.Nome} - Novo salário: {f.Salario}");
        }
    }
}
