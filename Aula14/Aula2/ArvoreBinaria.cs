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

        internal class No
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
            }
        }

        public int ObterRaiz()
        {
            return _raiz.Valor;
        }
    }
}
