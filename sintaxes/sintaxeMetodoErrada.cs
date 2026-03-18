using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Tentando Chamar Outro Metodo");

        // Erro: Chamando sem parâmetros
        Pessoa.Idade; //  Isso Não Compila
    }
}

class Pessoa
{
    public static void Idade()
    {
        Console.WriteLine("Esse Metodo não E Chamado");
    }
}