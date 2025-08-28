namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 6: Intercalar Dois Vetores
            //Descrição: Desenvolva uma função IntercalarVetores que receba dois vetores de inteiros, vetor1 e vetor2, e retorne um novo vetor intercalando os elementos de ambos.
            //Exemplo de Entrada:
            //int[] vetor1 = { 1, 3, 5 };
            //int[] vetor2 = { 2, 4, 6 };
            //Exemplo de Saída:
            //Vetor Intercalado: { 1, 2, 3, 4, 5, 6 }
            int[] vetor1 = { 1, 3, 5 };
            int[] vetor2 = { 2, 4, 6 };
            IntercalarVetores(vetor1, vetor2);
        }
        static int[] IntercalarVetores(int[] vet, int[] vet2)
        {
            int[] vetIntercalado = new int[vet.Length + vet2.Length];

            for (int i = 0;i < vet.Length; i++)
            {
                vetIntercalado[2*i] = vet[i];
                vetIntercalado[i*2+1] = vet2[i];
            }
            return vetIntercalado;
        }
    }
}
