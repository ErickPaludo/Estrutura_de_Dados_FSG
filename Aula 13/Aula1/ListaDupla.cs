using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public class ListaDupla
    {
        private No _primeiro;
        private No _ultimo;

        public void InserirNoFinal(int valor)
        {
            No novo = new No(valor);
            if (_primeiro == null)
            {
                _primeiro = novo;
                _ultimo = novo;
            }
            else
            {
                _ultimo.Proximo = novo;
                novo.Anterior = _ultimo;
                _ultimo = novo;
            }
        }

        public void MostrarDireto()
        {
            No atual = _primeiro;
            while (atual != null)
            {
                Console.Write(atual.Valor + " ");
                atual = atual.Proximo;
            }
            Console.WriteLine();
        }

        public void MostrarInverso()
        {
            No atual = _ultimo;
            while (atual != null)
            {
                Console.Write(atual.Valor + " ");
                atual = atual.Anterior;
            }
            Console.WriteLine();
        }
    }
}
