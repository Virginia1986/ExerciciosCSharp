using System;

namespace URI1189
{
 
        class Program
        {
            static void Main(string[] args)
            {
                float[,] Matriz = new float[12, 12];
                string Caracter;
                int i, j;
                float soma = 0;

                Caracter = Console.ReadLine();

                for (i = 0; i < 12; i++)
                {
                    for (j = 0; j < 12; j++)
                    {
                        Matriz[i, j] = float.Parse(Console.ReadLine());

                    }
                }


                for (i = 1; i <= 10; i++)
                {
                    if (i <= 5) {
                        for (j = 0; j < i; j++)
                        {
                            soma += Matriz[i, j];
                        }
                    }
                    else for (j=0;j<11-i;j++) { 
                        soma += Matriz[i, j]; 
                    }
                }
                if (Caracter == "M")
                {
                    Console.WriteLine($"{(soma / 30):F1}");
                }
                else
                {
                    Console.WriteLine($"{soma:F1}");
                }
            }
        }
    }


