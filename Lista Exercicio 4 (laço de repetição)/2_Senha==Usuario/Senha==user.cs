// 2 Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.
using System;
namespace SenhaUser
{
    class programa
    {
        public static void Main(string[] args)
        {

            string nome, senha;

            Console.Write("Digite o usuario: ");
            nome = Console.ReadLine();

            Console.Write("Digite a senha: ");
            senha = Console.ReadLine();

                while (senha == nome)
                {
                    Console.WriteLine("A senha não pode ser igual ao nome de usuario Digite novamente:  ");

                        Console.Write("Digite o usuario: ");
                        nome = Console.ReadLine();

                        Console.Write("Digite a senha: ");
                        senha = Console.ReadLine(); 
                }   

            Console.WriteLine("Usuario e senha correta");   

     }

    }
}