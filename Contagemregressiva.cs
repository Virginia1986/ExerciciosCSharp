using System;

namespace Contagem_regressiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i=10;i>=0;--i)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(30);
            }
        }
    }
}
