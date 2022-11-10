using Fundamentos.Dados;

public class Aggregate
{
    static void UsandoAggregate()
    {
        Console.WriteLine("## Operadoes de Agregação ##\n");

        string[] cursos = new[] { "C#", "Java", "Phyton", "PHP", "JavaScrípt", "Go" };

        var resultado = cursos.Aggregate((c1, c2) => c1 + ", " + c2);
        Console.WriteLine(resultado);

        var alunos = FonteDeDados.GetAlunos();

        string listaAlunos = alunos.Aggregate<Aluno, string>(
            "Nomes: ", //valor da semente
            (semente, aluno) => semente += aluno.Nome + ", ");

        int indice = listaAlunos.LastIndexOf(",");
        listaAlunos = listaAlunos.Remove(indice);

        Console.WriteLine(listaAlunos);

        string listaAlunos2 = alunos.Aggregate<Aluno, string, string>(
            "Nomes: ", //valor da semente
            (semente, aluno) => semente += aluno.Nome + ",",
            resultado => resultado.Substring(0, resultado.Length - 1));


        Console.WriteLine(listaAlunos2);
    }
}