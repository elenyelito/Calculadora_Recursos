using System;
using System.Security.AccessControl;
class Program
{
    static void Main(string[] args)
    {
    /*  Console.WriteLine("==== CALCULADORA DE RECURSOS ====");

        Console.Write("Digite la cantidad de trabajadores: ");
        int trabajadores = int.Parse(Console.ReadLine()!);
        Console.Write("Digite las horas trabajadas: ");
        int horas = int.Parse(Console.ReadLine()!);
        Console.Write("Digite el consumo por hora: ");
        double consumoHora = double.Parse(Console.ReadLine()!);

        double consumoTotal = trabajadores * horas * consumoHora;

        Console.WriteLine("\n==== REPORTE ====");
        Console.WriteLine($"Trabajadores: {trabajadores}");
        Console.WriteLine($"Horas trabajadas: {horas}");
        Console.WriteLine($"Consumo por hora: {consumoHora}");
        Console.WriteLine($"Consumo Total:  {consumoTotal}");
    */

        Console.WriteLine("==== NIVEL DE ACCESO ====");

        Console.Write("Digite la edad del operador: ");
        int edad = int.Parse(Console.ReadLine()!);

        if (edad >= 18)
        {
            Console.WriteLine("Acceso permitido");
        }
        else
        {
            Console.WriteLine("Acceso restringido");
        }
    }
}