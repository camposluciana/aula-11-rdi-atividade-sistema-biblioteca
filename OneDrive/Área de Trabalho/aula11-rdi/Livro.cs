using System;

namespace SistemaBiblioteca
{
    public enum StatusLivro
    {
        Disponivel,
        Emprestado
    }

    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public StatusLivro Status { get; private set; }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            Status = StatusLivro.Disponivel;
        }

        public void Emprestar(string nomePessoa, object statusLivro)
        {
            Status = StatusLivro.Emprestado;
            Console.WriteLine($"Livro '{Titulo}' emprestado para {nomePessoa}.");
        }

        public void Devolver(object statusLivro)
        {
            Status = StatusLivro.Disponivel;
            Console.WriteLine($"Livro '{Titulo}' devolvido à biblioteca.");
        }
    }
}

