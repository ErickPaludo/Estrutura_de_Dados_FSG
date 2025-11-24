using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public class Lista
    {
        private No _primeiroNo;
        private int _quantidade;

        public void Inserir(int valor)
        {
            No novo = new No(valor);
            if (_primeiroNo == null)
                _primeiroNo = novo;
            else
            {
                No atual = _primeiroNo;
                while (atual.ProximoNo != null)
                    atual = atual.ProximoNo;
                atual.ProximoNo = novo;
            }
            _quantidade++;
        }

        public void Inserir(int valor, int posicao)
        {
            if (posicao <= 0)
            {
                No novo = new No(valor);
                novo.ProximoNo = _primeiroNo;
                _primeiroNo = novo;
                _quantidade++;
                return;
            }

            No atual = _primeiroNo;
            int index = 0;

            while (atual != null && index < posicao - 1)
            {
                atual = atual.ProximoNo;
                index++;
            }

            if (atual == null)
            {
                Inserir(valor);
                return;
            }

            No novoNo = new No(valor);
            novoNo.ProximoNo = atual.ProximoNo;
            atual.ProximoNo = novoNo;
            _quantidade++;
        }

        public int ObterPosicao(int valor)
        {
            No atual = _primeiroNo;
            int index = 0;

            while (atual != null)
            {
                if (atual.Valor == valor)
                    return index;

                atual = atual.ProximoNo;
                index++;
            }

            return -1;
        }

        public void Remover(int posicao)
        {
            if (_primeiroNo == null || posicao < 0 || posicao >= _quantidade)
                return;

            if (posicao == 0)
            {
                _primeiroNo = _primeiroNo.ProximoNo;
                _quantidade--;
                return;
            }

            No atual = _primeiroNo;
            int index = 0;

            while (index < posicao - 1)
            {
                atual = atual.ProximoNo;
                index++;
            }

            atual.ProximoNo = atual.ProximoNo?.ProximoNo;
            _quantidade--;
        }

        public int ObterQuantidade()
        {
            return _quantidade;
        }

        public void Mostrar()
        {
            if (_primeiroNo == null)
            {
                Console.WriteLine("Lista vazia");
                return;
            }

            No atual = _primeiroNo;
            string resultado = "";

            while (atual != null)
            {
                resultado += atual.Valor;
                if (atual.ProximoNo != null)
                    resultado += ",";
                atual = atual.ProximoNo;
            }

            Console.WriteLine(resultado);
        }
    }
}
