namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14 - Crie uma aplicação console que solicite um número N e calcule a soma de todos os números de 1 até N. Exemplo de saída:
            //> Informe o número N: 5
            //> Soma de 1 até 5 = 15
            //> Fim da execução do programa
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
                soma += i;
            }
            Console.WriteLine($"= {soma}");
        }
    }
}
