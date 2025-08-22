namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //> Informe o primeiro número: 4
            //> Informe o segundo número: 6
            //> Informe o terceiro número: 10
            //> Média aritmética: 6,67
            //> Fim da execução do programa
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine(((double)(x + y + z) / 3).ToString("f2"));
        }
    }
}
