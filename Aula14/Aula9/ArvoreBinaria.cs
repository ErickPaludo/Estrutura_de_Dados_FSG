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

        public bool Remover(int valor)
        {
            return RemoverRecursivo(ref _raiz, valor);
        }

        private bool RemoverRecursivo(ref No no, int valor)
        {
            if (no == null)
                return false;

            if (valor < no.Valor)
                return RemoverRecursivo(ref no.Esquerda, valor);
            else if (valor > no.Valor)
                return RemoverRecursivo(ref no.Direita, valor);
            else
            {
                // Nó folha
                if (no.Esquerda == null && no.Direita == null)
                {
                    no = null;
                    return true;
                }

                // Caso com filhos ainda não implementado
                return false;
            }
        }
    }
}
