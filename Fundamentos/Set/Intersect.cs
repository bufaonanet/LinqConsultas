using Fundamentos.Dados;

public class Intersect
{
    static void UsandoIntersect()
    {
        List<int> fonte1 = new() { 1, 2, 3, 4, 5, 6 };
        List<int> fonte2 = new() { 1, 3, 5, 9, 10 };
        var resultado = fonte1.Intersect(fonte2).ToList();

        foreach (var item in resultado)
        {
            Console.Write($"{item} ");
        }

        List<string> fontePaises1 = new() { "Brasil", "USA", "UK", "Argentina", "China" };
        List<string> fontePaises2 = new() { "Brasil", "uk", "Argentina", "França", "Japão" };
        var resultadoPaises = fontePaises1.Intersect(fontePaises2, StringComparer.OrdinalIgnoreCase);

        foreach (var pais in resultadoPaises)
        {
            Console.Write($"{pais} ");
        }

        var turmaA = FonteDeDados.GetTurmaA();
        var turmaB = FonteDeDados.GetTurmaB();

        var consultaIntersect = turmaA.Select(a => a.Nacimento.Year).Intersect(turmaB.Select(a => a.Nacimento.Year));

        var consultaIntersectBy = turmaA.IntersectBy(turmaB.Select(b => b.Nacimento.Year), a => a.Nacimento.Year);

        Console.WriteLine("Turma A - Alunos com mesmo ano de nascimento turma B \n");

        foreach (var aluno in consultaIntersectBy)
        {
            Console.WriteLine($"{aluno.Nome}");
        }

        Console.WriteLine($"\nTotal de Alunos {consultaIntersectBy.Count()}");
        Console.WriteLine($"\nTotal de Alunos {consultaIntersect.Count()}");
    }
}
