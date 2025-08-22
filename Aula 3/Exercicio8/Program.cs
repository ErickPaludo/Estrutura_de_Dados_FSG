namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //> Informe o ano: 2024
            //> O ano informado é bissexto
            //> Fim da execução do programa
            int ano = int.Parse(Console.ReadLine());
            
            if(ano.ToString().Substring(2,2) != "00")
                Console.WriteLine((Convert.ToDouble(ano.ToString().Substring(2, 2)) / 4) % 1 > 0 ? "Nao e bissext0" : "bissexto");
            else
                Console.WriteLine((Convert.ToDouble(ano.ToString().Substring(0, 2)) / 4) % 1 > 0 ? "Nao e bissext0" : "bissexto");
        }
    }
}
