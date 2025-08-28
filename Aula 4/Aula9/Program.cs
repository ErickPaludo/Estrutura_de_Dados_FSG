namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 9: Vetor Palíndromo
            //Descrição: Crie uma função EhPalindromo que receba um vetor de inteiros e verifique se ele é um palíndromo (o vetor é igual ao seu reverso).
            //Exemplo de Entrada:
            int[] vetor = { 1, 2, 3, 2, 2 };
            //Exemplo de Saída:
            //Resultado: True
            Console.WriteLine(EhPalindromo(vetor));
        }
        static bool EhPalindromo(int[] vetor)
        {
            bool result = true;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] != vetor[vetor.Length - 1 - i])
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
