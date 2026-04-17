using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese primer numero: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese segundo numero: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.Write("1=Suma, 2=Resta, 3=Multiplicacion, 4=Division: ");
        int op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1: Console.WriteLine("Resultado: " + (n1 + n2)); break;
            case 2: Console.WriteLine("Resultado: " + (n1 - n2)); break;
            case 3: Console.WriteLine("Resultado: " + (n1 * n2)); break;
            case 4:
                if (n2 != 0)
                    Console.WriteLine("Resultado: " + (n1 / n2));
                else
                    Console.WriteLine("No se puede dividir entre cero");
                break;
            default: Console.WriteLine("Opcion invalida"); break;
        }
    }
}
