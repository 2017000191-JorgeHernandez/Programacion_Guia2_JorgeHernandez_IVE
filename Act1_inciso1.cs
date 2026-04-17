using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un numero del 1 al 7: ");
        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1: Console.WriteLine("Lunes"); break;
            case 2: Console.WriteLine("Martes"); break;
            case 3: Console.WriteLine("Miercoles"); break;
            case 4: Console.WriteLine("Jueves"); break;
            case 5: Console.WriteLine("Viernes"); break;
            case 6: Console.WriteLine("Sabado"); break;
            case 7: Console.WriteLine("Domingo"); break;
            default: Console.WriteLine("Numero invalido"); break;
        }
    }
}
