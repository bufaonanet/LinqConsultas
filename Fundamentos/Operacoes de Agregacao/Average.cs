using Fundamentos.Dados;

public class Average
{
    static void UsandoAverage()
    {
        Console.WriteLine("# Linq - Cálculo de média #\n");

        var alunos = FonteDeDados.GetAlunos();

        var mediaNotas = alunos.Average(a => a.Nota);

        Console.WriteLine(mediaNotas);
    }
}

