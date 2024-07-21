/*   8. Uma empresa de pesquisas precisa tabular os resultados da seguinte enquete feita a um grande quantidade de organizações:

"Qual o melhor Sistema Operacional para uso em servidores?"

 

As possíveis respostas são:

 

a- Windows Server

b- Unix

c- Linux

d- Netware

e- Mac OS

f- Outro

Você foi contratado para desenvolver um programa que leia o resultado da enquete e informe ao final o resultado da mesma. O programa deverá ler os valores até ser informado o valor 0, que encerra a entrada dos dados. Não deverão ser aceitos valores além dos válidos para o programa (0 a 6). Os valores referentes a cada uma das opções devem ser armazenados num vetor. Após os dados terem sido completamente informados, o programa deverá calcular a percentual de cada um dos concorrentes e informar o vencedor da enquete. O formato da saída foi dado pela empresa, e é o seguinte:

Sistema Operacional     Votos   %
-------------------     -----   ---

Windows Server           1500   17%

Unix                     3500   40%

Linux                    3000   34%

Netware                   500    5%

Mac OS                    150    2%

Outro                     150    2%

-------------------     -----

Total                    8800

Sistema Operacional mais votado foi o Unix.

Com 3500 votos, correspondendo a 40% dos votos. */
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] votos = new int[6];
        string[] sistemasOperacionais = {
            "Windows Server",
            "Unix",
            "Linux",
            "Netware",
            "Mac OS",
            "Outro"
        };

        int entrada;

            do
            {
                Console.WriteLine("Qual o melhor Sistema Operacional para uso em servidores?");
                Console.WriteLine("1- Windows Server");
                Console.WriteLine("2- Unix");
                Console.WriteLine("3- Linux");
                Console.WriteLine("4- Netware");
                Console.WriteLine("5- Mac OS");
                Console.WriteLine("6- Outro");
                Console.WriteLine("0- Encerrar");
                Console.Write("Opção: ");
                
                entrada = int.Parse(Console.ReadLine());

                if (entrada >= 1 && entrada <= 6)
                {
                    votos[entrada - 1]++;
                }
                else if (entrada != 0)
                {
                    Console.WriteLine("Opção inválida. Por favor, digite um número de 0 a 6.");
                }

            } while (entrada != 0);

        int totalVotos = 0;
            for (int i = 0; i < votos.Length; i++)
            {
                totalVotos += votos[i];
            }

        Console.WriteLine("\nSistema Operacional     Votos   %");
        Console.WriteLine("-------------------     -----   ---");

            for (int i = 0; i < votos.Length; i++)
            {
                double percentual = (totalVotos > 0) ? (votos[i] / (double)totalVotos) * 100 : 0;
                Console.WriteLine($"{sistemasOperacionais[i],-20} {votos[i],5}   {percentual,5:F1}%");
            }

        Console.WriteLine("-------------------     -----");
        Console.WriteLine($"Total                  {totalVotos,5}");

        int indiceVencedor = 0;
            for (int i = 1; i < votos.Length; i++)
            {
                if (votos[i] > votos[indiceVencedor])
                {
                    indiceVencedor = i;
                }
            }

        string sistemaVencedor = sistemasOperacionais[indiceVencedor];
        int votosVencedor = votos[indiceVencedor];
        double percentualVencedor = (totalVotos > 0) ? (votosVencedor / (double)totalVotos) * 100 : 0;

        Console.WriteLine($"\nSistema Operacional mais votado foi o {sistemaVencedor}.");
        Console.WriteLine($"Com {votosVencedor} votos, correspondendo a {percentualVencedor:F1}% dos votos.");
    }
}



