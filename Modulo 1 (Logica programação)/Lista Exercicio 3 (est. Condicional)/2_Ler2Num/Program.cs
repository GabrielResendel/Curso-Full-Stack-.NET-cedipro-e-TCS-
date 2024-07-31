// 2. Faça um Programa que leia 2 números e em seguida pergunte ao usuário qual operação ele deseja realizar (c). O resultado da operação deve ser acompanhado de uma frase que mostre o resultado e se ele  é:
   // par ou ímpar;
   // positivo ou negativo;
   // inteiro ou decimal. 
 using System;
 using System.Globalization;

 namespace Ler2Num
 {
    class Program
    {
        static void Main(string[] args)
        {
        
        Console.Write("Digite um numero: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite outro numero: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite qual operação você deseja usar (Adicao, Subtracao, Multiplicacao ou Divisao): ");
        string  op = Console.ReadLine().ToLower();
        double res = 0;
            
            //Definição da operação
            if(op == "adicao"){
                
                res = num1 + num2;
                
            }else if (op == "subitracao"){

                res = num1 - num2;
            }else if (op == "multiplicacao"){

                res = num1 * num2;
            }else if (op == "divisao"){
                if(num2 == 0){
                    Console.WriteLine("Não e possivel dividir por 0!");
                }else {
                res = num1 / num2;
                }
            }else {
                Console.WriteLine("Operação invalida!!");
            }

                //Resultado
                Console.WriteLine($"o resultado da operação e: {res}");

                if(res % 2 == 0){
                    Console.WriteLine("o valor e par");
                }else {
                    Console.WriteLine("o valor e ímpar");
                }

                if(res < 0){
                    Console.WriteLine("o valor e negativo");
                }else {
                    Console.WriteLine("o valor e positivo");
                }

                if(res % 1 == 0){
                    Console.WriteLine("o valor e do tipo inteiro");
                }else {
                    Console.WriteLine("o valor e do tipo decimal");
                }
        }
    }
 }
