using Fundamentos.Dados;
#endregion
#region Usos do Linq

public class Union
{
    static void UsandoUnion()
    {
        List<string> fontePaises1 = new() { "Brasil", "USA", "UK", "Argentina", "China" };
        List<string> fontePaises2 = new() { "Brasil", "uk", "Argentina", "França", "Japão" };
        var resultadoPaises = fontePaises1.Union(fontePaises2, StringComparer.OrdinalIgnoreCase).ToList();

        foreach (var pais in resultadoPaises)
        {
            Console.Write($"{pais} ");
        }

        var turmaA = FonteDeDados.GetTurmaA();
        var turmaB = FonteDeDados.GetTurmaB();

        var consultaUnion = turmaA.Select(a => a.Nome).Union(turmaB.Select(a => a.Nome));

        var consultaUnionBy = turmaA.UnionBy(turmaB, a => a.Nome);

        Console.WriteLine("Alunos nomes distintos \n");

        foreach (var aluno in consultaUnionBy)
        {
            Console.WriteLine($"{aluno.Nome}");
        }

        Console.WriteLine($"\nTotal de Alunos {consultaUnionBy.Count()}");
        Console.WriteLine($"\nTotal de Alunos {consultaUnion.Count()}");
    }
}
#endregion
