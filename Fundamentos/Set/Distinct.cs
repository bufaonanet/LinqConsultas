using Fundamentos.Dados;

public class Distinct
{
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
}

