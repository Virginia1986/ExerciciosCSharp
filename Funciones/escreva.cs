using System;

namespace Imprimir_especial
{
    class escreva
    {
        static void Main(string[] args)
        {
            string message;
            int tam;
            message = Console.ReadLine();
            tam= message.Length;
            Imprimir(tam, message);
        }
        static void Imprimir(int tam, string message)
        {
            string local= new string('~', tam); ;
            Console.WriteLine($"  \n{local}\n{message}\n{local}\n");
            

        }
    }
}
