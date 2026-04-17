using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un caracter: ");
        char c = Console.ReadLine().ToLower()[0];

        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
        {
            Console.WriteLine("Es vocal");
        }
        else if (char.IsDigit(c))
        {
            Console.WriteLine("Es digito");
        }
        else
        {
            Console.WriteLine("Ninguno de los anteriores");
        }
    }
}
