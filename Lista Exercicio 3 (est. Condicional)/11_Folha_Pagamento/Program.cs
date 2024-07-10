/*11. Faça um programa para o cálculo de uma folha de pagamento, sabendo que os descontos são do Imposto de Renda, que depende do salário bruto (conforme tabela abaixo) e 3% para o Sindicato e que o FGTS corresponde a 11% do Salário Bruto, mas não é descontado (é a empresa que deposita) e INSS que deverá discontar 10%. O Salário Líquido corresponde ao Salário Bruto menos os descontos. O programa deverá pedir ao usuário o valor da sua hora e a quantidade de horas trabalhadas no mês.

    Desconto do IR:
    Salário Bruto até 900 (inclusive) - isento
    Salário Bruto até 1500 (inclusive) - desconto de 5%
    Salário Bruto até 2500 (inclusive) - desconto de 10%
    Salário Bruto acima de 2500 - desconto de 20% Imprima na tela as informações, dispostas conforme o exemplo abaixo. No exemplo o valor da hora é 5 e a quantidade de hora é 220.*/
using System;
namespace FolhaPagamento
{
    class Program  
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da sua hora de trabalho: ");
            double valHora = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite quantas horas trabalhou: ");
            double horasTrab = Convert.ToDouble(Console.ReadLine());

            double salario = valHora * horasTrab;

            double valIR = 0;
            double valINSS = 0;
            double valFGTS = 0;
            double salaLiquido = 0;

            if(salario <= 900){
                valIR = 0;
                valINSS = salario * 0.10;
                valFGTS = salario * 0.11;
                salaLiquido = salario - valIR - valINSS;
            } else if( salario > 900 && salario <= 1500){
                valIR = salario * 0.05;
                valINSS = salario * 0.10;
                valFGTS = salario * 0.11;
                salaLiquido = salario - valIR - valINSS;
            }else if(salario > 1500 && salario <= 2500){
                valIR = salario * 0.10;
                valINSS = salario * 0.10;
                valFGTS = salario * 0.11;
                salaLiquido = salario - valIR - valINSS;
            }else if(salario > 2500){
                valIR = salario * 0.20;
                valINSS = salario * 0.10;
                valFGTS = salario * 0.11;
                salaLiquido = salario - valIR - valINSS;
            }else{
                Console.WriteLine("[ERRO]");
            }


            Console.WriteLine($"\nSalario Bruto: R$ {salario}\nIR: {valIR}\nINSS: R$ {valINSS}\nFGTS: R$ {valFGTS}\nSalario Liquido: R$ {salaLiquido} ");

        }
    }
}