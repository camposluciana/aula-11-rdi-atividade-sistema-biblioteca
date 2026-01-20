using System;

namespace SistemaBiblioteca
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Disponivel { get; set; }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            Disponivel = true;
        }

        public void ExibirDescricao()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
        }

        public void ExibirStatus()
        {
            Console.WriteLine(Disponivel ? "Status: Disponível" : "Status: Emprestado");
        }
    }
}




