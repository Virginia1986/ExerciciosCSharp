using System;

namespace SomatoriaePar
{
    class SomatoriaePar
    {
        static void Main(string[] args)
        {
            int[] Numeros = new int[5];
            int i= 0;
            int Soma = 0;

            Sorteia(Numeros);
            Somatoria(Soma, Numeros);
            

         
        }
        public static int Sorteia(int[] Numeros)
        {
            int i = 0;
           
            for (i=0; i<5;i++) { 
            Random random = new Random();
            Numeros[i] = random.Next(0, 100);
                Console.WriteLine( Numeros[i]);
            }
            return 1;

        }

        public static int Somatoria(int Soma, int[] Numeros)
        {
            int i = 0;

            for (i = 0; i < 5; i++)
            {
                if (Numeros[i] % 2 == 0) {
                    Soma = Soma + Numeros[i];
                }
                
            }

            Console.WriteLine("A somatoria dos números pares é:"+Soma); 
            return Soma;

        }
    }
}
