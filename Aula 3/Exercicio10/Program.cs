namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //> Informe um número: -8
            //> O número é negativo
            //> Fim da execução do programa
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(x >= 0 ? "Positivo" : "Negativo");
        }
    }
}
