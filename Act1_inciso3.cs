using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una letra: ");
        string letra = Console.ReadLine().ToUpper();

        switch (letra)
        {
            case "A": Console.WriteLine("Excelente"); break;
            case "B": Console.WriteLine("Bueno"); break;
            case "C": Console.WriteLine("Regular"); break;
            case "D": Console.WriteLine("Deficiente"); break;
            case "F": Console.WriteLine("Reprobado"); break;
            default: Console.WriteLine("Letra invalida"); break;
        }
    }
}
