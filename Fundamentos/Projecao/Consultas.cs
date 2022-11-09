
#endregion
#region Usos do Linq

public class Consultas
{
    public static void TiposDeConsulta()
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
}
#endregion
