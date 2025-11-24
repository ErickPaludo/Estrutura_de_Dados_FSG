using System;

namespace Aula
{
    public class Program
    {
        public static void Main()
        {
            var fila = new Fila();

            fila.Enfileirar(10);
            fila.Enfileirar(20);
            fila.Enfileirar(30);

            fila.Mostrar();

            fila.Esvaziar();

            fila.Mostrar();

            Console.WriteLine(fila.EstaVazia());
        }
    }
}

