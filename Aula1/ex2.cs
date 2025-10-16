namespace AulasCsharp.Aula1;

public class Ex2
{
    public static void Executar()
    {
        Console.WriteLine("PROGRAMA DAS BOAS VINDAS");
        Console.WriteLine("Qual o seu nome?");
        string nome = Console.ReadLine();
        Console.WriteLine("Qual a sua idade?");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Seja bem vindo(a) " + nome + ", que tem " + idade + " anos!");
    }
}
