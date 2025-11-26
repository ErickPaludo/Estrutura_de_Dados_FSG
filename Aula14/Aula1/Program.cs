using System;

namespace Aula
{
    public class Program
    {
        public static void Main()
        {
            ArvoreBinaria.No raiz = new ArvoreBinaria.No(5);

            Console.WriteLine(raiz.Valor);
            Console.WriteLine(raiz.Esquerda == null);
            Console.WriteLine(raiz.Direita == null);
        }
    }
}

