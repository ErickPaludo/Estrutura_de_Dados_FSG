using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public class NoPilha
    {
        public int Valor { get; set; }
        public NoPilha Proximo { get; set; }
        public NoPilha(int valor) => Valor = valor;
    }
}
