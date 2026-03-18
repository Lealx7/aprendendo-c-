//Crie um programa que:
    //Permita um nome opcional
    //Se for null, exiba: "Nome não informado"

using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe o seu Nome: ");
        string nome = Console.ReadLine();

        if(string.IsNullOrEmpty(nome))
        {
            Console.WriteLine("Nome Não informado!");
        }

        else
        {
            Console.WriteLine($"Olá {nome}");
        }
    }
}