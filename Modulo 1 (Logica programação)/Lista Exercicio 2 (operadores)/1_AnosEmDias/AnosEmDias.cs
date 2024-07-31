//1 Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias. 
using System;

namespace AnosEmDias
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Descubra Quantos dias de vida você tem!! \n Diga quantos ano, meses e dias vc tem: ");
            Console.Write("Anos: ");
                int ano = int.Parse(Console.ReadLine());
                    int anoD = 365 * ano;

            Console.Write("Meses: ");
                int mes = int.Parse(Console.ReadLine());
                    int mesD = 30 * mes;

            Console.Write("Dias: ");
                int dia = int.Parse(Console.ReadLine());  

            int res = anoD + mesD + dia;

            Console.WriteLine($"Você tem o total de {res} Dias vividos em {ano} Anos {mes} Meses e {dia} dias.");  

              


        }
    }
}
