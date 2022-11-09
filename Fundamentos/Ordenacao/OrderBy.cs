using Fundamentos.Dados;
#endregion
#region Usos do Linq

public class OrderBy
{
    static void UsandoOrderBy()
    {
        var nomes = new List<string> { "Paulo", "Tercisio", "Amaral", "Pedro", "Debora", "Percival", "Helena", "Rute", "Jose" };

        var lista = nomes.OrderBy(x => x).ToList();
        foreach (var nome in lista)
        {
            Console.Write($"{nome} ");
        }

        var alunos = FonteDeDados.GetAlunos();

        var lista1 = alunos.OrderBy(a => a.Nome);

        var lista2 = alunos.Where(a => a.Nome.Contains('r'))
                           .OrderBy(a => a.Nota);

        var lista3 = alunos.Where(a => a.Nome.Contains('r'))
                           .OrderBy(a => a.Nome)
                           .ThenBy(a => a.Nota);

        var lista4 = alunos.Where(a => a.Nome.Contains('r'))
                           .OrderByDescending(a => a.Nome)
                           .ThenByDescending(a => a.Nota);

        foreach (var aluno in lista4)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Idade}");
        }
    }
}
#endregion
