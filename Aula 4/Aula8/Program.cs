namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 8: Contar Elementos de um Vetor
            //Descrição: Implemente uma função ContarElementos que receba um vetor de inteiros e um número x, e retorne a quantidade de vezes que x aparece no vetor.
            //Exemplo de Entrada:
            int[] vetor = { 1, 2, 3, 2, 4, 2, 5 };
            int x = 2;
            //Exemplo de Saída:
            //Número 2 aparece 3 vezes.
            ContarElementos(vetor, x);
        }
        static void ContarElementos(int[] vetor,int x)
        {
            int cont = 0;
            for(int i =0; i < vetor.Length; i++)
            {
                if (vetor[i] == x)
                {
                    cont++;
                }
            }
            Console.WriteLine($"Número {x} aparece {cont} vezes");
        }
    }
}
