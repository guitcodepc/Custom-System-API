using System;
using System.Collections.Generic;

// Classe que representa um usuário
public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public Usuario(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }
}

// Classe responsável por gerenciar os usuários (regras de negócio)
public class UsuarioService
{
    private List<Usuario> usuarios = new List<Usuario>();

    public void AdicionarUsuario(Usuario usuario)
    {
        usuarios.Add(usuario);
        Console.WriteLine($"Usuário {usuario.Nome} adicionado com sucesso!");
    }

    public void ListarUsuarios()
    {
        Console.WriteLine("\n--- Lista de Usuários ---");
        foreach (var u in usuarios)
        {
            Console.WriteLine($"ID: {u.Id}, Nome: {u.Nome}");
        }
    }
}

// Classe principal (ponto de entrada do sistema)
class Program
{
    static void Main(string[] args)
    {
        UsuarioService usuarioService = new UsuarioService();
        bool rodando = true;

        while (rodando)
        {
            Console.WriteLine("\n=== Sistema de Usuários ===");
            Console.WriteLine("1 - Cadastrar Usuário");
            Console.WriteLine("2 - Listar Usuários");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o ID do usuário: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Digite o nome do usuário: ");
                    string nome = Console.ReadLine();

                    Usuario usuario = new Usuario(id, nome);
                    usuarioService.AdicionarUsuario(usuario);
                    break;

                case "2":
                    usuarioService.ListarUsuarios();
                    break;

                case "3":
                    rodando = false;
                    Console.WriteLine("Saindo do sistema...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}

