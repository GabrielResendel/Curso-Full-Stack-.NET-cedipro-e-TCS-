using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TV
{
    public class Controle
    {
        public int volume = 15;
        public int canal = 11;
        public int power = 1;

        public int AumentarVolume(){
            return volume++;
            Console.WriteLine($"Volume: {volume}");
        }
        public int DiminuirVolume(){
            return volume--;
            Console.WriteLine($"Volume: {volume}");


        }
        public int MudarCanal(){
            Console.Write("Digite o numero do canal: ");
            return canal = int.Parse(Console.ReadLine());

        }
        public int DesligarTV(){
            return power = 0;
        }
    }
}