/* 10.  As Organizações Tabajara resolveram dar um aumento de salário aos seus colaboradores e lhe contraram para desenvolver o programa que calculará os reajustes. Faça um programa que recebe o salário de um colaborador e faça o reajuste segundo o seguinte critério, baseado no salário atual:

    salários até R$ 280,00 (incluindo) : aumento de 20%
    salários entre R$ 280,00 e R$ 700,00 : aumento de 15%
    salários entre R$ 700,00 e R$ 1500,00 : aumento de 10%
    salários de R$ 1500,00 em diante : aumento de 5% 
      Após o aumento ser realizado, informe na tela:

    o c 
     (DE PREFERÊNCIA USAR APENAS UM BLOCO DE PRINT NO FINAL, DENTRO DOS IF’S APENAS PREENCHA AS VARIÁVEIS)*/
using System;
namespace SalarioAumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu salário, e saiba o aumento que teve: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            double aumento = 0;
            double porcen = 0;
            double valPorcen = 0;

                if(salario <= 280.00){
                    porcen = 0.20;
                    valPorcen = salario * porcen;
                    aumento = salario + valPorcen;

                }else if(salario > 280.00 && salario <= 700.00){
                    porcen = 0.15;
                    valPorcen = salario * porcen;
                    aumento = salario + valPorcen;

                }else if(salario > 700.00 && salario <= 1500.00){
                    porcen = 0.10;
                    valPorcen = salario * porcen;
                    aumento = salario + valPorcen;

                }else if(salario > 1500.00){
                    porcen = 0.05;
                    valPorcen = salario * porcen;
                    aumento = salario + valPorcen;
                }else {
                    Console.WriteLine("ERRO!!");
                }

            Console.WriteLine($"\nsalário antes do reajuste: {salario}\npercentual de aumento aplicado: {porcen}%\nvalor do aumento: {valPorcen}\nnovo salário, após o aumento: {aumento}.");


        }
    }
}
