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

            arvore.ImprimirEmOrdem();
        }
    }
}

