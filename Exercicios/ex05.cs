//Método com parâmetro
    //static void MostrarNome(string nome)


using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe o Seu Nome: ");
        string nome = Console.ReadLine();

        Name(nome);
    }

    public static void Name(string nome)
    {
        Console.WriteLine("Seu Nome é: " + nome);
    }
}