using System;

namespace Aula
{
    public class Program
    {
        public static void Main()
        {
            var lista = new Lista();

            Console.WriteLine($"Qtd (esperado 0): {lista.ObterQuantidade()}");
            Console.WriteLine($"Pos(123) (esp. -1): {lista.ObterPosicao(123)}");

            lista.Remover(0);
            Console.Write("Mostrar lista vazia: ");
            lista.Mostrar();

            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);
            Console.Write("Após inserir 10,20,30: ");
            lista.Mostrar();

            lista.Inserir(40, 1);
            lista.Inserir(50, 999);
            Console.Write("Após inserções por posição: ");
            lista.Mostrar();

            Console.WriteLine($"Pos(20) (esp. 2): {lista.ObterPosicao(20)}");
            Console.WriteLine($"Pos(999) (esp. -1): {lista.ObterPosicao(999)}");

            lista.Remover(0);
            Console.Write("Após Remover(0): ");
            lista.Mostrar();

            lista.Remover(2);
            Console.Write("Após Remover(2): ");
            lista.Mostrar();

            Console.WriteLine($"Qtd final (esp. 3): {lista.ObterQuantidade()}");
            Console.Write("Mostrar lista final: ");
            lista.Mostrar();
        }
    }

}

