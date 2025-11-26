using System;

namespace Aula
{
    public class Program
    {
        public static string DecimalParaBinario(int numero)
        {
            if (numero == 0) return "0";
            var pilha = new Pilha();

            while (numero > 0)
            {
                pilha.Empilhar(numero % 2);
                numero /= 2;
            }

            string binario = "";
            while (!pilha.EstaVazia())
            {
                binario += pilha.Desempilhar();
            }

            return binario;
        }

        public static void Main()
        {
            int entrada = 13;
            string resultado = DecimalParaBinario(entrada);
            Console.WriteLine(resultado); // Saída: 1101
        }
    }
}

