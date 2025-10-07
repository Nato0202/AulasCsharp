namespace _4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROGRAMA DE VERIFICAÇÃO DE NÚMERO PAR");

        Console.WriteLine("Digite um número inteiro: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é par.");
        }
        else
        {
            Console.WriteLine("O número é ímpar.");
        }
    }
}
