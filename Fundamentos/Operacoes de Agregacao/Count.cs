
#endregion
#region Usos do Linq


public class Count
{
    static void UsandoCount()
    {
        string[] cursos = new[] { "C#", "Java", "Phyton", "PHP", "JavaScrípt", "Go" };

        var resultado1 = cursos.Count();
        var resultado2 = cursos.Where(c => c.Contains('c')).Count();
        var resultado3 = cursos.Count(c => c.Contains('C', StringComparison.OrdinalIgnoreCase));

        Console.WriteLine(resultado1);
    }
}
#endregion
