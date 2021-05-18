using System;

namespace Tabuada
{
    class Tabuada
    {
        static void Main(string[] args)
        {
            int i, numero, resultado;
            Console.WriteLine("Escreva o número que você quer mostrar na tabuada (Entre 0 -10)");
            numero = Convert.ToInt32(Console.ReadLine());
            for(i=0; i<=10; i++)
            {
                resultado = numero * i;
                Console.WriteLine($"{numero} * {i} = { resultado}");
                        
            }
        }
    }
}
