
using Fundamentos.Dados;

public class All
{
    public static void UsandoAll()
    {
        int[] numeros = { 10, 22, 32, 44, 56, 64, 78 };

        var todosNumerosSaoPares = numeros.All(n => n % 2 == 0);
        Console.WriteLine($"{(todosNumerosSaoPares ? "Todos são pares" : "Nem todos são Pares")}");

        var funcionario = new List<Funcionario>
        {
            new Funcionario{Nome = "Maria", Idade = 36, Salario = 3850.00},
            new Funcionario{Nome = "Manoel", Idade = 33, Salario = 2600.00},
            new Funcionario{Nome = "Amanda", Idade = 21, Salario = 5247.00}
        };

        var todosSalariosAcima2500 = funcionario.All(f => f.Salario > 2500.00);
        var todosMaioresDe21 = funcionario.All(f => f.Idade > 21);
        var todosNomesCotemLetraA = funcionario.All(f => f.Nome.Contains('a'));

        Console.WriteLine($"Todos salarios são maiores de 2500,00?: {todosSalariosAcima2500} ");
        Console.WriteLine($"Todos maiores de 21 anos?: {todosMaioresDe21} ");
        Console.WriteLine($"Todos nomes contem a letra 'A'?: {todosNomesCotemLetraA} ");

        var pessoas = FonteDeDados.GetPessoas();

        var possoasComCachorrosDeMaisDe5Anos = pessoas
            .Where(p => p.Cachorro.All(pet => pet.Idade > 5))
            .Select(p => p.Nome);

        foreach (var pessoa in possoasComCachorrosDeMaisDe5Anos)
        {
            Console.WriteLine(pessoa);
        }
    }
}
