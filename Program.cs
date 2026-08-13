using System;
using System.Security.AccessControl;
using System.Security.Cryptography;
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


        Console.WriteLine("==== SISTEMA DE AUTORIZACIÓN ====");

        Console.Write("Digite su edad: ");
        int edad = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese el nivel de seguridad: ");
        int nivel = int.Parse(Console.ReadLine()!);

        Console.Write("Crendencial activa (true/false): ");
        bool activo = bool.Parse(Console.ReadLine()!);

        if (edad >= 18 && nivel >= 3 && activo)
        {
            Console.WriteLine("\nAcceso autorizado");
        }
        else
        {
            Console.WriteLine("\nAcceso denegado");
        }
    

        Console.WriteLine("==== CLASIFICADOR DE ALERTAS ====");

        Console.Write("Digite un nivelde alerta (0 a 10): ");
        int nivel = int.Parse(Console.ReadLine()!);

        if (nivel == 0)
        {
            Console.WriteLine("NORMAL");
        }
        else if (nivel >= 1 && nivel <= 3)
        {
            Console.WriteLine("ALERTA BAJA");
        }
        else if (nivel >= 4 && nivel <= 6)
        {
            Console.WriteLine("ALERTA MEDIA");
        }
        else if (nivel >= 7 && nivel <= 9)
        {
            Console.WriteLine("CRÍTICO");
        }
        else if (nivel == 10)
        {
            Console.WriteLine("EMERGENCIA");
        }
        else
        {
            Console.WriteLine("NIVEL DE ALERTA INVÁLIDO");
        }

    */
        Console.WriteLine("==== PANEL DE CONTROL ====");

        Console.WriteLine("1. Consultar estado");
        Console.WriteLine("2. Mostrar temperatura");
        Console.WriteLine("3. Mostrar presión");
        Console.WriteLine("4. Reiniciar sistema");
        Console.WriteLine("5. Salir");
        Console.WriteLine("Opción inválida");

        int opcion = int.Parse(Console.ReadLine()!);

        switch (opcion)
        {
            case 1:
                Console.WriteLine("\nConsultando estado del sistema...");
                break;
            case 2:
                Console.WriteLine("\nTemperatura actual: 24°C");
                break;
            case 3:
                Console.WriteLine("\nPresion actual: 1013 hPa");
                break;
            case 4:
                Console.WriteLine("\nReiniciando sistema...");
                break;
            case 5:
                Console.WriteLine("\nSaliendo del panel...");
                break;
            default:
                Console.WriteLine("\nOpción inválida");
                break;
        }
    }
}