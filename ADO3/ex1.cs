namespace AulasCsharp.Aula3.ADO3;

public class Ex1
{
    public static void Executar()
    {
        Console.WriteLine("PROGRAMA DA FEBRE");

        Console.WriteLine("Digite a temperatura em Celsius: ");
        double tempCelsius = Convert.ToDouble(Console.ReadLine());

        if (tempCelsius >= 37.5)
        {
            Console.WriteLine("Você está com febre.");
        }
        else
        {
            Console.WriteLine("Você não está com febre.");
        }
    }
}
