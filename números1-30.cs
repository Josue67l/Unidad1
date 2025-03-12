using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Números1_30
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Números impares del 1 al 30:");

            for (int i = 1; i <= 30; i += 2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
