namespace BoasVindas;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROGRAMA DAS BOAS VINDAS");
        Console.WriteLine("Qual o seu nome?");
        string nome = Console.ReadLine();
        Console.WriteLine("Qual a sua idade?");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Seja bem vindo(a) " + nome + ", que tem " + idade + " anos!");
    }
}
