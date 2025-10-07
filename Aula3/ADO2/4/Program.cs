namespace _4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROGRAMA DE CONVERSÃO DE REAIS EM DOLARES");
        console.WriteLine("Digite o valor em reais: ");
        decimal valorReais = Convert.ToDecimal(Console.ReadLine());
        decimal valorDolares = valorReais / 5.16;

        console.WriteLine($"O valor em dolares é: $ {valorDolares}");
    }
}
