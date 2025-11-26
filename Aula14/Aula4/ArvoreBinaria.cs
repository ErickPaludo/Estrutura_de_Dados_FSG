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

        public bool Contem(int valor)
        {
            return ContemRecursivo(_raiz, valor);
        }

        private bool ContemRecursivo(No no, int valor)
        {
            if (no == null)
                return false;

            if (no.Valor == valor)
                return true;

            if (valor < no.Valor)
                return ContemRecursivo(no.Esquerda, valor);
            else
                return ContemRecursivo(no.Direita, valor);
        }
    }
}
