namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // > Informe a temperatura em Celsius: 25
            //> Temperatura em Fahrenheit: 77
            //> Fim da execução do programa
            double temperatura = double.Parse(Console.ReadLine());
            double fah = (temperatura * 1.8) + 32;
            Console.WriteLine(fah.ToString("f2"));
        }
    }
}
