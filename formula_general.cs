using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Fórmula_general
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Solución de ecuaciones cuadráticas usando la fórmula general");

            Console.Write("Ingrese el valor de a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el valor de b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el valor de c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminante = (b * b) - (4 * a * c);

            if (discriminante > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine($"Las soluciones son: x1 = {x1}, x2 = {x2}");
            }
            else if (discriminante == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"La ecuación tiene una única solución: x = {x}");
            }
            else
            {
                Console.WriteLine("La ecuación no tiene soluciones reales (las raíces son complejas).");
            }

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}