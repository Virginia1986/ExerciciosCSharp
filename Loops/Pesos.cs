using System;

namespace Pesos
{
    class Pesos
    {
        static void Main(string[] args)
        {
            int peso = 0, i=1, maior = 0;
            do {
                Console.WriteLine("Escreva o peso em kg:");
                peso=Convert.ToInt32(Console.ReadLine());
                
                if (i==1)
                {
                    maior = peso; 
                }
                i++;
            }

            while (i <= 5);

            Console.WriteLine("O maior peso entre os 5 inseridos é: " + maior);
        }
    }
}
