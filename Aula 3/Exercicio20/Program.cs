namespace Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //20 - Crie uma aplicação console que implemente um jogo onde o usuário deve adivinhar um número aleatório entre 1 e 100, recebendo dicas de "maior" ou "menor". Exemplo de saída:
            //> Tente adivinhar o número entre 1 e 100: 50
            //> O número é maior
            //> Tente novamente: 75
            //> O número é menor
            //> Tente novamente: 63
            //> Parabéns! Você acertou o número: 63
            //> Fim da execução do programa
            int numero = new Random().Next(1, 100);
            int tentativa = 0;
            do
            {
                tentativa = int.Parse(Console.ReadLine());
                if(tentativa >= numero)
                {
                    Console.WriteLine("O número é menor");
                }
                else
                {
                    Console.WriteLine("O número é maior");
                }
            } while (numero != tentativa);
            Console.WriteLine($"Ganhou, numero {numero}");
        }
    }
}
