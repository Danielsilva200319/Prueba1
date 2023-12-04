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
                    Console.ReadLine();
                    break;
                case 2:
                    Confirmacion();
                    break;
                case 3:
                    Numeros();
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("Gracias por utilizar el programa");
                    isActivate = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Error ingrese un valor válido");
                    Console.ReadLine();
                    break;
            }
        }
    }
    /* 1. Escriba un programa que reciba como entrada un número entero n, y entregue como salida el n-
ésimo número de Fibonacci: */
    public static void NumeroAFibonnaci()
    {

        Console.Write("\nEscriba un número entero: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num <= 0)
        {
            Console.WriteLine("Ingrese un valor positivo");
        }
        else if (num == 1 || num == 2)
        {
            Console.WriteLine(1);
        }
        else
        {
            int a = 0, b = 1, result = a + b;
            result = a;
            a = b;
            b = result + b;
            Console.WriteLine($"F{num} = {b}");
        }
    }
    /* 2. Escriba un programa que reciba como entrada un número entero e indique si es o no un número
de Fibonacci: */
    public static void Confirmacion()
    {
        Console.Write("\nEscriba un número entero: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number <= 0)
        {
            Console.WriteLine("Ingrese un valor positivo");
            Console.WriteLine($"{number} no es un número Fibannoci");
        }
        else
        {
            Console.WriteLine($"{number} es un número Fibannoci");
        }
        return;
    }
    /* 3. Escriba un programa que muestres los m primeros números de Fibonacci, donde m es un número
ingresado por el usuario: */
    public static void Numeros()
    {
        
    }
}