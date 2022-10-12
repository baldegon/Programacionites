using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;            
            decimal decim;
            string nombre;
            bool a = true;
            bool b = false;
            
            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());
            
            Console.WriteLine("El numero ingresado es: " + numero);

            Console.WriteLine("Ingrese un numero decimal");
            decim = int.Parse(Console.ReadLine());
            
            Console.WriteLine("El numero ingresado es: " + decim);

            Console.WriteLine("Ingrese una palabra: ");
            nombre = Console.ReadLine();
            
            Console.WriteLine("La palabra es " + nombre);

            Console.WriteLine("Esta soleado?: {0} ", a);
            Console.WriteLine("Esta lloviendo?: {0} ", b);
            Console.ReadLine();
        }
    }
}
