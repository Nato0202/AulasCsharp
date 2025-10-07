namespace _7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROGRAMA DE VENDA DE AÇAÍ");

        console.WriteLine("Digite a quantidade de açaí: ");
        int quantidadeAcai = Convert.ToInt32(Console.ReadLine());

        decimal precoUnitario = 13.50m;
        decimal valorTotal = quantidadeAcai * precoUnitario;

        Console.WriteLine($"O valor total da compra de açaí é: R$ {valorTotal}");   
    }
}
