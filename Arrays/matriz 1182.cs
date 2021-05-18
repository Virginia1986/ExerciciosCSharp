using System;

namespace Coluna_na_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] Matriz = new float[12, 12];
            int i, j, linhadeoperação;
            string caracter;
            float  soma = 0; 

            linhadeoperação = Convert.ToInt32(Console.ReadLine());
            caracter = Console.ReadLine();
            
            for (i = 0; i < 12; i++)
            { 
                for (j=0; j<12; j++) 
                {
                    Matriz[i,j]= float.Parse(Console.ReadLine());
                } 
            }
            for (i= 0; i < 12; i++)
            {
                soma += Matriz[i, linhadeoperação];
            }
            if (caracter == "M")
            {
                Console.WriteLine($"{soma / 12:F1}");
            }
            else
            {
                Console.WriteLine($"{soma:F1}");

            }
        }
    }
}
