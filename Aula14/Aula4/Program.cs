using System;

namespace Aula
{
    public class Program
    {
        public static void Main()
        {
            ArvoreBinaria arvore = new ArvoreBinaria();

            arvore.Inserir(10);
            arvore.Inserir(5);
            arvore.Inserir(12);
            arvore.Inserir(3);

            Console.WriteLine("Busca por 12: " + arvore.Contem(12));
            Console.WriteLine("Busca por 7: " + arvore.Contem(7));
        }
    }
}

