using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Escriba un número entero: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"F{num} = ");
    }
}