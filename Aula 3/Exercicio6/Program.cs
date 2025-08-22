namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //> Informe um número: 9
            //> O número 9 é ímpar
            //> Fim da execução do programa
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(x % 2 == 0 ? "Par" : "Impar");
        }
    }
}
