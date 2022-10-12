using System;

namespace alumnos
{
    class Program
    {   
        
        static void Main(string[] args)
        {  
            string opcion="";

            Console.WriteLine("Aqui puede hacer varias operaciones");
            Console.WriteLine("Ingrese una opcion a realizar ↓ : ");
            Console.ReadKey();
            Console.Clear();
          
            while(opcion != "q"){

           
                Console.WriteLine("Opciones:");
                Console.WriteLine("1-Sumar:");
                Console.WriteLine("2-Restar:");
                Console.WriteLine("3-Multiplicar:");
                Console.WriteLine("4-Dividir:");
                Console.WriteLine("0-salir:");
            
            opcion=Console.ReadLine();  
           
            switch (opcion) {
                    case "1":
                    
                    sum();
                    break;
                    default:
                    Console.WriteLine("Ingrese una opcion valida");
                    Console.ReadKey();
                    break;

                    case "2":
                    resta();
                    break;

                    case "3":
                    multi();
                    break;

                    case "4":
                    div();
                    break;
                    }
            }
        }

        
        
        static void sum()
        {
            int num1=0;
            int num2=0;
            Console.WriteLine("Ingreso sumar");
            Console.WriteLine("Ingrese los numeros: ");
            num1=Int32.Parse(Console.ReadLine());
            num2=Int32.Parse(Console.ReadLine());
            int suma=0;
            suma = num1 + num2;
            Console.WriteLine("La suma de los dos numeros es de: " + suma);
            Console.WriteLine("Para hacer otra operacion o finalizar aprete enter");
            Console.ReadKey();
            
        }

        static void resta()
        {
            int num1=0;
            int num2=0;
            Console.WriteLine("Ingreso restar");
            Console.WriteLine("Ingrese los numeros: ");
            num1=Int32.Parse(Console.ReadLine());
            num2=Int32.Parse(Console.ReadLine());
            int resta=0;
            resta = num1 - num2;
            Console.WriteLine("La suma de los dos numeros es de: " + resta);
            Console.WriteLine("Para hacer otra operacion o finalizar aprete enter");
            Console.ReadKey();
            
        }

        static void multi()
        {
            int num1=0;
            int num2=0;
            Console.WriteLine("Ingreso Multiplicar");
            Console.WriteLine("Ingrese los numeros: ");
            num1=Int32.Parse(Console.ReadLine());
            num2=Int32.Parse(Console.ReadLine());
            int multi=0;
            multi = num1 * num2;
            Console.WriteLine("La suma de los dos numeros es de: " + multi);
            Console.WriteLine("Para hacer otra operacion o finalizar aprete enter");
            Console.ReadKey();
            
            
        }

        static void div()
        {
            int num1=0;
            int num2=0;
            Console.WriteLine("Ingreso Dividir");
            Console.WriteLine("Ingrese los numeros: ");
            num1=Int32.Parse(Console.ReadLine());
            num2=Int32.Parse(Console.ReadLine());
            float div=0f;
            div = num1 / num2;
            Console.WriteLine("La suma de los dos numeros es de: " + div);
            Console.WriteLine("Para hacer otra operacion o finalizar aprete enter");
            Console.ReadKey();
            
        }
    }
}  