using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci1_50
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Serie de Fibonacci hasta 50:");

            int a = 0, b = 1, siguiente;

            Console.Write(a + " " + b + " ");

            siguiente = a + b;

            while (siguiente <= 50)
            {
                Console.Write(siguiente + " ");
                a = b;
                b = siguiente;
                siguiente = a + b;
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}