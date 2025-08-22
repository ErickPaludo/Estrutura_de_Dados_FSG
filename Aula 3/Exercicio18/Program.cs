using MMLib.Extensions;

namespace Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //18 - Crie uma aplicação console que solicite uma frase e conte o número de vogais presentes. Exemplo de saída:
            //> Informe uma frase: Programação é divertida
            //> Número de vogais: 10
            //> Fim da execução do programa
            string frase = Console.ReadLine().ToLower().RemoveDiacritics();
            string[] vogais = { "a", "e", "i", "o", "u"};
            int contador = 0;
            for (int i = 0;i < frase.Length; i++)
            {
                foreach(var obj in vogais)
                {
                    if (frase[i].ToString() == obj)
                    {
                        contador++;
                    }
                }
            }
            Console.WriteLine(contador);
            // O Rato roeu a roupa do rei de Roma - 16 vogais
        }
    }
}
