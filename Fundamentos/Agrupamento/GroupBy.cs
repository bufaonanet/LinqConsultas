using Fundamentos.Dados;

public class GroupBy
{
    public static void UsandoGroupBy()
    {
        List<Funcionario> funcionarios = new()
        {
            new Funcionario() {Curso = "Fisica", Nome = "Vitor",  Sexo='M',  Idade = 18},
            new Funcionario() {Curso = "Fisica", Nome = "Priscila",  Sexo='F',  Idade = 18},
            new Funcionario() {Curso = "Quimica",Nome = "Jorge",  Sexo='M',  Idade = 21},
            new Funcionario() {Curso = "Moda",   Nome = "Bianca", Sexo='F',  Idade = 18},
            new Funcionario() {Curso = "Moda",   Nome = "Amanda", Sexo='F',  Idade = 21},
            new Funcionario() {Curso = "Moda",   Nome = "Betão", Sexo='M',  Idade = 21},
            new Funcionario() {Curso = "Fisica", Nome = "Bufão",  Sexo='M',  Idade = 36},
            new Funcionario() {Curso = "Quimica",Nome = "Douglas",Sexo='M',  Idade = 30},
            new Funcionario() {Curso = "Quimica",Nome = "Maria",Sexo='F',  Idade = 30},
            new Funcionario() {Curso = "Moda",   Nome = "Lorena", Sexo='F',  Idade = 21},
        };

        var grupos = funcionarios.GroupBy(f => f.Idade).OrderBy(g => g.Key);

        //Itera pelos grupos
        foreach (var grupo in grupos)
        {
            Console.WriteLine("\nIdade :" + grupo.Key + " Funcionarios: " + grupo.Count());

            //Itera através de cada grupo
            foreach (var funcionario in grupo)
            {
                Console.WriteLine($"\t{funcionario.Nome} {funcionario.Idade} {funcionario.Sexo}");
            }
        }

        var grupos2 = funcionarios
            .GroupBy(g => g.Curso)
            .OrderBy(g => g.Key)
            .Select(g => new
            {
                Key = g.Key,
                Funcionarios = g.OrderBy(g => g.Nome)
            });

        foreach (var grupo in grupos2)
        {
            Console.WriteLine($"{grupo.Key} (Funcionarios:{grupo.Funcionarios.Count()})");

            //Itera através de cada grupo
            foreach (var funcionario in grupo.Funcionarios)
            {
                Console.WriteLine($"\t{funcionario.Nome} {funcionario.Idade} {funcionario.Sexo}");
            }
        }

        var grupos3 = funcionarios
            .GroupBy(g => new { g.Curso, g.Sexo })
            .OrderBy(g => g.Key.Curso)
            .ThenBy(g => g.Key.Sexo)
            .Select(g => new
            {
                Curso = g.Key.Curso,
                Sexo = g.Key.Sexo,
                Funcionarios = g.OrderByDescending(g => g.Nome)
            });

        foreach (var grupo in grupos3)
        {
            Console.WriteLine($"\n{grupo.Curso} {grupo.Sexo} (Funcionarios:{grupo.Funcionarios.Count()})");

            //Itera através de cada grupo
            foreach (var funcionario in grupo.Funcionarios)
            {
                Console.WriteLine($"\t{funcionario.Nome} {funcionario.Idade} {funcionario.Sexo}");
            }
        }
    }
}
