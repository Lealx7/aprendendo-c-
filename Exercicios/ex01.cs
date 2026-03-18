// Crie variáveis para:
    // preço (decimal)
    // quantidade (int)
    // nomeProduto (string)

// Calcule o total e exiba.

using System;

class Program
{
    static void Main()
    {   
        // Sempre que for um decimal se deve no final do valor informar o "m"
        decimal preco = 12.9m;
        int quantidade = 3;
        string produto = "Mesa";

        decimal total = preco * quantidade;

        Console.WriteLine($"O Produto {produto} tem o seu custo total de R$ {total}");
    }
}