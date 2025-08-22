using System.Runtime.Intrinsics.X86;
using System;

namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estruturas de Repetição 11 - Crie uma aplicação console que solicite um número e exiba sua tabuada de 1 a 10.Exemplo de saída:
            //> Informe um número: 7
            //            > Tabuada de 7:
            //> 7 x 1 = 7
            //            > ...
            //> 7 x 10 = 70
            //> Fim da execução do programa    
            int num = int.Parse(Console.ReadLine());
            for(int i = 1;i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
}
