namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //> Informe a nota: 75
            //> Situação: Aprovado
            //> Fim da execução do programa
            double nota = int.Parse(Console.ReadLine());
            Console.WriteLine(nota >= 60 ? "Aprovado":"Reprovado");

        }
    }
}
