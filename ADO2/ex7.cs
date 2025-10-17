namespace AulasCsharp.Aula3.ADO2;

public class Ex7
{
    public static void Executar()
    {
        Console.WriteLine("PROGRAMA DE VENDA DE AÇAÍ");

        Console.WriteLine("Digite a quantidade de açaí: ");
        int quantidadeAcai = Convert.ToInt32(Console.ReadLine());

        decimal precoUnitario = 13.50m;
        decimal valorTotal = quantidadeAcai * precoUnitario;

        Console.WriteLine($"O valor total da compra de açaí é: R$ {valorTotal:F2}");
    }
}
