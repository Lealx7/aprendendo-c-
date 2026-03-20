using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Operações: \n1- Soma \n2- Substração  \n3- Multiplicação \n4- Divisão \n");
        Console.Write("Digite a Operação: ");
        int opcao = int.Parse(Console.ReadLine());

        Console.Write("Digite o Primeiro Numero: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Digite o Primeiro Numero: ");
        double b = double.Parse(Console.ReadLine());
        
        double resultado = 0;

        switch (opcao)
        {
            case 1:
                resultado = Calculadora.Somar(a, b);
                break;
            case 2:
                resultado = Calculadora.Subtrair(a, b);
                break;
            
            case 3:
                resultado = Calculadora.Multiplicar(a,b);
                break;

            case 4:
                resultado = Calculadora.Dividir(a, b);
                break;
        }
        Console.WriteLine($"Resultado: {resultado}");
    }
}