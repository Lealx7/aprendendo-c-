using System;
using System.Collections.Specialized;

// Classe base (pai)
class Pessoa
{
    public string Nome { get; set; }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, {Nome}");
    }
}

// Classe derivada (filha) que herda de Pessoa
class Estudante : Pessoa
{
    public string Curso { get; set; }

    // Método específico da classe Estudante
    public void MostrarCurso()
    {
        Console.WriteLine($"Estou estudando {Curso}");
    }
}

class Program
{
    static void Main()
    {
        // Cria um objeto da classe derivada
        Estudante e = new Estudante();

        // Podemos usar atributos e métodos da classe base
        
        Console.Write("QUal O Seu Nome: ");
        string name = Console.ReadLine();
        
        e.Nome = name;
        e.Apresentar();

        // Podemos usar atributos e métodos da própria classe

        Console.Write("Informe Sua Faculdade: ");
        string curso = Console.ReadLine();

        e.Curso = curso;
        e.MostrarCurso();
    }
}