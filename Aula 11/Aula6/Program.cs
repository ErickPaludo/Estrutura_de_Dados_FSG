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

            int removido = fila.Desenfileirar();
            Console.WriteLine(removido);

            fila.Mostrar();
        }
    }
}

