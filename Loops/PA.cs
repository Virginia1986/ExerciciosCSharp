using System;

namespace _6Progressãoaritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, n, PA, i=1;

            Console.WriteLine("Escreva o primeiro número da sequencia:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva a razão da sequencia");
            r = Convert.ToInt32(Console.ReadLine());

            do
            {        
               PA = n + r*i;
                Console.WriteLine(PA);
                i++;
                
            }
            while (i<=10);

            

        }
    }
}
