namespace AulasCsharp.Aula3.ADO2;

public class Ex5
{
    public static void Executar()
    {
        Console.WriteLine("PROGRAMA DAS PARCELAS");
        Console.WriteLine("Digite o valor total da compra em reais: ");
        decimal valorTotal = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite o número de parcelas (1 a 12): ");
        int numeroParcelas = Convert.ToInt32(Console.ReadLine());

        decimal valorParcela = valorTotal / numeroParcelas;
        Console.WriteLine($"O valor de cada parcela é: R$ {valorParcela:F2}");
    }
}
