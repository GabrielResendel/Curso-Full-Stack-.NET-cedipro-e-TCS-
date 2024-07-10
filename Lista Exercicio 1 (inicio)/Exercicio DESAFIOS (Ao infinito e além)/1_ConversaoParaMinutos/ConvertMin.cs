//1. Escreva um programa que leia a quantidade de dias, horas, minutos e segundos do usuário. Calcule o total em segundos. (1 minutos tem quantos segundos? 1 hora tem quantos minutos?)
using System;

namespace ConvertMinutos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite a quantidade de dias: ");
            int dias = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("Digite a quantidade de horas: ");
            int horas = Convert.ToInt32(Console.ReadLine());
         
            Console.Write("Digite a quantidade de minutos: ");
            int minutos = Convert.ToInt32(Console.ReadLine());
    
            Console.Write("Digite a quantidade de segundos: ");
            int segundos = Convert.ToInt32(Console.ReadLine());
            
            int totalSegundos = (dias * 24 * 3600) + (horas * 3600) + (minutos * 60) + segundos;

            Console.WriteLine("O total em segundos é: " + totalSegundos);
        }
    }
}

