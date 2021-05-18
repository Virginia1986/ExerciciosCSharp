using System;

namespace Array1173
{
    class array1173
    {
        static void Main(string[] args)
        {
            int[] N = new int[10];
            int i, n;
            
                n = Convert.ToInt32(Console.ReadLine());
                N[0] = n;

            for (i = 1; i < 10; i++)
            {
                N[i] = N[i - 1] * 2;
            }
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"N[{i}] = {N[i]}");
            }
    }
}
}
