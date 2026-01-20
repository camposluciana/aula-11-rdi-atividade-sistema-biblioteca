using System;
using System.Collections.Generic;

namespace SistemaBiblioteca
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int IdLocatario { get; set; }
        public List<Livro> LivrosEmprestados { get; set; }

        public Pessoa(int idLocatario, string nome)
        {
            IdLocatario = idLocatario;
            Nome = nome;
            LivrosEmprestados = new List<Livro>();
        }

        // apenas registra o livro recebido
        public void ReceberLivro(Livro livro)
        {
            LivrosEmprestados.Add(livro);
            Console.WriteLine($"{Nome} pegou o livro {livro.Titulo}.");
        }

        public void DevolverLivro(Livro livro)
        {
            if (LivrosEmprestados.Contains(livro))
            {
                LivrosEmprestados.Remove(livro);
                Console.WriteLine($"{Nome} devolveu o livro {livro.Titulo}.");
            }
            else
            {
                Console.WriteLine($"{Nome} não possui o livro {livro.Titulo}.");
            }
        }

        public void PagarMulta(decimal valor)
        {
            Console.WriteLine($"{Nome} pagou uma multa de R$ {valor:F2}.");
        }
    }
}
