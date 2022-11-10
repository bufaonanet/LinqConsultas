using Fundamentos.Dados;

public class Any
{
    static void UsandoAny()
    {
        string[] cursos = new[] { "C#", "Java", "Phyton", "PHP", "JavaScrípt", "Go" };

        var existemCursos = cursos.Any();

        var existemCursosMaiorQue5 = cursos.Any(c => c.Length > 5);

        var cursoContemLetraP = cursos.Any(c => c.Contains('J'));

        Console.WriteLine($"{existemCursos} {existemCursosMaiorQue5} {cursoContemLetraP}");

        var cachorros = new List<Cachorro>
        {
            new Cachorro { Nome = "Bilu", Idade = 6 , Vacinado = true},
            new Cachorro { Nome = "Pipoca", Idade = 2, Vacinado = false },
            new Cachorro { Nome = "Negao", Idade = 8 , Vacinado = true},
        };

        //verificar cachorros nao facinados com mais de 2 anos
        bool naoVacinados = cachorros.Any(c => c.Idade > 2 && c.Vacinado == false);

        Console.WriteLine($"Há cachorros com mais de 2 anos não vacinados? {(naoVacinados ? "Exitem" : "Não possui!")}");
    }
}

