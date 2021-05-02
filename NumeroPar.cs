using System;

namespace Numeros_pares
{
    class NumeroPar
    {
        static void Main(string[] args)
        {
            int i, par;

            for(i = 1; i <=150; i++){
                
                par = i % 2;
                if (par==0){ 
                Console.WriteLine(i);
                }                                
            }
        }
    }
}
