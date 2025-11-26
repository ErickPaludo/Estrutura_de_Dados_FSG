using System;

namespace Aula
{
    public class Program
    {
        public static void Main()
        {
            ListaDupla lista = new ListaDupla();
            lista.InserirNoFinal(10);
            lista.InserirNoFinal(20);
            lista.InserirNoFinal(30);

            lista.MostrarDireto();
            lista.MostrarInverso();
        }
    }
}

