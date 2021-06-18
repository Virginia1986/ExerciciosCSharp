using System;
using System.Collections.Generic;
using System.Text;

namespace Jogador_JokenpoPOO
{
    public class Jogador
    {
        private int escolha;
        private string nome;

        public Jogador(int escolha, string nome)
        {
            this.escolha = escolha;
            this.nome = nome;
        }
        
        public int Escolha
        {
            get => escolha;
             
        }
        public string Nome
        {
            get => nome;

        }

    }
}
