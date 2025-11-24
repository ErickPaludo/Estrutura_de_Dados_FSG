using System;

namespace Aula
{
    public class Program
    {
        public static void Main()
        {
            var fila = new FilaPrioridade();

            fila.Enfileirar(10, 1);
            fila.Enfileirar(20, 3);
            fila.Enfileirar(30, 2);

            fila.Mostrar();

            int removido = fila.Desenfileirar();
            Console.WriteLine(removido);

            fila.Mostrar();
        }
    }
}

