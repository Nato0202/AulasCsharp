namespace AulasCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice1;

            do
            {
                Console.Clear();
                Console.WriteLine("------------------");
                Console.WriteLine("MENU DE ATIVIDADES");
                Console.WriteLine("------------------");

                choice1 = Choice.Choose();
                if (choice1 == 11)
                    break;

                int choice2 = 0;
                do
                {
                    if (choice1 == 1)
                    {
                        choice2 = Choice.ChoiceADO1();
                        if (choice2 == 11) break;

                        if (choice2 == 1) AulasCsharp.Aula1.Ex1.Executar();
                        else if (choice2 == 2) AulasCsharp.Aula1.Ex2.Executar();
                        else if (choice2 == 3) AulasCsharp.Aula1.Ex3.Executar();
                        else if (choice2 == 4) AulasCsharp.Aula1.Ex4.Executar();
                        else if (choice2 == 5) AulasCsharp.Aula1.Ex5.Executar();
                        else Console.WriteLine("Opção inválida!");

                        Console.WriteLine("Pressione alguma tecla para continuar...");
                        Console.ReadKey();
                    }
                    else if (choice1 == 2)
                    {
                        choice2 = Choice.ChoiceADO2();
                        if (choice2 == 11) break;

                        if (choice2 == 1) AulasCsharp.Aula3.ADO2.Ex1.Executar();
                        else if (choice2 == 2) AulasCsharp.Aula3.ADO2.Ex2.Executar();
                        else if (choice2 == 3) AulasCsharp.Aula3.ADO2.Ex3.Executar();
                        else if (choice2 == 4) AulasCsharp.Aula3.ADO2.Ex4.Executar();
                        else if (choice2 == 5) AulasCsharp.Aula3.ADO2.Ex5.Executar();
                        else if (choice2 == 6) AulasCsharp.Aula3.ADO2.Ex6.Executar();
                        else if (choice2 == 7) AulasCsharp.Aula3.ADO2.Ex7.Executar();
                        else if (choice2 == 8) AulasCsharp.Aula3.ADO2.Ex8.Executar();
                        else if (choice2 == 9) AulasCsharp.Aula3.ADO2.Ex9.Executar();
                        else if (choice2 == 10) AulasCsharp.Aula3.ADO2.Ex10.Executar();
                        else Console.WriteLine("Opção inválida!");

                        Console.WriteLine("Pressione alguma tecla para continuar...");
                        Console.ReadKey();
                    }
                    else if (choice1 == 3)
                    {
                        choice2 = Choice.ChoiceADO3();
                        if (choice2 == 11) break;

                        if (choice2 == 1) AulasCsharp.Aula3.ADO3.Ex1.Executar();
                        else if (choice2 == 2) AulasCsharp.Aula3.ADO3.Ex2.Executar();
                        else if (choice2 == 3) AulasCsharp.Aula3.ADO3.Ex3.Executar();
                        else if (choice2 == 4) AulasCsharp.Aula3.ADO3.Ex4.Executar();
                        else if (choice2 == 5) AulasCsharp.Aula3.ADO3.Ex5.Executar();
                        else if (choice2 == 6) AulasCsharp.Aula3.ADO3.Ex6.Executar();
                        else if (choice2 == 7) AulasCsharp.Aula3.ADO3.Ex7.Executar();
                        else if (choice2 == 8) AulasCsharp.Aula3.ADO3.Ex8.Executar();
                        else if (choice2 == 9) AulasCsharp.Aula3.ADO3.Ex9.Executar();
                        else if (choice2 == 10) AulasCsharp.Aula3.ADO3.Ex10.Executar();
                        else Console.WriteLine("Opção inválida!");

                        Console.WriteLine("Pressione alguma tecla para continuar...");
                        Console.ReadKey();
                    }
                    else if (choice1 == 4)
                    {
                        choice2 = Choice.ChoiceADOVETOR();
                        if (choice2 == 11) break;

                        if (choice2 == 1) AulasCsharp.ADOVETOR.Ex1.Executar();
                        else Console.WriteLine("Opção inválida!");

                        Console.WriteLine("Pressione alguma tecla para continuar...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida!");
                        choice2 = 11; // Para sair do loop se opção inválida
                    }

                } while (choice2 != 11);

            } while (choice1 != 11);

            Console.WriteLine("Programa encerrado.");
        }
    }
}
