// Descobrir se o Numero e Par ou Impar

using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe Um Numero: ");
        int numero = int.Parse(Console.ReadLine());

        if(numero %2 == 0)
        {
            Console.WriteLine("Numero Par");
        }

        else
        {
            Console.WriteLine("Numero Impar");
        }
    }
}