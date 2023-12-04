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
                    NumeroAFibonnaci();
                    Console.Write("Presione Enter para ir al menu...");
                    Console.ReadKey();
                    break;
                case 2:
                    Confirmacion();
                    Console.Write("Presione Enter para ir al menu...");
                    Console.ReadKey();
                    break;
                case 3:
                    
                    break;
                case 0:
                    Console.WriteLine("Gracias por utilizar el programa");
                    isActivate = false;
                    break;
                default:
                    Console.WriteLine("Error ingrese un valor válido");
                    return;
            }
        }
    }
    public static void NumeroAFibonnaci()
    {

        Console.Write("\nEscriba un número entero: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"F{num} = ");
    }
    public static void Confirmacion()
    {
        Console.Write("\nEscriba un número entero: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number == 2)
        {
            Console.WriteLine($"{number} es un número Fibannoci");
        }
        else
        {
            Console.WriteLine($"{number} no es un número Fibannoci");
        }
    }
    public static void Numeros()
    {
        
    }
}