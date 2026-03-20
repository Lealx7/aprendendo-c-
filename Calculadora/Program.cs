using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Operações: \nSoma(+) \nSubstração (-)  \nMultiplicação (*) \nDivisão (/)\n");

        Console.Write("Digite o Primeiro Numero: ");
        double n1 = double.Parse(Console.ReadLine());
    
        Console.Write("Digite o Segundo Numero: ");
        double n2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a Operação: ");
        string operacao = Console.ReadLine();

        double resultado = 0;
        bool operacaoValida  = true; 
        
        if(operacao == "+")
        {
            resultado = n1 + n2;
        }

        else if(operacao == "-")
        {
            resultado = n1 -n2;
        }

        else if(operacao == "*")
        {
            resultado = n1 * n2;
        }

        else if(operacao == "/")
        {
            if(n2 == 0)
            {
                Console.WriteLine("Erro: Divisão Por zero.");
                operacaoValida = false;
            }

            else
            {
                resultado = n1 / n2;
            }
        }

        else
        {
            Console.WriteLine("Operação Invalida.");    
        }

        if (operacaoValida)
        {
            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}