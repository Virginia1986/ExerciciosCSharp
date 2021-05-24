using System;


namespace Função_Voto
{
    class Program
    {
        static void Main(string[] args)
        {
            int  ano = 0;
            Console.WriteLine("Escreva o ano de nascimento (Formato yyyy):");
            ano = Convert.ToInt32(Console.ReadLine());

             voto(ano);
         }
        public static int voto(int ano) {
            int a, dif;
            a = DateTime.Now.Year;
            dif = a - ano;

            if (dif < 16) {
                Console.WriteLine($"Sua idade é {dif} seu voto é 'Negado'");
            }
            else if (dif >= 18 && dif <= 65) {
                Console.WriteLine($"Sua idade é {dif} seu voto é 'Obrigatorio'");
            }
            else  {
                Console.WriteLine($"Sua idade é {dif} seu voto é 'Opcional'");
            }
             return 1;
              }
        }
}

