using System;

namespace Aula
{
    public class Program
    {
        public static bool VerificarParenteses(string expressao)
        {
            var pilha = new Pilha();
            foreach (char c in expressao)
            {
                if (c == '(') pilha.Empilhar(c);
                else if (c == ')')
                {
                    if (pilha.EstaVazia()) return false;
                    pilha.Desempilhar();
                }
            }
            return pilha.EstaVazia();
        }

        public static void Main()
        {
            string expr1 = "(A+B)(C-D)";
            string expr2 = "(A+B(C-D)";

            Console.WriteLine(VerificarParenteses(expr1) ? "Balanceada" : "Não balanceada");
            Console.WriteLine(VerificarParenteses(expr2) ? "Balanceada" : "Não balanceada");
        }
    }
}

