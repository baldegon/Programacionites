using System;

namespace Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a=0; b=0;
            

            Console.WriteLine("Ingrese el primer numero: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            b = int.Parse(Console.ReadLine());
        
            if (a >= b)
            {
                Console.WriteLine("El numero A es el mayor");
            }
            else
            {
                Console.WriteLine("El numero B es el mayor");
            }
            
        }
    }
}
