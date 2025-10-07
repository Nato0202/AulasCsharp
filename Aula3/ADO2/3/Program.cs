namespace _3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROGRAMA DE CONVERSÃO DE KILOS PARA GRAMAS");
        console.WriteLine("Digite o valor em quilos: ");
        double valorKilos = Convert.ToDouble(Console.ReadLine());
        double valorGramas = valorKilos * 1000;

        console.WriteLine($"O valor em gramas é: {valorGramas} g");
    }
}
