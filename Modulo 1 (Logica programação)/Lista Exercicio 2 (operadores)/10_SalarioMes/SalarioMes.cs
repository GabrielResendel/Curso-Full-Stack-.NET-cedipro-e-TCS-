/*10 Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. Calcule e mostre o total do seu salário no referido mês, sabendo-se que são descontados 11% para o Imposto de Renda, 8% para o INSS e 5% para o sindicato, faça um programa que nos dê:
    a. salário bruto.
    b. quanto pagou ao INSS.
    c. quanto pagou ao sindicato.
    d. o salário líquido.
    e. calcule os descontos e o salário líquido, conforme a tabela abaixo:
MOSTRAR NA TELA O RESUMO DO PAGAMENTO ABAIXO:
+ Salário Bruto        : R$
- IR (11%)                : R$
- INSS (8%)             : R$
- Sindicato ( 5%)      : R$
= Salário Liquido      : R$
           Obs.: Salário Bruto - Descontos = Salário Líquido.*/

using System;


namespace TotalSalario
{
    class Programa
    {
        static void Main(string[] args)
        {
        
        Console.Write("Digite quanto você ganha por hora: ");
        double valorH = Convert.ToDouble(Console.ReadLine());

         Console.Write("Digite quantas horas você trabalhou no mês: ");
        double horasTrab = Convert.ToDouble(Console.ReadLine());

        double salario = valorH * horasTrab;
        double ir = salario * 0.11;
        double inss = salario * 0.08;
        double sind = salario * 0.05;
        double liqui = salario - (ir + inss + sind);

        Console.WriteLine($"Seu salario bruto e: {salario}");
        Console.WriteLine($"Seu desconte de IR e: {ir}");
        Console.WriteLine($"Seu desconte de INSS e: {inss}");
        Console.WriteLine($"Seu desconte de Sindicato e: {sind}");
        Console.WriteLine($"Seu salario liquido e: {liqui}");


        }
    }
}
