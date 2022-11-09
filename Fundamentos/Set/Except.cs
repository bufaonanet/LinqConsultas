using Fundamentos.Dados;
#endregion
#region Usos do Linq

public class Except
{
    static void UsandoExept()
    {
        List<string> fontePaises1 = new() { "Brasil", "USA", "UK", "Argentina", "China" };
        List<string> fontePaises2 = new() { "Brasil", "uk", "Argentina", "França", "Japão" };
        var resultadoPaises = fontePaises1.Except(fontePaises2, StringComparer.OrdinalIgnoreCase).ToList();

        foreach (var pais in resultadoPaises)
        {
            Console.Write($"{pais} ");
        }

        var funcionarios = FonteDeDados.GetFuncionarios();
        var funcionarisoDeFerias = new List<string> { "Amanda", "Alicia", "Jaime" };
        var funcionariosTrabalhando = funcionarios.ExceptBy(funcionarisoDeFerias, f => f.Nome);
        foreach (var funcionario in funcionariosTrabalhando)
        {
            Console.WriteLine($"Funcionario: {funcionario.Nome}");
        }
    }
}
#endregion
