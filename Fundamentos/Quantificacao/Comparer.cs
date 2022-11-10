using Fundamentos.Dados;

public class Comparer
{
    public static void UsandoComparer()
    {
        string[] cursos = new[] { "C#", "Java", "Phyton", "PHP", "JavaScrípt", "Go" };

        var resultado = cursos.Contains("java", StringComparer.OrdinalIgnoreCase);

        Console.WriteLine(resultado);


        List<Aluno> alunos = new()
        {
            new Aluno() { Nome = "Maria", Idade = 36 },
            new Aluno() { Nome = "Manoel", Idade = 33 },
            new Aluno() { Nome = "Amanda", Idade = 21},
            new Aluno() { Nome = "Carlos", Idade = 18 }
        };

        var alunoBuscado = new Aluno() { Nome = "Manoel", Idade = 33 };

        AlunoComparer alunoComparer = new();

        var resultadoBuscaAluno = alunos.Contains(alunoBuscado, alunoComparer);


        Console.WriteLine(resultadoBuscaAluno);

    }
}
