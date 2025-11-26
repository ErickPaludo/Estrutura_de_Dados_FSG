using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public class No
    {
        public int Valor { get; set; }
        public int Prioridade { get; set; }
        public No Proximo { get; set; }

        public No(int valor, int prioridade)
        {
            Valor = valor;
            Prioridade = prioridade;
        }
    }
}
