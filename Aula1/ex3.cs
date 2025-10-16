namespace AulasCsharp.Aula1;

public class Ex3
{
    public static void Executar()
    {
        Console.WriteLine("PROGRAMA DO DOBRO");
        Console.WriteLine("Digite um número:");
        double numero = Convert.ToDouble(Console.ReadLine());

        double dobro = numero * 2;

        Console.WriteLine("O dobro de " + numero + " é " + dobro);
    }
}
