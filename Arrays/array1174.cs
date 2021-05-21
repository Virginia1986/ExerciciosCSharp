using System;
using System.Globalization;

namespace array1174
{
    class Program
    {
        static void Main(string[] args)
        {
            double[]A = new double[5];
            int i;

            for (i=0; i<5; i++)
            {
               A[i]= Convert.ToDouble(Console.ReadLine());
            }
                for (i = 0; i < 5; i++)
                {
                if (A[i] <= 10.0)
                {
                    Console.WriteLine($"A[{i}]="+ A[i].ToString("N1", CultureInfo.CreateSpecificCulture("en-US")));
                   
                    }
            
                }
        }
    }
}
