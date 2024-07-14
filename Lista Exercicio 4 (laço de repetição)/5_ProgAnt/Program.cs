//5 Altere o programa anterior permitindo ao usuário informar as populações e as taxas de crescimento iniciais. Valide a entrada e permita repetir a operação. 
using System;
namespace População2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho a população do pais 1: ");
            double PaisA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Agora informe a porcentagem de crescimento deste pais(ex: 3% digite 0,03): ");
            double TaxaA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a população do pais 2: ");
            double PaisB = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Agora iforme a porcentagm d crescimento do pais 2: ");
            double TaxaB = Convert.ToDouble(Console.ReadLine());
            int anos = 0;

                for (;PaisA < PaisB; anos++){

                    PaisA += PaisA * TaxaA;
                    PaisB += PaisB * TaxaB;
                }

            Console.WriteLine($"Para que o pais A ultrapasse a população do pais B e necessario {anos} Anos.");

        }
    }
}