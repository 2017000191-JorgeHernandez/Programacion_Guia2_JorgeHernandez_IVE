using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese angulo en grados: ");
        double angulo = double.Parse(Console.ReadLine());

        double rad = angulo * Math.PI / 180;

        Console.WriteLine("1=Seno, 2=Coseno, 3=Tangente");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1: Console.WriteLine("Seno: " + Math.Sin(rad)); break;
            case 2: Console.WriteLine("Coseno: " + Math.Cos(rad)); break;
            case 3: Console.WriteLine("Tangente: " + Math.Tan(rad)); break;
            default: Console.WriteLine("Opcion invalida"); break;
        }
    }
}
