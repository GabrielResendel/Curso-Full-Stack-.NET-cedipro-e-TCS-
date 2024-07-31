using System;
namespace JogoForca
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Jogo da forca Tema Frutas:");

        string[] palavra = new string[]{"pera","uva","goiaba","banana"} ;
        Random aleatorio = new Random();
        int num = aleatorio.Next(0,4);
        char[] vetor = new char[palavra[num].Length];
        string resposta = palavra[num];
        char[] res = new char[palavra[num].Length];

          //para add cada letra numa posição
            for(int i = 0;i < resposta.Length;i++){
                res[i] = resposta[i];
            }
      
        Console.WriteLine("Acerte a Palavra!!!");

            //para imprimir as linhas
            for(int i = 0;i < resposta.Length;i++){
                vetor[i] = '_';
                Console.Write($"{vetor[i]} ");
            }

        int acertos = 0;
        char letra;
        int chance = 6;
        char[] digitados = new char[12];
        int contador = 0;
        

            while(acertos < resposta.Length){
            Console.Write("\nDigite uma letra\n");
            letra = char.Parse(Console.ReadLine());
            bool count = false;
            bool add = false;
            //para verificar se a letra foi digitada
                for(int k = 0;k<= contador;k++){
                    if( digitados[k] == letra){
                        Console.WriteLine("Essa letra ja foi digitada:");
                        add = true;
                    }                    
                }

            if(add == false){
            digitados[contador] = letra ;
            contador++;
            }

                Console.Write("Letras digitadas: ");
                for(int l = 0;l<=contador;l++){
                    Console.Write($"{digitados[l]} ");
                }
                //para adicionar a letra na linha correta
                for (int i = 0;i < resposta.Length;i++){
                    if(letra == palavra[num][i]){
                        acertos++;
                        vetor[i]= letra;
                        count = true;                   
                    }                   
                }

            if(count == false){
                chance--;
            }

            Console.WriteLine("");

                for(int j = 0;j < resposta.Length;j++){
                Console.Write($"{vetor[j]} ");
                }

            if(chance == 0){
                Console.WriteLine($"Você perdeu a palavra era: {resposta}");
                break;
            }
            
            if(acertos == resposta.Length){
                Console.WriteLine("\n Parabens voce acertou!!");
            }
            }
        
          

        }
    }
}
