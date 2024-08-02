using System;
namespace TV
{
    class Program
    {
        static void Main(string[] args)
        {

        Controle controle = new Controle();
        char comand = '@';

        Console.WriteLine("TV DIGITAL");

            do
            {
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║               ____                     ║");
            Console.WriteLine("║              /    \\                    ║");
            Console.WriteLine("║             /______\\                   ║");
            Console.WriteLine("║             |      |                   ║");
            Console.WriteLine("║             |  []  |                   ║");
            Console.WriteLine("║             |______|                   ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.WriteLine("Comandos:");
            Console.WriteLine("+ Almentar volume | - Diminuir volume | > Mudar canal | @ Desligar TV");
            
            Console.Write("Digite o Comando:");
            comand = char.Parse(Console.ReadLine());

                if(comand == '+'){
                Console.Clear();
                    if(controle.volume > 100){
                        Console.WriteLine("Você atingiu o volume maximo!!");
                    }else {
                        controle.AumentarVolume(); 
                        Console.WriteLine($"Volume: {controle.volume}");
                    }
                }else if(comand == '-'){
                Console.Clear();
                    if (controle.volume <= 0){
                        Console.WriteLine("Você atingiu o volume minimo!!");
                    }else{
                        controle.DiminuirVolume();
                        Console.WriteLine($"Volume: {controle.volume}");
                    }
                    
                }else if(comand == '>'){
                Console.Clear();
                    controle.MudarCanal();
                    Console.Clear();
                    Console.WriteLine($"Canal: {controle.canal}");

                }else if(comand == '@'){
                Console.Clear();
                    controle.DesligarTV();
                    Console.WriteLine("POWER OFF\nGOOD BYE!!");
                }else {
                Console.Clear();
                    Console.WriteLine("Comando invalido!!");
                }
            
            } while (comand != '@');

        }
    }
}
