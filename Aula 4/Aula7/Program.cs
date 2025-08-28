namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 7: Remover Elementos Duplicados de um Vetor
            //Descrição: Escreva uma função RemoverDuplicados que receba um vetor de inteiros e retorne um novo vetor sem elementos duplicados.
            //Exemplo de Entrada:
            //int[] vetor = { 1, 2, 2, 3, 4, 4, 5 };
            //Exemplo de Saída:
            //Vetor sem Duplicados: { 1, 2, 3, 4, 5 }
            int[] vetor = { 1, 2, 2, 3, 4, 4, 5 };
            int[] repitido = new int[vetor.Length];

            int indicerepitido = 0;
            bool existe = false;
            int cont = 0;
            repitido[indicerepitido] = vetor[0];

            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < repitido.Length; j++)
                {
                    if (repitido[j] == vetor[i])
                    {
                        cont++;
                    }
                }
                if (cont < 1)
                {
                    indicerepitido++;
                    repitido[indicerepitido] = vetor[i];
                }
                    cont = 0;
            }
            Console.WriteLine(repitido);
        }    
    }
}

