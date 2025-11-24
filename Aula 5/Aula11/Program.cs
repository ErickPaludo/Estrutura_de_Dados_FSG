namespace Aula
{
    using System;

    class Calculadora
    {
        public int Somar(int a, int b) => a + b;
        public int Subtrair(int a, int b) => a - b;
        public int Multiplicar(int a, int b) => a * b;
        public int Dividir(int a, int b) => a / b;
    }

    class Program
    {
        static void Main()
        {
            Calculadora calc = new Calculadora();
            Console.WriteLine($"Soma: {calc.Somar(5, 3)}");
            Console.WriteLine($"Divisão: {calc.Dividir(10, 2)}");
        }
    }
}
