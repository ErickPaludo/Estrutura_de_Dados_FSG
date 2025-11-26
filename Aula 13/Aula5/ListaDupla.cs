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

        public void InserirNoInicio(int valor)
        {
            No novo = new No(valor);

            if (_primeiro == null)
            {
                _primeiro = novo;
                _ultimo = novo;
            }
            else
            {
                novo.Proximo = _primeiro;
                _primeiro.Anterior = novo;
                _primeiro = novo;
            }
        }

        public void Inserir(int valor, int posicao)
        {
            if (posicao <= 0)
            {
                InserirNoInicio(valor);
                return;
            }

            No atual = _primeiro;
            int indice = 0;

            while (atual != null && indice < posicao)
            {
                atual = atual.Proximo;
                indice++;
            }

            if (atual == null)
            {
                InserirNoFinal(valor);
                return;
            }

            No novo = new No(valor);

            novo.Proximo = atual;
            novo.Anterior = atual.Anterior;

            atual.Anterior.Proximo = novo;
            atual.Anterior = novo;
        }

        public void RemoverValor(int valor)
        {
            No atual = _primeiro;

            while (atual != null)
            {
                if (atual.Valor == valor)
                {
                    if (atual == _primeiro)
                    {
                        _primeiro = atual.Proximo;

                        if (_primeiro != null)
                            _primeiro.Anterior = null;
                        else
                            _ultimo = null;
                    }
                    else if (atual == _ultimo)
                    {
                        _ultimo = atual.Anterior;
                        _ultimo.Proximo = null;
                    }
                    else
                    {
                        atual.Anterior.Proximo = atual.Proximo;
                        atual.Proximo.Anterior = atual.Anterior;
                    }

                    return;
                }

                atual = atual.Proximo;
            }
        }

        public int ObterQuantidade()
        {
            int count = 0;
            No atual = _primeiro;

            while (atual != null)
            {
                count++;
                atual = atual.Proximo;
            }

            return count;
        }

        public int ObterPosicao(int valor)
        {
            int indice = 0;
            No atual = _primeiro;

            while (atual != null)
            {
                if (atual.Valor == valor)
                    return indice;

                atual = atual.Proximo;
                indice++;
            }

            return -1;
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
