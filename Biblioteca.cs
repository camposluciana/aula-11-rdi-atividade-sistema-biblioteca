using System;
using System.Collections.Generic;

namespace SistemaBiblioteca
{
    public class Biblioteca
    {
        // atributos
        public string Nome { get; set; }
        public List<Livro> Livros { get; set; }
        public List<Usuario> Usuarios { get; set; }

        // construtor
        public Biblioteca(string nome)
        {
            Nome = nome;
            Livros = new List<Livro>();
            Usuarios = new List<Usuario>();
        }

        // cadastrar livro
        public void CadastrarLivro(Livro livro)
        {
            Livros.Add(livro);
            Console.WriteLine("Livro cadastrado com sucesso!");
        }

        // cadastrar usuário
        public void CadastrarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
            Console.WriteLine("Usuário cadastrado com sucesso!");
        }

        // listar livros do acervo
        public void ListarLivros()
        {
            if (Livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro cadastrado.");
                return;
            }

            foreach (var livro in Livros)
            {
                livro.ExibirDescricao();
                livro.ExibirStatus();
                Console.WriteLine("----------------------");
            }
        }

        // emprestar livro
        public void EmprestarLivro(Livro livro)
        {
            if (livro.Disponivel)
            {
                livro.Disponivel = false;
                Console.WriteLine("Livro emprestado com sucesso!");
            }
            else
            {
                Console.WriteLine("Livro indisponível para empréstimo.");
            }
        }

        // devolver livro
        public void DevolverLivro(Livro livro)
        {
            livro.Disponivel = true;
            Console.WriteLine("Livro devolvido com sucesso!");
        }

        // calcular multa
        public decimal CalcularMulta(int diasAtraso)
        {
            const decimal valorMultaPorDia = 2.0m;

            if (diasAtraso <= 0)
                return 0;

            decimal valorTotal = diasAtraso * valorMultaPorDia;
            Console.WriteLine($"Multa por {diasAtraso} dias: R$ {valorTotal:F2}");
            return valorTotal;
        }
    }
}


