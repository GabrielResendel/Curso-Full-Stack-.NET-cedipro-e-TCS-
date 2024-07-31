// 5. Foram anotadas as idades e alturas de 30 alunos. Faça um Programa que determine quantos alunos com mais de 13 anos possuem altura inferior à média de altura desses alunos.
using System;
namespace SomaQuadrado
{
    class Program
    {
        static void Main(string[] args)
        {

        int[] Idade = new int[30];
        double[] Altura = new double[30];

            for (int i = 0;i < 30; i++){
                Console.Write($"Digite a idade do aluno {i+1}: \n");
                Idade[i] = int.Parse(Console.ReadLine());

                Console.Write($"Agora a altura do aluno {i+1}: \n");
                Altura[i] = Convert.ToDouble(Console.ReadLine());
            }

        double MediaAltura = 0;

            for (int i = 0;i < 30; i++){
                MediaAltura += Altura[i];
            }

        int CountAluno= 0;

           for (int i = 0;i < 30; i++){
            if (Idade[i] > 13 && Altura[i] < MediaAltura / 30){
                CountAluno++;
            }
           }

        Console.WriteLine($"O total de alunos com idade superior a 13 anos e altura inferior a media dos alunos que e de {MediaAltura / 30} são de {CountAluno} alunos. ");
        }

        
 
    }    
}