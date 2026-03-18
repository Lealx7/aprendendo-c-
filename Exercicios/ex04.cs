//Criar método
    //Crie um método:
        //static void Saudacao()
        //Que mostre:
            //Bem-vindo!
            //Depois chame no Main

using System;

class Program
{
    static void Main()
    {
        Saudacao.Mensagem();
    }

    class Saudacao
{
    public static void Mensagem()
    {
        Console.WriteLine("Bem-Vindo!");
    }
}
}

