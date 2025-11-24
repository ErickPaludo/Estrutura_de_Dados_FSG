using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public class Pilha
    {
        private NoPilha _topo;

        public void Empilhar(int valor)
        {
            var novo = new NoPilha(valor);
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

        public bool EstaVazia() => _topo == null;
    }
}
