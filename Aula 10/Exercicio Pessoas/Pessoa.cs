using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public class Pessoa
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }

        public Pessoa(string codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
    }
}
