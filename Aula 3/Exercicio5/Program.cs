namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //> Informe sua idade: 16
            //> Você é menor de idade
            //> Fim da execução do programa
            int idade = int.Parse(Console.ReadLine());
            switch(idade)
            {
                case >= 18:
                    Console.WriteLine("Você é maior de idade");
                    break;
                default:
                    Console.WriteLine("Você é menor de idade");
                    break;
            }
        }
    }
}
