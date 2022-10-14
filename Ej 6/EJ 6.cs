using System;

namespace alumnos
{
    class Program
    {   
        
        static void Main(string[] args)
        {  
            string opcion="";

            
          
            do
            {

           
                Console.WriteLine("Opciones:");
                Console.WriteLine("1-Sumar:");
                Console.WriteLine("2-Restar:");
                Console.WriteLine("3-Multiplicar:");
                Console.WriteLine("4-Dividir:");
                Console.WriteLine("0-salir:");
            
            opcion=Console.ReadLine();  
           
            switch (opcion) {
                    case "1":
                    sum(0,0);
                    break;
                   
                    case "2":
                    resta(0,0);
                    break;

                    case "3":
                    multi(0,0);
                    break;

                    case "4":
                    div(0,0);
                    break;
                    }
            }while(opcion != "0");
        }   

        
        
        static int sum(int num1=0, int num2=0)
        {
            
            Console.WriteLine("Ingreso sumar");
            Console.WriteLine("Ingrese los numeros: ");
            num1=Int32.Parse(Console.ReadLine());
            num2=Int32.Parse(Console.ReadLine());
            int suma=0;
            suma = num1 + num2;
            Console.WriteLine("La suma de los dos numeros es de: " + suma);
            Console.WriteLine("Para hacer otra operacion o finalizar aprete enter");
            Console.ReadKey();
            return suma;
        }

        static double resta(int num1=0, int num2=0)
        {
            
            Console.WriteLine("Ingreso restar");
            Console.WriteLine("Ingrese los numeros: ");
            num1=Int32.Parse(Console.ReadLine());
            num2=Int32.Parse(Console.ReadLine());
            int resta=0;
            resta = num1 - num2;
            Console.WriteLine("La resta de los dos numeros es de: " + resta);
            Console.WriteLine("Para hacer otra operacion o finalizar aprete enter");
            Console.ReadKey();
            return resta;
        }

        static int multi(int num1, int num2)
        {
            
            Console.WriteLine("Ingreso Multiplicar");
            Console.WriteLine("Ingrese los numeros: ");
            num1=Int32.Parse(Console.ReadLine());
            num2=Int32.Parse(Console.ReadLine());
            int multi=0;
            multi = num1 * num2;
            Console.WriteLine("La multiplicacion de los dos numeros es de: " + multi);
            Console.WriteLine("Para hacer otra operacion o finalizar aprete enter");
            Console.ReadKey();
            return multi;
            
        }

        static double div(double num1, double num2)
        {
            Console.WriteLine("Ingreso Dividir");
            Console.WriteLine("Ingrese los numeros: ");
            num1=double.Parse(Console.ReadLine());
            num2=double.Parse(Console.ReadLine());
            double div=0f;
            div = num1 / num2;
            Console.WriteLine("La division de los dos numeros es de: " + div);
            Console.WriteLine("Para hacer otra operacion o finalizar aprete enter");
            Console.ReadKey();
            return div;   
        }
    }
}  