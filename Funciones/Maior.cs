using System;

namespace NumeroMayor
{
    class Maior
    {
        static void Main(string[] args)
        {
            int tam, maior=0, i;
            do {
                Console.WriteLine("Quantos numeros deseja comparar?");
                tam = Convert.ToInt32(Console.ReadLine());

                int[] Comparar = new int[tam];

                Console.WriteLine("Escreva os números a comparar");
                for (i = 0; i < tam; i++) {
                    Comparar[i] = Convert.ToInt32(Console.ReadLine());
                }
                MaiorValor(i, maior, tam, Comparar);
            }
            while (tam !=0);
        }
        
        public static int MaiorValor(int i, int maior, int tam, int[] Comparar) {
            
            for (i=0; i<tam; i++) {
                if (Comparar[i]>maior) {
                    maior = Comparar[i];

                } }
            Console.WriteLine("O número maior é:" +maior);
            return maior;
        }
                


}

}


