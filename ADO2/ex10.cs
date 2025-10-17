namespace AulasCsharp.Aula3.ADO2;

public class Ex10
{
    public static void Executar()
    {
        Console.WriteLine("PROGRAMA DO SALÁRIO LÍQUIDO");
        Console.WriteLine("Digite o valor do salário bruto: ");
        decimal salarioBruto = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Digite o valor do desconto do INSS (em %): ");
        decimal descontoINSS = Convert.ToDecimal(Console.ReadLine());

        decimal salarioLiquido = salarioBruto - (salarioBruto * (descontoINSS / 100));
        Console.WriteLine($"O valor do salário líquido é: R$ {salarioLiquido:F2}");
    }
}
