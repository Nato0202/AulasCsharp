namespace _2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROGRAMA DO CUPOM EM PORCENTAGEM");
        console.WriteLine("Digite o valor total da compra em reais: ");
        decimal valorTotal = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite o valor do cupom em porcentagem: ");
        decimal valorCupom = Convert.ToDecimal(Console.ReadLine());

        decimal valorFinal = valorTotal - (valorTotal * (valorCupom / 100));

        Console.WriteLine("O valor final da compra, após aplicar o cupom, é: " + valorFinal);
    }
}
