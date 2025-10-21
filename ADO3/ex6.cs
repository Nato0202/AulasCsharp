namespace AulasCsharp.Aula3.ADO3;

public class Ex6
{
    public static void Executar()
    {
        Console.WriteLine("PROGRAMA DO FARÓL");
        Console.WriteLine("Qual a cor do semáforo");
        string cor = Console.ReadLine();

        if (cor == "verde")
        {
            Console.WriteLine("Pode atravessar? true");
        }
        else if (cor == "vermelho")
        {
            Console.WriteLine("Pode atravessar? false");
        }
    }
}