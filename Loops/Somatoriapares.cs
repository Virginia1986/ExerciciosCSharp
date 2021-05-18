using System;

namespace Somatoriapares
{
    class Somatoriapares
    {
        static void Main(string[] args)
        {
            int numero = 1, soma = 0, i=1;

            do
            {
                Console.WriteLine("Ingrese número entero positivo:");
                numero = Convert.ToInt32(Console.ReadLine());
                i++;

                if (numero%2==0) {
                    soma = soma + numero;
                }
            }
            while (i <= 6);
            Console.WriteLine("A soma dos numeros pares é:" + soma);
                

              




        }
    }
}
