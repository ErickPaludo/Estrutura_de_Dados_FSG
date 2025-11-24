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

        public void Empilhar(char valor)
        {
            var novo = new No(valor);
            novo.Proximo = _topo;
            _topo = novo;
        }

        public char Desempilhar()
        {
            if (_topo == null) return '\0';
            char valor = _topo.Valor;
            _topo = _topo.Proximo;
            return valor;
        }

        public bool EstaVazia()
        {
            return _topo == null;
        }
    }
}
