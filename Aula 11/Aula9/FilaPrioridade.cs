using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public class FilaPrioridade
    {
        private No _primeiro;

        public void Enfileirar(int valor, int prioridade)
        {
            var novo = new No(valor, prioridade);

            if (_primeiro == null || prioridade > _primeiro.Prioridade)
            {
                novo.Proximo = _primeiro;
                _primeiro = novo;
                return;
            }

            var atual = _primeiro;
            while (atual.Proximo != null && atual.Proximo.Prioridade >= prioridade)
            {
                atual = atual.Proximo;
            }

            novo.Proximo = atual.Proximo;
            atual.Proximo = novo;
        }

        public int Desenfileirar()
        {
            if (_primeiro == null) return -1;
            int valor = _primeiro.Valor;
            _primeiro = _primeiro.Proximo;
            return valor;
        }

        public void Mostrar()
        {
            var atual = _primeiro;
            while (atual != null)
            {
                Console.Write($"({atual.Valor},{atual.Prioridade})");
                if (atual.Proximo != null) Console.Write(",");
                atual = atual.Proximo;
            }
            Console.WriteLine();
        }
    }
}
