namespace AulasCsharp.Aula3.ADO2;

public class Ex3
{
    public static void Executar()
    {
        Console.WriteLine("PROGRAMA DE CONVERSÃO DE KILOS PARA GRAMAS");
        Console.WriteLine("Digite o valor em quilos: ");
        double valorKilos = Convert.ToDouble(Console.ReadLine());
        double valorGramas = valorKilos * 1000;

        Console.WriteLine($"O valor em gramas é: {valorGramas} g");
    }
}
