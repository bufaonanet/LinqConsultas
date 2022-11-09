using Fundamentos.Dados;
#endregion
#region Usos do Linq

public class Select
{
    public static void ProjecaoDedadosComSelect()
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

}
#endregion
