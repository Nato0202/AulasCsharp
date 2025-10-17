namespace AulasCsharp.Aula3.ADO2;

public class Ex2
{
    public static void Executar()
    {
        Console.WriteLine("PROGRAMA DO CUPOM EM PORCENTAGEM");
        Console.WriteLine("Digite o valor total da compra em reais: ");
        decimal valorTotal = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite o valor do cupom em porcentagem: ");
        decimal valorCupom = Convert.ToDecimal(Console.ReadLine());

        decimal valorFinal = valorTotal - (valorTotal * (valorCupom / 100));

        Console.WriteLine("O valor final da compra, após aplicar o cupom, é: " + valorFinal);
    }
}
