// 9 Faça um Programa que pergunte em que turno você estuda. Peça para digitar M (matutino) ou V (Vespertino) ou N (Noturno). Imprima a mensagem "Bom Dia!", "Boa Tarde!" ou "Boa Noite!" ou "Valor Inválido!", conforme o caso.
using System;
namespace Turno
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o turno que você estuda M (matutino) ou V (Vespertino) ou N (Noturno) : ");
            char turno = char.Parse(Console.ReadLine());

             if (turno == 'm' || turno == 'M'){

                Console.WriteLine("Bom Dia!");
             }else if (turno == 'v' || turno == 'V'){
                Console.WriteLine("Boa Tarde!");
             }else if (turno == 'n' || turno == 'N'){
                Console.WriteLine("Boa Noite!");
             }else {
                Console.WriteLine("Valor Invalido!");
             }

        }
    }
}