namespace AulasCsharp.Aula3.ADO2;

public class Ex4
{
    public static void Executar()
    {
        Console.WriteLine("PROGRAMA DE CONVERSÃO DE REAIS EM DOLARES");
        Console.WriteLine("Digite o valor em reais: ");
        decimal valorReais = Convert.ToDecimal(Console.ReadLine());
        decimal valorDolares = valorReais / 5.16m;

        Console.WriteLine($"O valor em dolares é: $ {valorDolares:F2}");
    }
}
