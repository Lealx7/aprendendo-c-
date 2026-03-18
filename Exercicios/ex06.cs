// Método com retorno
    // static int Somar(int a, b)...

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite Um Numero: ");
        int a = int.Parse(Console.ReadLine());
        
        Console.Write("Digite Outro Numero: ");
        int b = int.Parse(Console.ReadLine());

        int resultado = Soma(a, b);
        Console.WriteLine(resultado);
    }

    public static int Soma(int a, int b)
    {  
       return a + b; 
    }
}