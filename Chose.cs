namespace AulasCsharp;

public class Choice
{
    public static int Choose()
    {
        int choice1;
        do
        {
            Console.WriteLine("ESCOLHA UMA DAS SEÇÕES DE ATIVIDADE");
            Console.WriteLine("1. ADO1");
            Console.WriteLine("2. ADO2");
            Console.WriteLine("3. ADO3");
            Console.WriteLine("4. ADOVETOR");
            Console.WriteLine("11. Sair");
            choice1 = Convert.ToInt32(Console.ReadLine());
        } while (choice1 != 11 && (choice1 < 1 || choice1 > 4));
        return choice1;
    }

    public static int ChoiceADO1()
    {
        int choice2;
        do
        {
            Console.WriteLine("ESCOLHA UMA DAS ATIVIDADES");
            Console.WriteLine("1. Exercicio 1");
            Console.WriteLine("2. Exercicio 2");
            Console.WriteLine("3. Exercicio 3");
            Console.WriteLine("4. Exercicio 4");
            Console.WriteLine("5. Exercicio 5");
            Console.WriteLine("11. Voltar");
            choice2 = Convert.ToInt32(Console.ReadLine());
        } while (choice2 != 11 && (choice2 < 1 || choice2 > 5));
        return choice2;
    }

    public static int ChoiceADO2()
    {
        int choice2;
        do
        {
            Console.WriteLine("ESCOLHA UMA DAS ATIVIDADES");
            Console.WriteLine("1. Exercicio 1");
            Console.WriteLine("2. Exercicio 2");
            Console.WriteLine("3. Exercicio 3");
            Console.WriteLine("4. Exercicio 4");
            Console.WriteLine("5. Exercicio 5");
            Console.WriteLine("6. Exercicio 6");
            Console.WriteLine("7. Exercicio 7");
            Console.WriteLine("8. Exercicio 8");
            Console.WriteLine("9. Exercicio 9");
            Console.WriteLine("10. Exercicio 10");
            Console.WriteLine("11. Voltar");
            choice2 = Convert.ToInt32(Console.ReadLine());
        } while (choice2 != 11 && (choice2 < 1 || choice2 > 10));
        return choice2;
    }

    public static int ChoiceADO3()
    {
        int choice2;
        do
        {
            Console.WriteLine("ESCOLHA UMA DAS ATIVIDADES");
            Console.WriteLine("1. Exercicio 1");
            Console.WriteLine("2. Exercicio 2");
            Console.WriteLine("3. Exercicio 3");
            Console.WriteLine("4. Exercicio 4");
            Console.WriteLine("5. Exercicio 5");
            Console.WriteLine("6. Exercicio 6");
            Console.WriteLine("7. Exercicio 7");
            Console.WriteLine("8. Exercicio 8");
            Console.WriteLine("9. Exercicio 9");
            Console.WriteLine("10. Exercicio 10");
            Console.WriteLine("11. Voltar");
            choice2 = Convert.ToInt32(Console.ReadLine());
        } while (choice2 != 11 && (choice2 < 1 || choice2 > 10));
        return choice2;
    }

    public static int ChoiceADOVETOR()
    {
        int choice2;
        do
        {
            Console.WriteLine("ESCOLHA UMA DAS ATIVIDADES");
            Console.WriteLine("1. Exercicio 1");
            Console.WriteLine("11. Voltar");
            choice2 = Convert.ToInt32(Console.ReadLine());
        } while (choice2 != 11 && (choice2 < 1 || choice2 > 1));
        return choice2;
    }
}
