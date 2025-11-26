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
            arvore.Inserir(7);
            arvore.Inserir(15);

            Console.WriteLine("Antes da remoção:");
            arvore.ImprimirEmOrdem();

            arvore.Remover(3);

            Console.WriteLine("Depois da remoção do nó folha 3:");
            arvore.ImprimirEmOrdem();
        }
    }
}

