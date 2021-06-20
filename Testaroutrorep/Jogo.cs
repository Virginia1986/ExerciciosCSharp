using Jokenpo;
using System;

namespace Jogador_JokenpoPOO
{
    class Jogo
    {
        static void Main(string[] args)
        {
            Jogador jogador1, jogador2;

            jogador1 = ControleJogo.CadastroJogador();
            jogador2 = ControleJogo.CadastroJogador();

            ControleJogo.Vencedor(jogador1, jogador2);
        }

       
    }
}
