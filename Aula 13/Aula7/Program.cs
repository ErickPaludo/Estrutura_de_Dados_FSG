using System;

namespace Aula
{
    public class Program
    {
        public static void Main()
        {
            var fila = new Fila();

            fila.Enfileirar(20);
            fila.Enfileirar(30);
            fila.Enfileirar(40);

            fila.Mostrar();

            Console.WriteLine(fila.Tamanho());
            Console.WriteLine(fila.ObterPosicao(30));
            Console.WriteLine(fila.ObterPosicao(99));
        }
    }
}

