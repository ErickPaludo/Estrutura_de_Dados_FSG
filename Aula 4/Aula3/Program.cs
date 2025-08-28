namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 3: Ordenação de Vetor
            //Descrição: Implemente uma função OrdenarVetor que receba um vetor de inteiros e retorne um novo vetor com os elementos em ordem crescente. Não utilize funções prontas de ordenação da linguagem.
            //Exemplo de Entrada:
            //int[] vetor = { 7, 2, 9, 4, 1 };
            //Exemplo de Saída:
            //Vetor Ordenado: { 1, 2, 4, 7, 9 }
            int[] vetor = { 7, 2, 9, 4, 1 };
            Console.WriteLine("Entrada: ");
            foreach(var item in vetor)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
            foreach (var item in OrdenarVetor(vetor))
            {
                Console.Write(item + " ");
            }
        }
        public static int[] OrdenarVetor(int[] vetor)
        {
            int[] ordena = new int[vetor.Length];
            int menor = vetor[0];
            for (int i = 0; i < vetor.Length; i++)
            {
                for(int j = 0; j < vetor.Length; j++)
                {
                    if(vetor[i] < vetor[j])
                    {
                        int x = vetor[j];
                        vetor[j] = vetor[i];
                        vetor[i] = x;
                    }
                }
            }
            return vetor;
        }
    }
}
