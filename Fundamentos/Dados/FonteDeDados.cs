namespace Fundamentos.Dados;

public class FonteDeDados
{
    public static List<int> GetNumeros()
    {
        List<int> numeros = new List<int>()
        {
            1, 2, 4, 8, 16, 32, 64, 128, 256, 512
        };
        return numeros;
    }

    public static int[] GetIdades()
    {
        var idades = new[] { 30, 33, 35, 36, 40, 30, 33, 36, 30, 40 };
        return idades;
    }

    public static List<int> GetListaNegra()
    {
        List<int> numeros = new List<int>()
        {
            16, 128, 512
        };
        return numeros;
    }

    public static string[] GetPaises()
    {
        string[] paises =
            { "Brasil", "India", "USA", "Argentina", "Bélgica", "China" };
        return paises;
    }

    public static string[] GetNomes()
    {
        string[] nomes =
            { "Paulo", "MARIA", "paulo", "Amanda", "maria", "amanda" };
        return nomes;
    }

    public static List<Aluno> GetAlunos()
    {
        List<Aluno> alunos = new()
        {
            new Aluno() { Nome = "Maria", Idade = 42, Nota = 10, Cursos = new List<string>{"VB.Net","ASP.NET"} },
            new Aluno() { Nome = "Manoel", Idade = 34, Nota = 30, Cursos = new List<string>{"C#","EF Core"}},
            new Aluno() { Nome = "Amanda", Idade = 21, Nota = 15 , Cursos = new List<string>{"C++","Node"}},
            new Aluno() { Nome = "Carlos", Idade = 18 , Nota = 5, Cursos = new List<string>{"TypeScript","Angular"}},
            new Aluno() { Nome = "Alicia", Idade = 15 , Nota = 11, Cursos = new List<string>{"Azure","Blazor"}},
        };
        return alunos;
    }

    public static List<Funcionario> GetFuncionarios()
    {
        List<Funcionario> funcionarios = new()
        {
        new Funcionario() { Nome = "Maria", Idade = 36, Salario = 1000.0 },
        new Funcionario() { Nome = "Manoel", Idade = 33, Salario = 1500.0},
        new Funcionario() { Nome = "Amanda", Idade = 21, Salario = 1500.0 },
        new Funcionario() { Nome = "Carlos", Idade = 18, Salario = 5000.0},
        new Funcionario() { Nome = "Jaime", Idade = 36 , Salario = 11000.0},
        new Funcionario() { Nome = "Debora", Idade = 33 , Salario = 11000.0},
        new Funcionario() { Nome = "Alicia", Idade = 18 , Salario = 11000.0},
        new Funcionario() { Nome = "Sandra", Idade = 19 , Salario = 11000.0},
        };
        return funcionarios;
    }

    public static List<Aluno> GetTurmaA()
    {
        List<Aluno> alunos = new()
        {
            new Aluno() { Nome = "Maria", Idade = 36, Nacimento = new DateTime(2001,6,11) },
            new Aluno() { Nome = "Manoel", Idade = 33, Nacimento = new DateTime(2001,2,10) },
            new Aluno() { Nome = "Amanda", Idade = 21, Nacimento = new DateTime(1986,9,30)},
            new Aluno() { Nome = "Carlos", Idade = 18 ,Nacimento = new DateTime(1999,10,11)},
            new Aluno() { Nome = "Jaime", Idade = 36 , Nacimento = new DateTime(1988,9,15)},
        };
        return alunos;
    }

    public static List<Aluno> GetTurmaB()
    {
        List<Aluno> alunos = new()
        {
            new Aluno() { Nome = "Homero", Idade = 26, Nacimento = new DateTime(1988,9,15) },
            new Aluno() { Nome = "Silvia", Idade = 31, Nacimento = new DateTime(2001,9,30) },
            new Aluno() { Nome = "Felicio", Idade = 21, Nacimento = new DateTime(1986,9,30)},
            new Aluno() { Nome = "Carlos", Idade = 18 ,Nacimento = new DateTime(2002,8,15)},
            new Aluno() { Nome = "Alfredo", Idade = 33, Nacimento = new DateTime(1999,10,11)},
            new Aluno() { Nome = "Denize", Idade = 30 , Nacimento = new DateTime(2004,11,5)},
        };
        return alunos;
    }

}
