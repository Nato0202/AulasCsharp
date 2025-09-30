
Guia Explicado: JavaScript → C# (C-Sharp)
====================================================

1. Tipagem
Descrição:
Em JavaScript, variáveis podem mudar de tipo a qualquer momento, porque a linguagem é dinamicamente tipada. 
Já em C#, toda variável tem um tipo fixo definido no momento da declaração. Isso ajuda a evitar erros em tempo de execução,
mas exige que o programador seja mais explícito.

Exemplo:
    int idade = 20; // idade é sempre um inteiro
    var nome = "Bruno"; // C# infere que é string, mas não pode mudar depois

----------------------------------------------------

2. Estrutura do Código
Descrição:
Enquanto no JavaScript podemos escrever código diretamente e rodar no Node.js ou navegador, em C# tudo precisa estar dentro de uma classe.
O ponto de entrada do programa é o método `Main`. Isso mostra como C# segue uma estrutura mais organizada e orientada a objetos.

Exemplo em C#:
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }

----------------------------------------------------

3. Saída no Console
Descrição:
O comando `console.log` do JavaScript é equivalente ao `Console.WriteLine` do C#.
A diferença é apenas de sintaxe, a função é a mesma: mostrar mensagens no terminal.

----------------------------------------------------

4. Entrada de Dados
Descrição:
Em JavaScript, geralmente usamos bibliotecas externas (como prompt-sync) para capturar dados do usuário em ambiente Node.js.
Já em C#, a entrada de dados é nativa e feita com `Console.ReadLine()`. 
Esse comando sempre retorna uma string, que pode ser convertida para outros tipos (int, double, etc.) quando necessário.

----------------------------------------------------

5. Condicionais
Descrição:
As estruturas condicionais (`if`, `else`) funcionam quase iguais nas duas linguagens. 
A diferença é que C# exige sempre parênteses e não aceita valores “truthy/falsy” como no JS. 
Ou seja, em C# a condição deve ser sempre booleana.

----------------------------------------------------

6. Laços
Descrição:
Os laços (`for`, `while`) são praticamente idênticos em C# e JS. 
A principal diferença está na tipagem: em C# precisamos declarar o tipo do contador.

Exemplo:
    for (int i = 0; i < 5; i++) { ... }

----------------------------------------------------

7. Funções (Métodos)
Descrição:
Em JavaScript, funções podem retornar qualquer tipo sem declaração explícita. 
Já em C#, você deve definir o tipo de retorno (`int`, `string`, `void`). 
Isso traz mais segurança e clareza sobre o que a função entrega.

----------------------------------------------------

8. Objetos e Classes
Descrição:
No JavaScript, objetos são criados de forma literal (JSON). 
Em C#, é necessário definir classes que descrevem como os objetos se comportam e quais atributos/métodos possuem. 
Isso deixa o código mais organizado e favorece a reutilização.

----------------------------------------------------

9. APIs REST (Resumo para futuro)
Descrição:
Em JavaScript, a construção de APIs é geralmente feita com o Express. 
No C#, usamos o ASP.NET Core, que já vem com ferramentas integradas para lidar com rotas, middlewares e respostas HTTP.

----------------------------------------------------

Resumo Final:
- JavaScript é mais flexível, mas menos seguro em relação a tipos.
- C# é mais estruturado, seguro e voltado para orientação a objetos.
- O conhecimento de lógica que você tem em JS é totalmente aproveitado em C#, apenas precisa se adaptar à sintaxe e estrutura.


    dotnet new console --use-program-main      -    cria um projeto em csharp
    dotnet run                                 -    roda o projeto