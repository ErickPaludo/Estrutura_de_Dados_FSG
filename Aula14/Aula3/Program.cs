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

            ArvoreBinaria.No raiz = arvore.ObterRaiz();

            Console.WriteLine("Raiz: " + raiz.Valor);
            Console.WriteLine("Filho esquerdo da raiz: " + raiz.Esquerda.Valor);
            Console.WriteLine("Filho direito da raiz: " + raiz.Direita.Valor);
            Console.WriteLine("Filho esquerdo de " + raiz.Esquerda.Valor + ": " + raiz.Esquerda.Esquerda.Valor);
        }
    }
}

