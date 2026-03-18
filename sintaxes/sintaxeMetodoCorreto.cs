using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Chamando Metodo Correto");
        ChamarPessoa();
    }

    static void ChamarPessoa()
    {
        // Chamando o método Secundary corretamente
        Pessoa.Usuario();
    }
}

class Pessoa
{
    public static void Usuario()
    {
        int idade = 18;
        var nome = "Kauan";

        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
    }
}