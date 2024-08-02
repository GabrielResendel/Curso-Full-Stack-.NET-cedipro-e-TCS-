using System;

namespace Pisos_E_rodapes
{
    class Program
    {
        static void Main(string[] args)
        {

            int option = 0;
            Retangulo x;
            x = new Retangulo();
            

            Console.Write("Digite o Tamanho do Comprimento: ");
            x.A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o Tamanho da Largura: ");
            x.B = Convert.ToDouble(Console.ReadLine());
         
            Console.Clear();


            double area = x.CalcularArea();
            double perimetro = x.CalcularPerimetro();

                do{
                Console.WriteLine("\n\nSelecione uma opção : ");
                Console.WriteLine("1 - Mudar valor do comprimento.");
                Console.WriteLine("2 - Mudar valor da Largura .");
                Console.WriteLine("3 - Mostrar o tamanho do retangulo.");
                Console.WriteLine("4 - Mostrar quantos pisos e rodapes sera necessario.");

                Console.Write("Digite a Opção: ");
                option = int.Parse(Console.ReadLine());

                    if(option == 1){
                        Console.Clear();
                        Console.WriteLine("Digite o novo valor do comprimento: ");
                        x.A = x.MudarValor();
                    }else if(option == 2){
                        Console.Clear();
                        Console.WriteLine("Digite o novo valor da largura: ");
                        x.B = x.MudarValor();
                    }else if(option == 3){
                        Console.Clear();
                        x.RetornarValor();
                    }else if(option == 4){
                        Console.Clear();
                        Console.Write($"Serão necessario:\nPisos: {area}\nRodapes: {perimetro}");
                    }else if(option == 0) {
                        Console.Clear();
                        Console.WriteLine("Programa finalizado!!");
                    }else {
                        Console.WriteLine("[ERRO] opção invalida! digite novamente!");
                    }
            
                }while(option != 0);

        }

    }
}