using System;
using System.Collections.Generic;
using System.Linq;

namespace aula11_rdi
{
    public class Biblioteca
    {
        public string Nome { get; set; }
        public List<Livro> LivrosDisponiveis { get; set; }
        public List<Pessoa> PessoasCadastradas { get; set; }

        public Biblioteca(string nome)
        {
            Nome = nome;
            LivrosDisponiveis = new List<Livro>();
            PessoasCadastradas = new List<Pessoa>();
        }

        public Biblioteca() : this("Biblioteca Fênix")
        {
        }

        public void CadastrarLivro(Livro livro)
        {
            LivrosDisponiveis.Add(livro);
            Console.WriteLine($"{livro.Titulo} cadastrado na biblioteca {Nome}.");
        }

        public void CadastrarPessoa(Pessoa pessoa)
        {
            PessoasCadastradas.Add(pessoa);
            Console.WriteLine($"{pessoa.Nome} cadastrada na biblioteca {Nome}.");
        }

        public void ListarLivros()
        {
            Console.WriteLine($"Livros da biblioteca {Nome}:");
            foreach (var livro in LivrosDisponiveis)
            {
                Console.WriteLine($"- {livro.Titulo} ({livro.Status})");
            }
        }

        public void EmprestarLivro(string titulo, Pessoa pessoa)
        {
            var livro = LivrosDisponiveis
                .FirstOrDefault(l => l.Titulo == titulo && l.Status == StatusLivro.Disponivel);

            if (livro != null)
            {
                livro.Emprestar(pessoa.Nome);
                pessoa.PegarLivro(livro);
            }
            else
            {
                Console.WriteLine($"{titulo} não está disponível para empréstimo.");
            }
        }

        internal void CadastrarPessoa(SistemaBiblioteca.Pessoa novoLocatario)
        {
            throw new NotImplementedException();
        }
    }
}
