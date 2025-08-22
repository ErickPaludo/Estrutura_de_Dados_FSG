namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //> Informe o primeiro número: 10
            //> Informe o segundo número: 2
            //> Informe o operador: /
            //> Resultado da operação: 5
            //> Fim da execução do programa
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operador = char.Parse(Console.ReadLine());
            switch (operador)
            {
                case '+':
                    Console.WriteLine(num1+num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;      
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;    
                case '/':
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("Operador inválido");
                    return;
            }
        }
    }
}
