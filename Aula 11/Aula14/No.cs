using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public class No
    {
        public char Valor { get; set; }
        public No Proximo { get; set; }

        public No(char valor) => Valor = valor;
    }
}
