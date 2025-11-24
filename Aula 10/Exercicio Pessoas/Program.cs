using System;

namespace Aula
{
    public class Program
    {
        public static void Main()
        {
            Lista lista = new Lista();
            int opcao;

            do
            {
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("1 - Adicionar pessoa");
                Console.WriteLine("2 - Localizar por nome");
                Console.WriteLine("3 - Localizar por código");
                Console.WriteLine("4 - Remover pessoa");
                Console.WriteLine("5 - Quantidade de pessoas");
                Console.WriteLine("6 - Listar todas");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("================");
                Console.Write("Escolha: ");

                int.TryParse(Console.ReadLine(), out opcao);
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.Write("Informe o código: ");
                        string cod = Console.ReadLine();
                        Console.Write("Informe o nome: ");
                        string nome = Console.ReadLine();
                        lista.Inserir(new Pessoa(cod, nome));
                        Console.WriteLine("Pessoa adicionada com sucesso!");
                        break;

                    case 2:
                        Console.Write("Informe parte do nome: ");
                        string buscaNome = Console.ReadLine();
                        Pessoa p1 = lista.LocalizarPorNome(buscaNome);
                        if (p1 == null) Console.WriteLine("Pessoa não encontrada.");
                        else Console.WriteLine($"{p1.Codigo} - {p1.Nome}");
                        break;

                    case 3:
                        Console.Write("Informe o código: ");
                        string buscaCod = Console.ReadLine();
                        Pessoa p2 = lista.LocalizarPorCodigo(buscaCod);
                        if (p2 == null) Console.WriteLine("Pessoa não encontrada.");
                        else Console.WriteLine($"{p2.Codigo} - {p2.Nome}");
                        break;

                    case 4:
                        Console.Write("Informe o código da pessoa a remover: ");
                        string remCod = Console.ReadLine();
                        Pessoa p3 = lista.LocalizarPorCodigo(remCod);
                        if (p3 == null) Console.WriteLine("Pessoa não encontrada.");
                        else
                        {
                            lista.Remover(p3);
                            Console.WriteLine("Pessoa removida.");
                        }
                        break;

                    case 5:
                        Console.WriteLine($"Quantidade: {lista.Quantidade()}");
                        break;

                    case 6:
                        Console.WriteLine("Lista de pessoas:");
                        lista.ListarTodas();
                        break;

                    case 0:
                        Console.WriteLine("Encerrando...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                if (opcao != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("(Pressione qualquer tecla para continuar)");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (opcao != 0);
        }
    }
}

