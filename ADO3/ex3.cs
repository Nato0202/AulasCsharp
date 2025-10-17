namespace AulasCsharp.Aula3.ADO3;

public class Ex3
{
    public static void Executar()
    {
        Console.WriteLine("PROGRAMA DE VERIFICAÇÃO SE DOIS RETANGULOS SÃO IGUAIS");

        Console.WriteLine("Digite a largura do primeiro retângulo: ");
        double largura1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a altura do primeiro retângulo: ");
        double altura1 = Convert.ToDouble(Console.ReadLine());
        double area1 = largura1 * altura1;

        Console.WriteLine("Digite a largura do segundo retângulo: ");
        double largura2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a altura do segundo retângulo: ");
        double altura2 = Convert.ToDouble(Console.ReadLine());
        double area2 = largura2 * altura2;

        if (area1 == area2)
        {
            Console.WriteLine("Os retângulos são iguais.");
        }
        else
        {
            Console.WriteLine("Os retângulos não são iguais.");
        }
    }
}
