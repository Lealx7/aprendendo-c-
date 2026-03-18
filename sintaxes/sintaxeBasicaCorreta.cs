// Sintaxe.cs como exemplo de sintaxe básica em C#

// Importa funcionalidades básicas do C#

using System;

class Program
{
    // Método principal (ponto de entrada do programa)
    static void Main()
    {
        // Exemplo básico de saída no console
        Console.WriteLine("Hello Word");
    
        // Chamando Segundo Metodo
        Pessoa.User();
    }

}

class Pessoa
{
    public static void User()
    {
        int idade = 20;
        var nome = "LealDevloper";
        
        Console.WriteLine($"Seja Bem-Vindo {nome}!");
        Console.WriteLine($"Idade: {idade}");
    }
}