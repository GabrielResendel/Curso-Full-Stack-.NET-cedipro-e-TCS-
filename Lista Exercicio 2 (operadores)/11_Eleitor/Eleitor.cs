//11 Escreva um algoritmo para ler o número total de eleitores de um município, o número de votos brancos, nulos e válidos. Calcular e escrever o percentual que cada um representa em relação ao total de eleitores. 
using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Número total de eleitores: ");
        int totalEleitores = int.Parse(Console.ReadLine());
        
        Console.Write("Número de votos brancos: ");
        int votosBrancos = int.Parse(Console.ReadLine());
       
        Console.Write("Número de votos nulos: ");
        int votosNulos = int.Parse(Console.ReadLine());
       
        Console.Write("Número de votos válidos: ");
        int votosValidos = int.Parse(Console.ReadLine());

       
        double percentualBrancos = (double)votosBrancos / totalEleitores * 100;
        
        double percentualNulos = (double)votosNulos / totalEleitores * 100;
        
        double percentualValidos = (double)votosValidos / totalEleitores * 100;

        Console.WriteLine("\nPercentual de votos em relação ao total de eleitores:");
        Console.WriteLine("Votos brancos: " + percentualBrancos.ToString("F2") + "%");
        Console.WriteLine("Votos nulos  : " + percentualNulos.ToString("F2") + "%");
        Console.WriteLine("Votos válidos: " + percentualValidos.ToString("F2") + "%");
    }
}
