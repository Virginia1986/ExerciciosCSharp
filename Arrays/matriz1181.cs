using System;
using System.Globalization;

namespace array1181
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] matriz = new float[12, 12];
            float soma = 0;
            String caractere;
            int i, j, linhaOperacao;
            linhaOperacao = Convert.ToInt32(Console.ReadLine());
            caractere = Console.ReadLine();

            for (i = 0; i < 12; ++i)
            {
                for (j = 0; j < 12; ++j)
                {
                    matriz[i, j] = float.Parse(Console.ReadLine());
                }
            }

            for (j = 0; j < 12; j++)
            {
                soma += matriz[linhaOperacao, j];
            }

            if (caractere == "M")
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
