    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Operações: \n1- Soma \n2- Substração  \n3- Multiplicação \n4- Divisão \n");

            Console.Write("Digite o Primeiro Numero: ");
            double n1 = double.Parse(Console.ReadLine());
        
            Console.Write("Digite o Segundo Numero: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a Operação: ");
            int operacao = int.Parse(Console.ReadLine());

            double resultado = 0;
            bool operacaoValida  = true;

            switch (operacao)
            {
                case 1:
                    resultado = n1 + n2;
                    break;

                case 2:
                    resultado = n1 - n2;
                    break;
                case 3:
                    resultado = n1 * n2;
                    break;
                case 4:
                    if(n2 == 0)
                    {
                        Console.WriteLine("Erro: Divisivel por Zero");
                        operacaoValida = false;
                    }
                    else
                    {
                        resultado = n1 / n2;
                    }
                    break;

                default:
                    Console.WriteLine("Operação Invalida!");
                    operacaoValida = false;
                    break;
            }
            if (operacaoValida)
            {
                Console.WriteLine($"Resultado: {resultado}");
            }
        }
    }