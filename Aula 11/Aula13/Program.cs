using System;

namespace Aula
{
    public class Program
    {
        public static void Main()
        {
            string entrada = "ABCDE";
            var pilha = new Pilha();

            foreach (char c in entrada)
            {
                pilha.Empilhar(c);
            }

            string invertida = "";
            while (!pilha.EstaVazia())
            {
                invertida += pilha.Desempilhar();
            }

            Console.WriteLine(invertida);
        }
    }
}

