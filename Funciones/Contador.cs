using System;

namespace Contador
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            Contador(i);

            static void Contador(int i) {
                int a, b, c;
                for (i = 1; i <= 10; i++) {
                    Console.WriteLine(i);
                }
                for (i = 10; i >= 1; i=i-2)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Inicio");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Fim");
                b=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Passo");
                c= Convert.ToInt32(Console.ReadLine());

                for (i=a;i<=b;i=i+c) {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
