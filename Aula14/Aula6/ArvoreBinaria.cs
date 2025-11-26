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

        public int Altura()
        {
            return AlturaRecursiva(_raiz);
        }

        private int AlturaRecursiva(No no)
        {
            if (no == null)
                return 0;

            int alturaEsquerda = AlturaRecursiva(no.Esquerda);
            int alturaDireita = AlturaRecursiva(no.Direita);

            return 1 + Math.Max(alturaEsquerda, alturaDireita);
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
    }
}
