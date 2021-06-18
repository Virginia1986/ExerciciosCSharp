using Jogador_JokenpoPOO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jokenpo
{
    class ControleJogo
    {
        public static Jogador CadastroJogador()
        {

            int escolha = 0, i = 1; string nome = default;

            for (i=1; i<=2; i++)
            {
                Console.WriteLine("Escreva sua escolha jogador: 1-Papel / 2-Tesoura /  3-Pedra");
                escolha = Convert.ToInt32(Console.ReadLine());
                if (escolha > 3)
                {
                    Console.WriteLine("Opção Invalida - SALIR");
                    break;
                }
                Console.WriteLine("Nome do Jogador:");
                nome = Console.ReadLine();
                i++;
            }
            
            return new Jogador(escolha, nome);
        }

            

        public static void Vencedor(Jogador jogador1, Jogador jogador2)
        {
            switch (jogador1.Escolha)
            {
                case 1:
                    switch (jogador2.Escolha)
                    {
                        case 1:
                            Console.WriteLine("Empate");
                            break;
                        case 2:
                            Console.WriteLine($"Vencedor:"+jogador2.Nome);
                            break;
                        case 3:
                            Console.WriteLine($"Vencedor:"+jogador1.Nome);
                            break;
                    }
                    break;
                case 2:
                    switch (jogador1.Escolha)
                    {
                        case 1:
                            Console.WriteLine($"Vencedor:" + jogador1.Nome);
                            break;
                        case 2:
                            Console.WriteLine("Empate");
                            break;
                        case 3:
                            Console.WriteLine($"Vencedor:" + jogador2.Nome);
                            break;
                    }
                    break;
                case 3:
                    switch (jogador1.Escolha)
                    {
                        case 0:
                            Console.WriteLine($"Vencedor:" + jogador2.Nome);
                            break;
                        case 1:
                            Console.WriteLine($"Vencedor:" + jogador1.Nome);
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


