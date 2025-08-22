namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //> Informe a temperatura em Celsius: 25
            //> Temperatura em Fahrenheit: 77
            //> Fim da execução do programa
            int raio = int.Parse(Console.ReadLine());
            double area = 3.14 * Math.Pow(raio, 2);
            Console.WriteLine(area.ToString("f2"));
        }
    }
}
