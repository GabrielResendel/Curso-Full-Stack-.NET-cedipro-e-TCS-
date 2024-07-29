using System;
namespace JogoAdivinhação
{
    class Program
    {
        static void Main(string[] args)
        { 
        Console.Write("Ajuste o nivel de dificuldade (F = Facil / M = Medio / D = Difícil): ");
        char nivel = char.Parse(Console.ReadLine().ToUpper());
        
        Random aleatorio = new Random();
        int life = 0;
        int res;

            switch (nivel)
            {
            
            case 'F': 
            Console .WriteLine("Adivinhe o Numero de 1 a 10 : \nVocê tem 3 tentativas\n");
            int valF = aleatorio.Next(1, 11);
            life = 3;

                do{
                    Console.Write("Digite o numero: ");
                    res = int.Parse(Console.ReadLine());
                   
                    if (res != valF){
                       life--;
                       Console.WriteLine($"Você errou! Tente novamente! tentativas Restantes: {life}\n");                       
                    }else {
                        Console.WriteLine("Parabens Você acertou!!\n");
                    }

                    if (life == 0){
                        Console.WriteLine($"Voce Perdeu O Valor correto era : {valF}\n");
                        break;
                    }
                } while (res != valF);
                break;

            case 'M':
            Console.WriteLine("Adivinhe o numero de 1 a 50: \nVocê tem 4 tentativas\n");
            int valM = aleatorio.Next(1,51);
            life = 4;

                do{
                    Console.Write("Digite o numero: ");
                    res = int.Parse(Console.ReadLine());
                   
                    if (res != valM){
                       life--;
                       Console.WriteLine($"Você errou! Tente novamente! tentativas Restantes: {life}\n");                       
                    }else {
                        Console.WriteLine("Parabens Você acertou!!\n");
                    }

                    if (life == 0){
                        Console.WriteLine($"Voce Perdeu O Valor correto era : {valM}\n");
                        break;
                    }
                } while (res != valM);
                break;

            case 'D':
            Console.WriteLine ("Adivinhe o numero de 1 a 100: \nVocê tem 5 tentativas\n");
            int valD = aleatorio.Next(1,101);
            life = 5;

                do{
                    Console.Write("Digite o numero: ");
                    res = int.Parse(Console.ReadLine());
                   
                    if (res != valD){
                       life--;
                       Console.WriteLine($"Você errou! Tente novamente! tentativas Restantes: {life}\n");                       
                    }else {
                        Console.WriteLine("Parabens Você acertou!!\n");
                    }

                    if (life == 0){
                        Console.WriteLine($"Voce Perdeu O Valor correto era : {valD}\n");
                        break;
                    }
                } while (res != valD);
                break;

                default:
                Console.WriteLine("[ERRO] Nivel Invalido!\n");
                break;
            }
            

        }
    }
}
