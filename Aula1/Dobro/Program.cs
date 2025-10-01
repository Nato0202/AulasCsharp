namespace Dobro;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROGRAMA DO DOBRO");
        Console.WriteLine("Digite um número:");
        double numero = Convert.ToDouble(Console.ReadLine());
        
        double dobro = numero * 2;

        Console.WriteLine("O dobro de " + numero + " é " + dobro);
    }
}
