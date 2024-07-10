// 8.  Faça um Programa que leia três números e mostre-os em ordem decrescente. (Entenda que não serão digitados valores iguais).
using System;
namespace Decrescente
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro numero: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite mais um numero: ");
            int num3 = int.Parse(Console.ReadLine());

            int pos1,pos2,pos3;
            
            if (num1 >= num2 && num1 >= num3)
        {
            pos1 = num1;
            if (num2 >= num3)
            {
                pos2 = num2;
                pos3 = num3;
            }
            else
            {
                pos2 = num3;
                pos3 = num2;
            }
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            pos1 = num2;
            if (num1 >= num3)
            {
                pos2 = num1;
                pos3 = num3;
            }
            else
            {
                pos2 = num3;
                pos3 = num1;
            }
        }
        else
        {
            pos1 = num3;
            if (num1 >= num2)
            {
                pos2 = num1;
                pos3 = num2;
            }
            else
            {
                pos2 = num2;
                pos3 = num1;
            }
        }

            Console.WriteLine($"Os números em ordem decrescente {pos1} {pos2} {pos3}");
            
               
            }

          
        }
    }
