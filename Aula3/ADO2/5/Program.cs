namespace _5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROGRAMA DAS PARCELAS");
        console.WriteLine("Digite o valor total da compra em reais: ");
        decimal valorTotal = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite o número de parcelas (1 a 12): ");
        int numeroParcelas = Convert.ToInt32(Console.ReadLine());

        decimal valorParcela = valorTotal / numeroParcelas;
        Console.WriteLine($"O valor de cada parcela é: R$ {valorParcela}");
    }
}
