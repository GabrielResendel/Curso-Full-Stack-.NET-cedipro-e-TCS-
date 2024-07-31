//3. Faça um Programa que verifique se uma letra digitada é "F" ou "M".
//Conforme a letra escrever: F - Feminino, M - Masculino, Sexo Inválido.
using System;
namespace F_ou_M
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o sexo(F/M):");
            char sexo = char.Parse(Console.ReadLine());

                if(sexo == 'm' || sexo == 'M'){
                    Console.WriteLine("Seu sexo e Masculino!");
                }else if(sexo == 'f' || sexo == 'F'){
                    Console.WriteLine("Seu sexo e Feminino!");
                }else {
                    Console.WriteLine("Sexo Invalido!");
                }

        }
    }
}