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

        public void Inserir(Pessoa pessoa)
        {
            No novo = new No(pessoa);
            if (_primeiroNo == null)
                _primeiroNo = novo;
            else
            {
                No atual = _primeiroNo;
                while (atual.ProximoNo != null)
                    atual = atual.ProximoNo;
                atual.ProximoNo = novo;
            }
        }

        public Pessoa LocalizarPorNome(string nome)
        {
            No atual = _primeiroNo;
            while (atual != null)
            {
                if (atual.Dados.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase))
                    return atual.Dados;
                atual = atual.ProximoNo;
            }
            return null;
        }

        public Pessoa LocalizarPorCodigo(string codigo)
        {
            No atual = _primeiroNo;
            while (atual != null)
            {
                if (atual.Dados.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase))
                    return atual.Dados;
                atual = atual.ProximoNo;
            }
            return null;
        }

        public void Remover(Pessoa pessoa)
        {
            if (_primeiroNo == null) return;

            if (_primeiroNo.Dados.Codigo == pessoa.Codigo)
            {
                _primeiroNo = _primeiroNo.ProximoNo;
                return;
            }

            No atual = _primeiroNo;
            while (atual.ProximoNo != null)
            {
                if (atual.ProximoNo.Dados.Codigo == pessoa.Codigo)
                {
                    atual.ProximoNo = atual.ProximoNo.ProximoNo;
                    return;
                }
                atual = atual.ProximoNo;
            }
        }

        public int Quantidade()
        {
            int count = 0;
            No atual = _primeiroNo;

            while (atual != null)
            {
                count++;
                atual = atual.ProximoNo;
            }

            return count;
        }

        public void ListarTodas()
        {
            No atual = _primeiroNo;

            if (atual == null)
            {
                Console.WriteLine("Nenhuma pessoa cadastrada.");
                return;
            }

            while (atual != null)
            {
                Console.WriteLine($"{atual.Dados.Codigo} - {atual.Dados.Nome}");
                atual = atual.ProximoNo;
            }

        }
    }
}
