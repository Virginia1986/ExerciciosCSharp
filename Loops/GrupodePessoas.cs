using System;

namespace _10Grupodepessoas
{
    class GrupodePessoas
    {
        static void Main(string[] args)
        {
            string nome, sexo, nomeVelho ="\0";
            int idade = 0, i = 0, maior = 0, avg = 0, media = 0, mul = 0;

            for (i=0; i<=3; i++){

                Console.WriteLine("Escreva o nome da pessoa " + i + ":");
                nome = Console.ReadLine();
                Console.WriteLine("Escreva o sexo da pessoa " + i + "( Escreva: M/F):");
                sexo = Console.ReadLine();
                Console.WriteLine("Escreva a idade da pessoa " + i  +":");
                idade = Convert.ToInt32(Console.ReadLine());

                avg = avg+idade;

                if (sexo.Equals("M")){

                    
                    if (nomeVelho == "/0" || idade > maior)
                    {

                        maior = idade; 
                        nomeVelho = nome;

                    }
                                       
                }
                else if(sexo.Equals("F") && idade > 20 ){
                    mul = mul + 1;
                }

            }
            Console.WriteLine("O NOME DO HOMEM MAIS VELHO É:"+ nomeVelho);
            media = avg / i;
            Console.WriteLine("A média de idades é:" +media);
            Console.WriteLine("As mulheres mais de 20 são:" +mul);
        }
    }
}
