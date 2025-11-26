using System;

namespace Aula
{
    public class Program
    {
        public static void Main()
        {
            var pilha = new Pilha();

            pilha.Empilhar(10);
            pilha.Empilhar(20);
            pilha.Empilhar(30);

            pilha.Mostrar();

            Console.WriteLine(pilha.Topo());
        }
    }
}

