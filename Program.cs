using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Ejercicio 7: Remainder Finder ===");

        Console.Write("Ingrese el primer número: ");
        string entrada1 = Console.ReadLine();

        Console.Write("Ingrese el segundo número: ");
        string entrada2 = Console.ReadLine();

        if (int.TryParse(entrada1, out int a) && int.TryParse(entrada2, out int b))
        {
            if (b == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
            }
            else
            {
                int residuo = a % b;
                Console.WriteLine($"El residuo de {a} % {b} es: {residuo}");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Debe ingresar números enteros.");
        }
    }
}
