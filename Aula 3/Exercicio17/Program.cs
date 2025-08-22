namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //17 - Crie uma aplicação console que determine se um número informado é primo. Exemplo de saída:
            //> Informe um número: 17
            //> O número é primo
            //> Fim da execução do programa

            int numero = int.Parse(Console.ReadLine());
            if (numero > 1)
            {
                for(int i = 2;i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i != 0)
                    {
                        Console.WriteLine("O número é primo");
                        return;
                    }
                }
            }
            Console.WriteLine("O número nao é primo");

        }
    }
}