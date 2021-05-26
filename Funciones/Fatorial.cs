using System;

namespace Factorial
{
    class Fatorial
    {
        static void Main(string[] args)
        {
            int numero;
           Console.WriteLine("Escreva o numero inteiro:");
            numero = Convert.ToInt32(Console.ReadLine());

            Fatorial(numero, false);

        }
        public static void Fatorial(int numero, bool Show = true)
        {
            int i, factorial = 1;
            if (Show){
                Console.Write($"{numero}!=");
            }

            for (i = numero; i >= 1; i--)
            {
                factorial = factorial * i;

                if (Show)
                {
                    if (i > 1)
                        Console.Write($"{i}x");
                    else { Console.Write($"{i}="); }
                }
            }
            if (Show)
                {
                    Console.Write($"{factorial}!");
                }
              else {
                Console.WriteLine($"{numero}!={factorial}");
                     }
        }
        
    }
}

