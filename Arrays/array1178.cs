using System;
using System.Globalization;

namespace Solução_1178
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] N = new double[100];
            int i;

            N[0] = Convert.ToDouble(Console.ReadLine());
            for (i = 1; i < 100; i++) {
                N[i] = N[i - 1] / 2.0;
            }
            for (i = 0; i < 100; i++)
            {
                Console.WriteLine($"N[{i}] = " + N[i].ToString("N4", CultureInfo.CreateSpecificCulture("en-US")));
            }
        }
    }
}
