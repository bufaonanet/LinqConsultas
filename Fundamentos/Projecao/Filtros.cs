using Fundamentos.Dados;

public class Filtros
{
    static void Filtrando()
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

}
