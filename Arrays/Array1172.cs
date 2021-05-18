using System;

namespace Arrays
{
    class ArrayReplacement1172
    {
        static void Main(string[] args)
        {
            int[] X= new int[10]; 
            int i;
            
            for (i = 0; i < 10; i++) {
               X[i]=Convert.ToInt32(Console.ReadLine());
                if (X[i] <= 0)
                {
                    X[i] = 1;
                }
                Console.WriteLine($"X[{i}] = {X[i]}");
                    }
        }
    }
}
