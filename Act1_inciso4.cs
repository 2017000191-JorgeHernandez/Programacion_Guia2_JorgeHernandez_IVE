using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1 Hamburguesa");
        Console.WriteLine("2 Pizza");
        Console.WriteLine("3 Pollo frito");
        Console.WriteLine("4 Ensalada");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1: Console.WriteLine("Pidio Hamburguesa"); break;
            case 2: Console.WriteLine("Pidio Pizza"); break;
            case 3: Console.WriteLine("Pidio Pollo frito"); break;
            case 4: Console.WriteLine("Pidio Ensalada"); break;
            default: Console.WriteLine("Opcion invalida"); break;
        }
    }
}
