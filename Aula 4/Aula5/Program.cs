namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 5: Rotacionar os Elementos de um Vetor
            //Descrição: Escreva uma função RotacionarVetor que receba um vetor de inteiros e um número n, e retorne o vetor com seus elementos rotacionados à direita por n posições.
            //Exemplo de Entrada:
            //int[] vetor = { 1, 2, 3, 4, 5 };
            //int n = 2;
            //Exemplo de Saída:
            //Vetor Rotacionado: { 4, 5, 1, 2, 3 }
            int[] vetor = { 1, 2, 3, 4, 5,6,7,8 };
            RotacionarVertor(vetor, 3);

        }
        static void RotacionarVertor(int[] vetor, int numero)
        {
            int indice = vetor.Length - numero;

            int[] vetorRotacionado = new int[vetor.Length];

            int j = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (i < numero)
                {
                    vetorRotacionado[i] = vetor[indice + i];
                }
                else
                {
                    vetorRotacionado[i] = vetor[j];
                    j++;
                }

            }
        }
    }
}
