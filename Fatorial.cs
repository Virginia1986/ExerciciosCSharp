using System;

namespace _11Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, fatorial=1,n=-1;
            while (n < 0) { 
            Console.WriteLine("Escreva o número que você deseja o fatorial:");
            n = Convert.ToInt32(Console.ReadLine());
            }
            for (i = n; i >= 1; i--) { 
            fatorial = fatorial * i;
            
            }
            Console.WriteLine(fatorial);
        }
    }
}
