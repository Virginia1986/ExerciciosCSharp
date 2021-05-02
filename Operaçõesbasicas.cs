using System;

namespace Operaçõesbasicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1,a, b, operador, resultado;

            do
            {
                Console.WriteLine("Escreva  o valor 1:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escreva  o valor 2:");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escolha uma operação disponível: [ 1 ] somar / [2] multiplicar/ [3] maior / [4] novos números / [ 5 ] sair do programa");
                operador = Convert.ToInt32(Console.ReadLine());

                switch (operador)
                {

                    case 1:
                        resultado = a + b;
                        Console.WriteLine("A somatória dos números é:" + resultado);
                        break;

                    case 2:
                        resultado = a * b;
                        Console.WriteLine("A multiplicação de ambos números é:" + resultado);
                        break;

                    case 3:
                        if (a > b)
                        {
                            resultado = a;
                            Console.WriteLine("O número maior entre ambos é:" + resultado);
                        }
                        else
                        {
                            resultado = b;
                            Console.WriteLine("O número maior entre ambos é:" + resultado);
                        }
                        break;


                    case 4:
                        Console.WriteLine("Ingrese novos valores:");

                        break;

                    case 5:
                        Console.WriteLine("Encerrando o programa");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Resposta inválida");
                        break;
                }
                i++;

            }
            while (i<= 1 || operador ==4 ); 


        }
    }
}
