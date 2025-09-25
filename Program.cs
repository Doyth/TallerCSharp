using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Ejercicio 5: Midweek Day ===");
        Console.Write("Ingrese un número (1-7): ");

        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int dia))
        {
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Número fuera del rango laboral.");
                    break;
                default:
                    Console.WriteLine("Número inválido. Debe estar entre 1 y 7.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número entero.");
        }
    }
}

