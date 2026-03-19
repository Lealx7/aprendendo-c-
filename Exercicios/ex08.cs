//Crie uma classe:
    //Nome
    //Preço
    //Método para exibir dados

using System;

class Program
{
    static void Main()
    {
        Produto p = new Produto(); // cria um produto vazio

        Console.Write("Informe o Nome do Produto: "); 
        string nome = Console.ReadLine(); 
        p.SetNome(nome); // salva o nome no produto

        Console.Write("Informe o Preço do Produto: ");
        double preco;
        while(!double.TryParse(Console.ReadLine(), out preco))
        {
            Console.Write("Valor inválido. Informe o Preço do Produto: ");
        }
        p.SetPreco(preco); // salva o preço

        p.ExibirDados(); // mostra tudo

    }
}

class Produto
{
    private string nome;   // Vou guarda o nome do produto
    private double preco;  // Vou guarda o preço do produto

    public void SetNome(string n) { nome = n; }   // coloca o nome
    public string GetNome() { return nome; }      // pega o nome

    public void SetPreco(double p) { preco = p; } // coloca o preço
    public double GetPreco() { return preco; }    // pega o preço

    public void ExibirDados()  // mostra todos os dados
    {
        Console.WriteLine($"\nProduto: {nome}");
        Console.WriteLine($"Preço: R$ {preco:F2}");
    }
}