using System;
namespace JogoForca
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Jogo da forca Tema Frutas:");

        string[] palavra = new string[]{"maca","uva","goiaba","banana"} ;
        Random aleatorio = new Random();
        int num = aleatorio.Next(0,4);
        char[] vetor = new char[palavra[num].Length];
        string resposta = palavra[num];
        char[] res = new char[palavra[num].Length];

            for(int i = 0;i < resposta.Length;i++){
                res[i] = resposta[i];
            }
      
        Console.WriteLine("Acerte a Palavra!!!");
        
            for(int i = 0;i < resposta.Length;i++){
                vetor[i] = '_';
                Console.Write($"{vetor[i]} ");
            }

        int acertos = 0;
        char letra;
        int chance = 6;

            while(acertos < resposta.Length){
                Console.Write("\nDigite uma letra\n");
                letra = char.Parse(Console.ReadLine());

                for (int i = 0;i < resposta.Length;i++){
                    if(letra == palavra[num][i]){
                        acertos++;
                        vetor[i]= letra;
                    }else{
                        chance--;
                        continue;
                    }                   
                }

                for(int j = 0;j < resposta.Length;j++){
                Console.Write($"{vetor[j]} ");
                }
                if(chance == 0){
                    Console.WriteLine($"Você perdeu a palavra era: {resposta}");
                    break;
                }
            }
        
          

        }
    }
}
