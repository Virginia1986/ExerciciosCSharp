using System;

namespace Leituradeanos
{
    class Anos
    {
        static void Main(string[] args)
        {
            int ano, i = 1, valor, mai = 0, men = 0, a=1, b=1;
            

            do
            {
                Console.WriteLine("Escreva o ano de nascimento no formato yyyy:");
                ano = Convert.ToInt32(Console.ReadLine());

                valor = 2021 - ano;

                if (valor <= 18)
                {
                      men= b++;
                }
                else
                { 
                    mai = a++;
                }
               
                i++;
            }
            while (i <= 7);
            

            Console.WriteLine("A quantidade de pessoas maiores de idade são: " + mai);
            Console.WriteLine("A quantidade de pessoas menores de idade são: " + men);

        }
    }
}
