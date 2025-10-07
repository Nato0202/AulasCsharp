namespace _1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROGRAMA DA FEBRE");

        console.WriteLine("Digite a temperatura em Celsius: ");
        double tempCelsius = Convert.ToDouble(Console.ReadLine());

        if (tempCelsius >= 37.5)
        {
            console.WriteLine("Você está com febre.");
        }
        else
        {
            console.WriteLine("Você não está com febre.");
        }
    }
}
