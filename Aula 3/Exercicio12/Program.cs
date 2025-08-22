namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12 - Crie uma aplicação console que exiba uma contagem regressiva de 10 até 0. Exemplo de saída:
            //10 9 8 7 6 5 4 3 2 1 0
            //> Fim da execução do programa
            for(int i = 10;i >= 0; i--)
            {
                Console.Write(i + " ");
            }
        }
    }
}
