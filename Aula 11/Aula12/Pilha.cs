using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public class Pilha
    {
        private No _topo;

        public void Empilhar(int valor)
        {
            var novo = new No(valor);
            novo.Proximo = _topo;
            _topo = novo;
        }

        public int Desempilhar()
        {
            if (_topo == null) return -1;
            int valor = _topo.Valor;
            _topo = _topo.Proximo;
            return valor;
        }

        public int Topo()
        {
            if (_topo == null) return -1;
            return _topo.Valor;
        }

        public void Mostrar()
        {
            if (_topo == null)
            {
                Console.WriteLine("Pilha vazia");
                return;
            }

            var atual = _topo;
            while (atual != null)
            {
                Console.Write(atual.Valor);
                if (atual.Proximo != null) Console.Write(",");
                atual = atual.Proximo;
            }
            Console.WriteLine();
        }
    }
}
