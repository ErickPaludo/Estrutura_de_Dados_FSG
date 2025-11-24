using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public class No
    {
        public Pessoa Dados { get; set; }
        public No? ProximoNo { get; set; }

        public No(Pessoa dados)
        {
            Dados = dados;
            ProximoNo = null;
        }
    }
}
