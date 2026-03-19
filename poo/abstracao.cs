using System;

// Classe abstrata
abstract class Forma
{
    public abstract double CalcularArea();
}

// Classe Quadrado
class Quadrado : Forma
{
    public double Lado;

    public override double CalcularArea()
    {
        return Lado * Lado;
    }
}

// Classe Círculo
class Circulo : Forma
{
    public double Raio;

    public override double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }
}

class Program
{
    static void Main()
    {
        // Polimorfismo: array de Formas
        Forma[] formas = new Forma[2];

        Quadrado q = new Quadrado() { Lado = 4 };
        Circulo c = new Circulo() { Raio = 3 };

        formas[0] = q;
        formas[1] = c;

        foreach (var f in formas)
        {
            Console.WriteLine($"Área: {f.CalcularArea():F2}");
        }
    }
}