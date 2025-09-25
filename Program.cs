using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Ejercicio 3: Root or Square ===");
        Console.Write("Ingrese un número: ");

        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int num))
        {
            if (num > 0)
            {
                double raiz = Math.Sqrt(num);
                Console.WriteLine($"Resultado: {raiz}");
            }
            else if (num == 0)
            {
                Console.WriteLine("Resultado: 0");
            }
            else
            {
                int cuadrado = num * num;
                Console.WriteLine($"Resultado: {cuadrado}");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número entero.");
        }
    }
}
