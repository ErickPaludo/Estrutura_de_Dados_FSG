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
        public No? ProximoNo { get; set; }

        public No(int valor)
        {
            Valor = valor;
            ProximoNo = null;
        }
    }
}
