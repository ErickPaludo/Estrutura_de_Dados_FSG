using System;

namespace Aula
{
    public class Program
    {
        public static void Main()
        {
            ListaDupla lista = new ListaDupla();
            lista.InserirNoFinal(5);
            lista.InserirNoFinal(10);
            lista.InserirNoFinal(20);
            lista.InserirNoFinal(30);

            Console.WriteLine(lista.ObterQuantidade());
            Console.WriteLine(lista.ObterPosicao(20));
            Console.WriteLine(lista.ObterPosicao(999));
        }
    }
}

