namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 2: Encontrar o Maior e o Menor Valor
            //Descrição: Escreva uma função chamada EncontrarExtremos que receba um vetor de inteiros e retorne o maior e o menor valor desse vetor.
            //Exemplo de Entrada:
            //int[] vetor = { 10, 20, 5, 15, 30 };
            //Exemplo de Saída:
            //Maior: 30
            //Menor: 5

            int[] vetor = { 10, 20, 5, 15, 30 };
            EncontrarExtremos(vetor);
        }
        public static void EncontrarExtremos(int[] vetor)
        {
            int maior = 0;
            int menor = vetor[0];
            for(int i = 0;i < vetor.Length; i++)
            {
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                }
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                }
            }
            Console.WriteLine($"Maior {maior} Menor {menor}");
        }
    }
}
