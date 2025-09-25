using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Ejercicio 9: Fraction Difference ===");

        Console.Write("Ingrese la primera fracción (ejemplo 1/2): ");
        string frac1 = Console.ReadLine();

        Console.Write("Ingrese la segunda fracción (ejemplo 1/3): ");
        string frac2 = Console.ReadLine();

        if (TryParseFraction(frac1, out int num1, out int den1) &&
            TryParseFraction(frac2, out int num2, out int den2))
        {
            if (den1 == 0 || den2 == 0)
            {
                Console.WriteLine("Error: El denominador no puede ser cero.");
                return;
            }

            // Diferencia: (a/b - c/d) = (ad - bc) / bd
            int numerador = (num1 * den2) - (num2 * den1);
            int denominador = den1 * den2;

            // Simplificar fracción
            int mcd = MCD(Math.Abs(numerador), Math.Abs(denominador));
            numerador /= mcd;
            denominador /= mcd;

            if (numerador == 0)
                Console.WriteLine("Resultado: 0");
            else
                Console.WriteLine($"Resultado: {numerador}/{denominador}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Use el formato n/d.");
        }
    }

    static bool TryParseFraction(string input, out int numerador, out int denominador)
    {
        numerador = 0;
        denominador = 0;

        string[] partes = input.Split('/');
        if (partes.Length != 2) return false;

        return int.TryParse(partes[0], out numerador) && int.TryParse(partes[1], out denominador);
    }

    static int MCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
