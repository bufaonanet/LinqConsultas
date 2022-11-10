

public class Reverser
{
    static void UsandoReverse()
    {
        int[] numeros = new int[] { 10, 30, 50, 40, 30, 100 };
        var listaReversa = numeros.Reverse();
        foreach (var numero in listaReversa)
        {
            Console.Write($"{numero} ");
        }

        var nomes = new List<string> { "Paulo", "Tercisio", "Amaral", "Pedro", };

        IEnumerable<string> listaReversa1 = nomes.AsEnumerable().Reverse();
        IQueryable<string> listaReversa2 = nomes.AsQueryable().Reverse();

        foreach (var nome in listaReversa1)
        {
            Console.WriteLine($"{nome} ");
        }
    }
}

