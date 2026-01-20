using System;
using System.Dynamic;
using SistemaBiblioteca;

namespace SistemaBiblioteca
{
    public class Usuario
    {
        //definindo as propriedades da classe Usuario
        public string NomeUsuario { get; set; }
        public int IdUsuario { get; set; }
        public string TelefoneUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string EnderecoUsuario { get; set; }

        //definindo o construtor da classe Usuario
        public Usuario(string nomeUsuario, int idUsuario, string telefoneUsuario, string emailUsuario, string enderecoUsuario)
        {
            NomeUsuario = nomeUsuario;
            IdUsuario = idUsuario;
            TelefoneUsuario = telefoneUsuario;
            EmailUsuario = emailUsuario;
            EnderecoUsuario = enderecoUsuario;
        }

        //definindo o método para exibir as informações do usuário
        public void ExibirInformacoes()
        {
            Console.WriteLine("Nome do Usuário: " + NomeUsuario);
            Console.WriteLine("IdUsuario: " + IdUsuario);
            Console.WriteLine("TelefoneUsuario: " + TelefoneUsuario);
            Console.WriteLine("EmailUsuario: " + EmailUsuario);
            Console.WriteLine("EnderecoUsuario: " + EnderecoUsuario);
        }
    }
}






