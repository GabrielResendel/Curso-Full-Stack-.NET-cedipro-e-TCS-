//4. Faça um Programa que verifique se uma letra digitada é vogal ou consoante.
using System;

namespace Verifletra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma letra: ");
            char letra = char.Parse(Console.ReadLine());
            
                if(letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u') {
                    Console.WriteLine("Essa letra e uma vogal");
                }
                else {
                    Console.WriteLine("Essa letra e uma consoante");
                }

        }
    }
}
