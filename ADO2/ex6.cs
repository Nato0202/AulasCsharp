namespace AulasCsharp.Aula3.ADO2;

public class Ex6
{
    public static void Executar()
    {
        Console.WriteLine("PROGRAMA DAS PARADAS DE ABASTECIMENTO");

        Console.WriteLine("Digite a distância total da viagem em km: ");
        double distanciaTotal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o consumo médio do veículo em km/l: ");
        double consumoMedio = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o preço do combustível por litro em reais: ");
        double precoCombustivel = Convert.ToDouble(Console.ReadLine());

        double litrosNecessarios = distanciaTotal / consumoMedio;
        double custoTotal = litrosNecessarios * precoCombustivel;

        Console.WriteLine($"O custo total da viagem é: R$ {custoTotal:F2}");
    }
}
