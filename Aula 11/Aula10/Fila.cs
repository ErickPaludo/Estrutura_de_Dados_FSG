using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public class Fila
    {
        private No _primeiro;
        private No _ultimo;

        public void Enfileirar(int valor)
        {
            var novo = new No(valor);
            if (_primeiro == null)
            {
                _primeiro = novo;
                _ultimo = novo;
            }
            else
            {
                _ultimo.Proximo = novo;
                _ultimo = novo;
            }
        }

        public int Desenfileirar()
        {
            if (_primeiro == null) return -1;
            int valor = _primeiro.Valor;
            _primeiro = _primeiro.Proximo;
            if (_primeiro == null) _ultimo = null;
            return valor;
        }

        public void Mostrar()
        {
            if (_primeiro == null)
            {
                Console.WriteLine("Fila vazia");
                return;
            }

            var atual = _primeiro;
            while (atual != null)
            {
                Console.Write(atual.Valor);
                if (atual.Proximo != null) Console.Write(",");
                atual = atual.Proximo;
            }
            Console.WriteLine();
        }

        public void Esvaziar()
        {
            _primeiro = null;
            _ultimo = null;
        }

        public bool EstaVazia()
        {
            return _primeiro == null;
        }
    }
}