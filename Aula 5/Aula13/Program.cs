using System;

namespace Aula
{
    class Retangulo
    {
        private double _largura;
        private double _altura;

        public double Largura => _largura;
        public double Altura => _altura;

        public Retangulo(double largura, double altura)
        {
            _largura = largura;
            _altura = altura;
        }

        public double CalcularArea()
        {
            return _largura * _altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (_largura + _altura);
        }
    }

    class Program
    {
        static void Main()
        {
            Retangulo r = new Retangulo(3.5, 2.0);
            Console.WriteLine($"Área: {r.CalcularArea()}");
            Console.WriteLine($"Perímetro: {r.CalcularPerimetro()}");
        }
    }
}
