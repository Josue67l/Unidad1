using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Multiplicación de dos números");
        Console.Write("Ingresa el primer número:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingresa el segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double resultado = num1 * num2;
        Console.WriteLine($"El resultado de {num1} x {num2} es: {resultado}");
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}

