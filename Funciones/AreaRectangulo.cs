using System;

namespace Arearectangulo
{
    class AreaRectangulo
    {
        static void Main(string[] args)
        {
            int l, c, area;

            Console.WriteLine("Escreva lado a:");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escreva lado b");
            c = Convert.ToInt32(Console.ReadLine());

            area = Calculararea(l, c);
            Console.WriteLine($"A area do rectangulo é ={area}");

        }
        
        public static int Calculararea(int l, int c) 
        {
            int area = 0;
            area = l * c;
            return area;
                
        }

    }
}
