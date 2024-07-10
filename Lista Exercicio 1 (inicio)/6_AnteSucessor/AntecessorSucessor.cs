// 6.Escreva um algoritmo para ler um valor (do teclado) e escrever (na tela) o valor, seu antecessor e seu sucessor (cada um em uma linha).

using System;

namespace AntecessorSucessor
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
               int num = Convert.ToInt32(Console.ReadLine());
                int ante = num - 1;
                int suce = num + 1;

                Console.WriteLine("Seu numero e: " + num);
                Console.WriteLine("Seu antecessor e: " + ante);
                Console.WriteLine("Seu sucessor e: " + suce);
        }
    }
}
