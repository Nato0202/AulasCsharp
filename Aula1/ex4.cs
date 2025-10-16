namespace AulasCsharp.Aula1;

public class Ex4
{
    public static void Executar()
    {
        Console.WriteLine("PROGRAMA DA MÉDIA");

        Console.WriteLine("Digite a primeiro Numero:");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a segundo Numero:");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a terceiro Numero:");
        double n3 = Convert.ToDouble(Console.ReadLine());

        double media = (n1 + n2 + n3) / 3;

        Console.WriteLine("A média entre " + n1 + ", " + n2 + " e " + n3 + " é " + media);
    }
}
