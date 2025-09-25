using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Ejercicio 10: String Length ===");
        Console.Write("Ingrese una palabra: ");

        string palabra = Console.ReadLine();

        if (!string.IsNullOrEmpty(palabra))
        {
            Console.WriteLine($"La longitud de \"{palabra}\" es: {palabra.Length}");
        }
        else
        {
            Console.WriteLine("No ingresó ninguna palabra.");
        }
    }
}

