namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //15 - Crie uma aplicação console que solicite um número e calcule o seu fatorial. Exemplo de saída:
            //> Informe um número: 5
            //> Fatorial de 5 = 120
            //> Fim da execução do programa
            int n = int.Parse(Console.ReadLine());
            int fatorial = 1;
            for (int i = n; i > 0; i--)
            {
                Console.Write(i + " * ");
                fatorial = fatorial * i;
            }
            Console.WriteLine($"= {fatorial}");
        }
    }
}
