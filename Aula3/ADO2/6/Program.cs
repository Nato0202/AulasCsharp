namespace _6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROGRAMA DAS PARADAS DE ABASTECIMENTO");

        console.WriteLine("Digite a distância total da viagem em km: ");
        double distanciaTotal = Convert.ToDouble(Console.ReadLine());

        console.WriteLine("Digite o consumo médio do veículo em km/l: ");
        double consumoMedio = Convert.ToDouble(Console.ReadLine());

        console.WriteLine("Digite o preço do combustível por litro em reais: ");
        double precoCombustivel = Convert.ToDouble(Console.ReadLine());

        double litrosNecessarios = distanciaTotal / consumoMedio;
        double custoTotal = litrosNecessarios * precoCombustivel;

        console.WriteLine($"O custo total da viagem é: R$ {custoTotal}");
    }
}
