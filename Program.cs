using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Ejercicio 4: Circle Perimeter ===");
        Console.Write("Ingrese el radio del círculo: ");

        string entrada = Console.ReadLine();

        if (double.TryParse(entrada, out double radio) && radio >= 0)
        {
            double perimetro = 2 * Math.PI * radio;
            Console.WriteLine($"Resultado: {perimetro:F2}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número positivo.");
        }
    }
}
