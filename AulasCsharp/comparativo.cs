using System;

class Exemplos
{
    static void ExecutarExemplos(string[] args)
    {
        // Exemplo básico: variáveis e tipos de dados
        int idade = 25; // Similar a let idade = 25
        double altura = 1.75; // Similar a let altura = 1.75
        string nome = "João"; // Similar a let nome = "João" em Node.js
        char nota = 'A'; // Similar a let letra = 'A'
        bool ativo = true; // Similar a let ativo = true

        Console.WriteLine($"Nome: {nome}, Idade: {idade}, Ativo: {ativo}");

        // Controle de fluxo: if
        if (idade >= 18)
        {
            Console.WriteLine("Maior de idade");
        }
        else
        {
            Console.WriteLine("Menor de idade");
        }

        // Loop: for
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Contador: {i}");
        }

        // Função
        int resultado = Somar(10, 20);
        Console.WriteLine($"Soma: {resultado}");

        // Classe e objeto
        Pessoa pessoa = new Pessoa("Maria", 30);
        pessoa.Apresentar();
    }

    // Método estático
    static int Somar(int a, int b)
    {
        return a + b;
    }
}

// Classe
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, eu sou {Nome} e tenho {Idade} anos.");
    }
}