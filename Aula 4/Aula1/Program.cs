namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1: Soma dos Elementos de um Vetor
            //Descrição: Crie uma função chamada SomarElementos que receba um vetor de inteiros e retorne a soma de todos os seus elementos. O vetor deve ser preenchido pelo usuário.
            //Exemplo de Entrada:
            //int[] vetor = { 1, 2, 3, 4, 5 };
            //Exemplo de Saída:
            //Resultado: 15
            //Console.WriteLine(SomarElementos(vetor));
            int[] vetor = { 1, 2, 3, 4, 5 };
            Console.WriteLine(SomarElementos(vetor));
        }
        public static int SomarElementos(int[] vetor)
        {
            int soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }
            return soma;
        }
    }
}

