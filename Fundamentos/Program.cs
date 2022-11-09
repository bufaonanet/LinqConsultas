using Fundamentos2;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


#region Main



Console.ReadKey();
#endregion


#region Usos do Linq

void Filtrando()
{
    Console.WriteLine("##LINQ - Filtrar dados ##\n");

    // numeros = 1, 2, 4, 8, 16, 32, 64, 128, 256, 512
    var numeros = FonteDeDados.GetNumeros();

    var resultado1 = numeros.Where(n => n < 10);

    var resultado2 = numeros.Where(n => n > 1 && n != 4 && n < 20);

    //  16, 128, 512
    var listaNegra = FonteDeDados.GetListaNegra();

    var resultado3 = numeros.Where(n => !listaNegra.Contains(n));

    var resultado4 = numeros.Where(n => n > 1)
                            .Where(n => n != 4)
                            .Where(n => n > 20);

    // Console.WriteLine(string.Join(" - ", resultado4));


    // trabalhar com objetos complexos
    var alunos = FonteDeDados.GetAlunos();
    var listaAlunos = alunos.Where(a => a.Nome.StartsWith("A") && a.Idade < 18);

    foreach (var aluno in listaAlunos)
        Console.WriteLine(aluno.Nome + " : " + aluno.Idade);

}

void TiposDeConsulta()
{
    Console.WriteLine("# LINQ #");

    var listaFrutas = new List<string> { "Banana", "Maça", "Pera", "Laranja", "Uva" };

    //Query Syntax
    var resultado = from f in listaFrutas
                    where f.Contains('r')
                    select f;
    Console.WriteLine(string.Join(",", resultado));


    //Method Syntax
    var resultado2 = listaFrutas.Where(x => x.Contains("r")).ToList();
    Console.WriteLine(string.Join("-", resultado2));
}

static void ProjecaoDedadosComSelect()
{
    IEnumerable<Aluno> alunos = FonteDeDados.GetAlunos().ToList();
    foreach (Aluno aluno in alunos)
        Console.WriteLine($"{aluno.Nome} : {aluno.Nota}");


    IEnumerable<string> nomes = FonteDeDados.GetAlunos().Select(a => a.Nome);
    foreach (string nome in nomes)
        Console.WriteLine($"{nome}");

    var lista = FonteDeDados.GetAlunos().Select(a => new Aluno
    {
        Idade = a.Idade,
        Nome = a.Nome
    }).ToList();

    foreach (var aluno in lista)
        Console.WriteLine($"{aluno.Nome} : {aluno.Nota}");

    var alunosTipoAnonimo = FonteDeDados.GetAlunos().Select(a => new
    {
        IdadeAluno = a.Idade,
        NomeAluno = a.Nome,
        NotaAluno = a.Nota
    }).ToList();

    foreach (var aluno in alunosTipoAnonimo)
        Console.WriteLine($"{aluno.NomeAluno} : {aluno.IdadeAluno} : {aluno.NotaAluno}");

    var funcionariosTipoAnonimo = FonteDeDados.GetFuncionarios().Select(a => new
    {
        IdadeFunc = a.Idade,
        NomeFunc = a.Nome,
        SalarioFunc = a.Salario * 12
    }).ToList();

    foreach (var funcionario in funcionariosTipoAnonimo)
        Console.WriteLine($"{funcionario.NomeFunc} : {funcionario.IdadeFunc} : {funcionario.SalarioFunc}");

    //SelectMany
    List<List<int>> listas = new List<List<int>>
{
    new List<int>{ 1,2,3,6,6,4},
    new List<int>{ 4,5,6,10,10},
    new List<int>{ 7,8,9,5,5},
};

    var resultado = listas.SelectMany(lista => lista).Distinct();
    foreach (var item in resultado)
    {
        Console.WriteLine($"{item}");
    }

    //UsandoSelect
    IEnumerable<List<string>> retornoSelect = FonteDeDados.GetAlunos().Select(c => c.Cursos);
    foreach (var listaCursos in retornoSelect)
    {
        foreach (var curso in listaCursos)
        {
            Console.WriteLine($"{curso}");
        }
    }

    //UsandoSelectMany
    IEnumerable<string> retornoSelectMany = FonteDeDados.GetAlunos().SelectMany(c => c.Cursos);
    foreach (var curso in retornoSelectMany)
    {
        Console.WriteLine($"{curso}");
    }
}

static void OperacoesComConjuntos()
{
    UsandoDistinct();
    UsandoExept();
    UsandoIntersect();
    UsandoUnion();
}

static void UsandoDistinct()
{
    Console.WriteLine("# Linq - Operações com comjuntos #\n");


    var idadesDistintas = FonteDeDados.GetIdades().Distinct();
    foreach (var idade in idadesDistintas)
    {
        Console.Write($"{idade} ");
    }

    var nomesDistintos = FonteDeDados.GetNomes().Distinct(StringComparer.OrdinalIgnoreCase);
    foreach (var nome in nomesDistintos)
    {
        Console.Write($"{nome} ");
    }

    var funcionariosIdadesDistintas = FonteDeDados.GetFuncionarios().DistinctBy(f => f.Idade);
    foreach (var funcionario in funcionariosIdadesDistintas)
    {
        Console.WriteLine($"Funcionario: {funcionario.Nome} tem {funcionario.Idade} anos");
    }

    List<int> fonte1 = new() { 1, 2, 3, 4, 5, 6 };
    List<int> fonte2 = new() { 1, 3, 5, 9, 10 };
    var resultado = fonte1.Except(fonte2).ToList();

    foreach (var item in resultado)
    {
        Console.Write($"{item} ");
    }
}

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
#endregion
