using System;

class Animal
{
    public virtual void FazerSom()
    {
        Console.WriteLine("Som genérico");
    }
}

class Cachorro : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("Latido");
    }
}

class Gato : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("Miau");
    }
}

class Program
{
    static void Main()
    {
        // Polimorfismo: referência do tipo Animal, objeto do tipo Cachorro
        Animal a1 = new Cachorro();
        Animal a2 = new Gato();
        Animal a3 = new Animal();

        // Todos usam o mesmo método "FazerSom", mas se comportam de forma diferente
        a1.FazerSom(); // Saída: Latido
        a2.FazerSom(); // Saída: Miau
        a3.FazerSom(); // Saída: Som genérico

        // Podemos colocar todos em um array e percorrer (polimorfismo em ação)
        Animal[] animais = { a1, a2, a3 };

        Console.WriteLine("\nPercorrendo array de animais:");
        foreach (var animal in animais)
        {
            animal.FazerSom(); // Cada objeto se comporta conforme sua implementação real
        }
    }
}