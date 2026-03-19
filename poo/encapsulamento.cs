using System;

class Program
{
    static void Main()
    {
        Pessoa p = new Pessoa(); 
        // Cria um objeto da classe Pessoa (instanciação)
        // Sem isso, você não consegue acessar os métodos da classe

        Console.Write("Informe o Seu Nome: "); 
        // Exibe mensagem sem quebrar linha (Write não pula linha)

        string name  = Console.ReadLine(); 
        // Lê o que o usuário digitou no console
        // IMPORTANTE: sempre retorna string (pode vir null, então cuidado em casos reais)

        p.SetNome(name); 
        // Usa o método público para definir o nome
        // Isso respeita o encapsulamento (não acessa diretamente o atributo)

        Console.WriteLine($"Olá, {p.GetNome()}"); 
        // Exibe o nome usando interpolação de string
        // Usa GetNome() para acessar o valor de forma segura
    }
}

class Pessoa
{
    // public string Nome { get; set; }
    
    private string nome; 
    // Campo privado → NÃO pode ser acessado diretamente fora da classe
    // Isso é encapsulamento (protege os dados)

    public void SetNome(string n)
    {
        nome = n; 
        // Define o valor do atributo
        // Poderia ter validações aqui (ex: impedir nome vazio)
    }

    public string GetNome()
    {
        return nome; 
        // Retorna o valor do atributo
        // Forma controlada de acessar o dado
    }
}