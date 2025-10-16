namespace AulasCsharp.Aula1;

public class Ex1
{
    public static void Executar()
    {
        Console.WriteLine("PROGRAMA DO AÇAÍ");
        Console.WriteLine("Quantos açaís pequenos, médios e grandes você quer?");
        Console.WriteLine("Pequenos:");
        int pequeno = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Médios:");
        int medio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Grandes:");
        int grande = Convert.ToInt32(Console.ReadLine());

        double total = (pequeno * 13.00) + (medio * 15.00) + (grande * 17.50);
        Console.WriteLine("O total do seu pedido é: R$ " + total);
    }
}
