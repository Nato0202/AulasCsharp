namespace AulasCsharp.Aula3.ADO3;

public class Ex7
{
    public static void Executar()
    {
        Console.WriteLine("PROGRAMA DO IMC");
        Console.WriteLine("Qual a sua altura?");       double altura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Qual o seu peso?");
        double peso = Convert.ToDouble(Console.ReadLine());

        double imc = peso / (altura * altura);
        Console.WriteLine("Seu IMC é " + imc);

        if (imc < 18.5)
        {
            Console.WriteLine("");
        }
        else if (imc >= 18.5 && imc < 25)
        {
            Console.WriteLine("");
        }
        else if (imc >= 25 && imc < 30)
        {
            Console.WriteLine("");
        }
        else if (imc >= 30 && imc < 35)
        {
            Console.WriteLine("");
        }
        else if (imc >= 40)
        {
            Console.WriteLine("");
        }
    }
}