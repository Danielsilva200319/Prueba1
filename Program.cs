using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("       Fibonnaci".ToUpper());
        Console.WriteLine("-----------------------------");
        Console.WriteLine("1. Número a Fibonnaci");
        Console.WriteLine("2. Confirmación Fibonnaci");
        Console.WriteLine("3. Números Fibonnaci");
        Console.WriteLine("0. Salir");
        Console.WriteLine("-----------------------------");
        Console.Write("Ingrese una opción: ");
        var opcion = Convert.ToInt32(Console.ReadLine());
        bool isActivate = true;
        while (isActivate)
        {
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    NumeroAFibonnaci();
                    break;
                case 2:
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("Gracias por utilizar el programa");
                    isActivate = false;
                    break;
                default:
                    break;
            }
        }
    }
    public static void NumeroAFibonnaci()
    {
        Console.Write("Escriba un número entero: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hola Mundo");
        Console.WriteLine($"F{num} = ");
    }
}