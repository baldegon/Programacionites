using System;

namespace Ej_4
{
    class Program
    {
        static void Main(string[] args)
        {
           int a;
           int b;

           Console.WriteLine("Ingrese el primer numero a sumar: ");
           a = int.Parse(Console.ReadLine());

           Console.WriteLine("Ingrese el otro numero a sumar: ");
           b = int.Parse(Console.ReadLine());
        
            int resultado = a + b;
            Console.WriteLine("La suma de los numeros es: " + resultado);
           
           

        
        }
    }
}
