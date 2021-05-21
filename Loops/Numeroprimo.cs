using System;

namespace _7Numeroprimo
{
    class Numeroprimo
    {
        static void Main(string[] args)
        {
            int i, n=0, c=0;

            Console.WriteLine("Escreva o número inteiro positivo");
            n = Convert.ToInt32(Console.ReadLine());

            for (i=n; i >0; i--) 
            {
                if (n % i == 0)
                {
                    c++;
                }
                
            }

            if (c==2){ 
            Console.WriteLine("Numero é primo"); }

            else{
                Console.WriteLine("Não é numero primo");
            }



        }
    }
}
