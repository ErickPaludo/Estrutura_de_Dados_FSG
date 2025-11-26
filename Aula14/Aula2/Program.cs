using System;

namespace Aula
{
    public class Program
    {
        public static void Main()
        {
            ArvoreBinaria arvore = new ArvoreBinaria();
            arvore.Inserir(10);

            Console.WriteLine(arvore.ObterRaiz());
        }
    }
}

