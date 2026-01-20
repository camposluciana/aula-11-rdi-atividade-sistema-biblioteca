using System;

namespace SistemaBiblioteca
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca("Biblioteca Manuelzão e Miguilim");

            // Cadastrar livros
            biblioteca.CadastrarLivro(new Livro("A Revolução dos Bichos", "George Orwell"));
            biblioteca.CadastrarLivro(new Livro("O Hobbit", "J.R.R. Tolkien"));
            biblioteca.CadastrarLivro(new Livro("Alice no País das Maravilhas", "Lewis Carroll"));

            int opcao;

            do
            {
                Console.WriteLine("\n==== SISTEMA DA BIBLIOTECA MANUELZÃO E MIGUILIM ====");
                Console.WriteLine("1 - Listar livros");
                Console.WriteLine("2 - Emprestar livro");
                Console.WriteLine("3 - Devolver livro");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        biblioteca.ListarLivros();
                        break;

                    case 2:
                        biblioteca.ListarLivros();
                        Console.Write("Digite o número do livro para empréstimo: ");

                        if (int.TryParse(Console.ReadLine(), out int numEmprestimo)
                            && numEmprestimo > 0
                            && numEmprestimo <= biblioteca.Livros.Count)
                        {
                            Livro livro = biblioteca.Livros[numEmprestimo - 1];
                            biblioteca.EmprestarLivro(livro);
                        }
                        else
                        {
                            Console.WriteLine("Número inválido.");
                        }
                        break;

                    case 3:
                        biblioteca.ListarLivros();
                        Console.Write("Digite o número do livro para devolução: ");

                        if (int.TryParse(Console.ReadLine(), out int numDevolucao)
                            && numDevolucao > 0
                            && numDevolucao <= biblioteca.Livros.Count)
                        {
                            Livro livro = biblioteca.Livros[numDevolucao - 1];
                            biblioteca.DevolverLivro(livro);
                        }
                        else
                        {
                            Console.WriteLine("Número inválido.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Encerrando o sistema...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            } while (opcao != 4);
        }
    }
}


