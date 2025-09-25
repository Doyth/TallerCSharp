using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 1: Positive Power");

        Console.Write("Ingrese un número: ");
        int num = int.Parse(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine($"Resultado: {num * num}");
        }
        else if (num == 0)
        {
            Console.WriteLine("Resultado: 0");
        }
        else
        {
            Console.WriteLine("Resultado: Número negativo.");
        }
    }
}
