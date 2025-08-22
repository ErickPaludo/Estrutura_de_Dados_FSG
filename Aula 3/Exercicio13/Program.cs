namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13 - Crie uma aplicação console que exiba todos os números pares de 1 a 100. Exemplo de saída:
            //> Números pares: 2, 4, 6, ..., 100
            //> Fim da execução do programa
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i % 2 == 0 ? i + " " : "");
            }
        }
    }
}
