using System;

namespace Multiplode3
{
    class Multiplode3
    {
        static void Main(string[] args)
        {
            int  i, mul, som=0;
            for (i = 1; i <= 500; i++)
            {
                
                mul = i % 3;
                
                if (mul==0)
                 {
                     som = i + som;
                    
                 }
                               
            }
            Console.WriteLine("A somátoria dos multiplos de 3 é =" + som);
        }

    }
}
