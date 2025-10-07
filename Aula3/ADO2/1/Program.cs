namespace _1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROGRAMA DO CUPOM EM REAIS");
        console.WriteLine("Digite o valor total da compra em reais: ");
        decimal valorTotal = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite o valor do cupom em reais: ");
        decimal valorCupom = Convert.ToDecimal(Console.ReadLine());

        decimal valorFinal = valorTotal - valorCupom;
        Console.WriteLine($"O valor final da compra, após aplicar o cupom, é: R$ {valorFinal:F2}");
    }
}
