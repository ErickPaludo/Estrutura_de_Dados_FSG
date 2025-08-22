namespace Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //19 - Crie uma aplicação console que liste os N primeiros números da sequência de Fibonacci. Exemplo de saída:
            //> Informe a quantidade de elementos da sequência Fibonacci: 6
            //> [0, 1, 1, 2, 3, 5]
            //> Fim da execução do programa
            int x = int.Parse(Console.ReadLine());
            int a = 1;
            int b = 1;
            int c = 0;
            Console.Write("0 ");
            Console.Write(a + " ");
            Console.Write(b + " ");
            for (int i = 3; i < x; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
