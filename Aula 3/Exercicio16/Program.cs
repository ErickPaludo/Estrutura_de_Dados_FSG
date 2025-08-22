namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //16 - Crie uma aplicação console que solicite 5 números e exiba o maior deles. Exemplo de saída:
            //> Informe o número 1: 10
            //> Informe o número 2: 4
            //> Informe o número 3: 25
            //> Informe o número 4: 7
            //> Informe o número 5: 13
            //> O maior número digitado foi: 25
            //> Fim da execução do programa

            int[] vecto = new int[5];
            string valores = Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                vecto[i] = int.Parse(valores.Split(' ')[i]);
            }

            // 1 9 4 7 5

            // 1 9 = 9
            // 9 4 = 4
            // 4 7 = 7
            // 7 5 = 5
            // 7 9 = 9

            int n1 = vecto[0];
      
                foreach (var obj in vecto)
                {
                    if (obj > n1)
                    {
                        n1 = obj;
                    }
                }
            Console.WriteLine(n1);
        }
    }
}
