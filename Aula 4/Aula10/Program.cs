namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 10: Produto Escalar de Dois Vetores
            //Descrição: Escreva uma função ProdutoEscalar que receba dois vetores de inteiros de mesma dimensão e retorne o produto escalar desses vetores.
            //Exemplo de Entrada:
            int[] vetor1 = { 1, 3, -5 };
            int[] vetor2 = { 4, -2, -1 };
            //Exemplo de Saída:
            //Produto Escalar: 3
            ProdutoEscalar(vetor1, vetor2);
        }
        static void ProdutoEscalar(int[] vet1, int[] vet2)
        {
            int escalar = 0;
            for (int i = 0; i < vet1.Length; i++)
            {
               escalar += vet1[i] * vet2[i];
            }
            Console.WriteLine(escalar);
        }
    }
}
