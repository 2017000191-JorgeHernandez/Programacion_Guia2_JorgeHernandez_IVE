using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("1 Metros");
        Console.WriteLine("2 Pies");
        Console.WriteLine("3 Centimetros");
        Console.WriteLine("4 Pulgadas");

        int opcion = int.Parse(Console.ReadLine());

        Console.Write("Ingrese valor: ");
        double valor = double.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("En pies: " + (valor * 3.281));
                break;
            case 2:
                Console.WriteLine("En metros: " + (valor / 3.281));
                break;
            case 3:
                Console.WriteLine("En pulgadas: " + (valor / 2.54));
                break;
            case 4:
                Console.WriteLine("En centimetros: " + (valor * 2.54));
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}
