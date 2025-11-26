using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public class ArvoreBinaria
    {
        private No _raiz;

        public class No
        {
            public int Valor { get; set; }
            public No Esquerda { get; set; }
            public No Direita { get; set; }

            public No(int valor)
            {
                Valor = valor;
                Esquerda = null;
                Direita = null;
            }
        }

        public void Inserir(int valor)
        {
            if (_raiz == null)
            {
                _raiz = new No(valor);
                return;
            }

            No atual = _raiz;

            while (true)
            {
                if (valor == atual.Valor)
                    return;

                if (valor < atual.Valor)
                {
                    if (atual.Esquerda == null)
                    {
                        atual.Esquerda = new No(valor);
                        return;
                    }
                    atual = atual.Esquerda;
                }
                else
                {
                    if (atual.Direita == null)
                    {
                        atual.Direita = new No(valor);
                        return;
                    }
                    atual = atual.Direita;
                }
            }
        }

        public void ImprimirEmOrdem()
        {
            ImprimirEmOrdemRecursivo(_raiz);
            Console.WriteLine();
        }

        private void ImprimirEmOrdemRecursivo(No no)
        {
            if (no == null)
                return;

            ImprimirEmOrdemRecursivo(no.Esquerda);
            Console.Write(no.Valor + " ");
            ImprimirEmOrdemRecursivo(no.Direita);
        }

        public void ImprimirPorLargura()
        {
            if (_raiz == null)
                return;

            Queue<No> fila = new Queue<No>();
            fila.Enqueue(_raiz);

            while (fila.Count > 0)
            {
                No atual = fila.Dequeue();
                Console.Write(atual.Valor + " ");

                if (atual.Esquerda != null)
                    fila.Enqueue(atual.Esquerda);

                if (atual.Direita != null)
                    fila.Enqueue(atual.Direita);
            }

            Console.WriteLine();
        }
    }
}
