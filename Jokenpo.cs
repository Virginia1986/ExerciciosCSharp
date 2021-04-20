using System;

namespace Jokenpo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int comp, jogadorescolha;
            Random random = new Random();
            comp = random.Next(0,3);

            
            Console.WriteLine("Escolhe sua arma:[0]- Pedra / [1]-Papel / [2]-Tesoura");
            jogadorescolha = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Computador Escolheu arma:"+comp.ToString());
            Console.WriteLine("Sua escolha:" + jogadorescolha);



            switch (comp)
            {
                case 0:
                    switch (jogadorescolha)
                    {
                        case 0:
                            Console.WriteLine("Empate");
                            break;
                        case 1:
                            Console.WriteLine("Ganhou Usuario");
                            break;
                        case 2:
                            Console.WriteLine("Ganhou Computador");
                            break;
                    }
                    break;
                case 1:
                    switch (jogadorescolha)
                    {
                        case 0:
                            Console.WriteLine("Ganhou Computador");
                            break;
                        case 1:
                            Console.WriteLine("Empate");
                            break;
                        case 2:
                            Console.WriteLine("Ganhou Usuario");
                            break;
                    }
                    break;
                case 2:
                    switch (jogadorescolha)
                    {
                        case 0:
                            Console.WriteLine("Ganhou Usuario");
                            break;
                        case 1:
                            Console.WriteLine("Ganhou Computador");
                            break;
                        case 2:
                            Console.WriteLine("Empate");
                            break;
                    }
                    break;
                default:

                    Console.WriteLine("Não existe opção válida");
                break;
            }
        }
    }
}



