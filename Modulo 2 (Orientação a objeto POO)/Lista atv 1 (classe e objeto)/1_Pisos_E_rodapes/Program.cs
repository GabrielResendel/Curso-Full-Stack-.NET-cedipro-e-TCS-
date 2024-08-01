using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Pisos_E_rodapes
{
    class Program
    {
        static void Main(string[] args)
        {

            Retangulo x;

            x = new Retangulo();
            

            Console.Write("Digite o Tamanho do Comprimento ");
            x.A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o Tamanho do Comprimento ");
            x.B = Convert.ToDouble(Console.ReadLine());

            double area = x.CalcularArea();
            double perimetro = x.CalcularPerimetro();

            Console.WriteLine($"O numero de pisos são: {area}\nO numero de rodapes são: {perimetro}");

            

           










        }

    }
}