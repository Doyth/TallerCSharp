using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Ejercicio 6: Tax Calculator ===");
        Console.Write("Ingrese su salario anual: ");

        string entrada = Console.ReadLine();

        if (double.TryParse(entrada, out double salario) && salario >= 0)
        {
            if (salario > 12000)
            {
                double excedente = salario - 12000;
                double impuesto = excedente * 0.15;
                Console.WriteLine($"Debe pagar un impuesto de: {impuesto:F2}");
            }
            else
            {
                Console.WriteLine("No debe impuestos.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
        }
    }
}
