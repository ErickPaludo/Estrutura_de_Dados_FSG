namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 4: Cálculo da Média e Desvio Padrão
            //Descrição: Crie uma função CalcularMediaDesvioPadrao que receba um vetor de inteiros e retorne a média e o desvio padrão dos elementos.
            //Exemplo de Entrada:
            //int[] vetor = { 10, 12, 23, 23, 16, 23, 21, 16 };
            //Exemplo de Saída:
            //Média: 18
            //Desvio Padrão: 5.48
            int[] vetor = { 2, 4, 4, 4, 5, 5, 7, 9 };
            CalcularMediaDesvioPadrao(vetor);
        }
        static void CalcularMediaDesvioPadrao(int[] vetor)
        {
            int soma = 0;
            double divergencia = 0;
            for(int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }
            double media = (double)soma / vetor.Length;
            Console.WriteLine($"Média: {media}");
            for (int i = 0; i < vetor.Length; i++)
            {
                divergencia += Math.Pow((vetor[i] - media),2);
            }
            divergencia = divergencia / vetor.Length;
            divergencia = Math.Sqrt(divergencia);
            Console.WriteLine($"Divergencia: {divergencia}");
        }
    }
}
