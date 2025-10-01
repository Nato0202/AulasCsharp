namespace Metade;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROGRAMA DA METADE");
        Console.WriteLine("Digite um número:");
        double numero = Convert.ToDouble(Console.ReadLine());

        double metade = numero / 2;

        Console.WriteLine("A metade de " + numero + " é " + metade);
    }
}
