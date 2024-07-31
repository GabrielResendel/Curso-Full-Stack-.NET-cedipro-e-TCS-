/*3. Faça um programa que leia e valide as seguintes informações: 

A Nome: tem que ser maior que 3 caracteres; (comando Length)

B Idade: entre 0 e 150; 

C Salário: maior que zero; 

D Sexo: 'f' ou 'm'; 

E Estado Civil: 's', 'c', 'v', ‘d';

Se o usuário digitar um valor fora do que foi pedido, mostrar um erro e pedir para digitar novamente.*/

using System;
namespace LeiaEvalide
{
    class programa
    {
        public static void Main(string[] args)
        {
            string nome;
            int idade;
            char sexo,EstadoCivil;
            double salario;

            Console.Write("Digite o Nome: ");
            nome = Console.ReadLine();
            
                while (nome.Length < 3)
                {
                    Console.Write("O nome deve conter mais de 3 caracter \nDigite novamente:  ");
                    nome = Console.ReadLine();
                }

            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

                while (idade < 0 || idade > 150)
                {
                    Console.Write("Digite uma idade valida (o a 150):  ");
                    idade = int.Parse(Console.ReadLine());

                }

            Console.Write("Digite seu salario: ");
            salario = Convert.ToDouble(Console.ReadLine());

                while (salario < 0)
                {
                    Console.Write("O salario tem q ser maior que 0 \nDigite novamente: ");
                    salario = Convert.ToDouble(Console.ReadLine());

                }
    
            Console.Write("Digite seu Sexo (F/M): ");
            sexo = char.Parse(Console.ReadLine().ToUpper());

                while (true)
                {
                    if(sexo == 'F'||sexo == 'M'){
                        break;
                    }else {
                    Console.Write("Sexo invalido!! \nDigite um sexo valido (F= feminino / M= masculino): ");
                    sexo = char.Parse(Console.ReadLine().ToUpper());
                    }
                }

            Console.Write("Digite o estado civil ('S' para solteiro, 'C' para casado, 'V' para viúvo, 'D' para divorciado): ");
            EstadoCivil = char.Parse(Console.ReadLine().ToUpper());

            while (true)
            {
                if(EstadoCivil == 'S'||EstadoCivil == 'C' || EstadoCivil == 'V' || EstadoCivil == 'D'){
                    break;
                }else {
                    Console.Write("Estado Civil invalido!! \nDigite um valor valido: ");
                    EstadoCivil = char.Parse(Console.ReadLine().ToUpper());
                }
            }
            Console.WriteLine("\n------Result-----\n");
            Console.WriteLine($"Nome: {nome} \nIdade: {idade} \nSalario: {salario} \nSexo: {sexo} \nEstado Civil: {EstadoCivil}");

        }
    }
}
