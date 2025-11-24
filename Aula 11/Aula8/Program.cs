using System;

namespace Aula
{
    public class Program
    {
        public static void Main()
        {
            var filaA = new Fila();

            filaA.Enfileirar(10);
            filaA.Enfileirar(20);
            filaA.Enfileirar(30);

            var filaB = filaA.Clonar();

            filaA.Mostrar();
            filaB.Mostrar();

            filaA.Desenfileirar();

            filaA.Mostrar();
            filaB.Mostrar();
        }
    }
}

