// Maior de idade
    // if (idade >= 18)
    // Mostre:
    //"Maior de idade"
    // "Menor de idade"


using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite Sua Idade: ");

        // O método Parse converte uma string em outro tipo, como int, double
        int idade = int.parse(Console.ReadLine());
        
        if(idade >= 18)
        {
            Console.WriteLine("Maior de Idade");
        }
        else
        {
            Console.WriteLine("Menor de Idade");
        }
    }
}