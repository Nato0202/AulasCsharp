namespace AulasCsharp.Aula3.ADO3;

public class Ex2
{
    public static void Executar()
    {
        Console.WriteLine("PROGRAMA DE VERIFICAÇÃO SE O ALUNO PASSOU");

        Console.WriteLine("Digite a primeira nota do aluno: ");
        decimal nota1 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota do aluno: ");
        decimal nota2 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota do aluno: ");
        decimal nota3 = Convert.ToDecimal(Console.ReadLine());

        decimal media = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine($"A média do aluno é: {media:F2}");

        if (media >= 5)
        {
            Console.WriteLine("O aluno passou!");
        }
        else
        {
            Console.WriteLine("O aluno não passou.");
        }
    }
}
