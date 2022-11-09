
#endregion
#region Usos do Linq


public class Sum
{
    static void UsandoSum()
    {
        int[] numeros = new[] { 3, 5, 7, 9, 10, 12, 15, 20, 30, 39 };

        var resultado1 = numeros.Where(n => n > 10).Sum();

        var resultado2 = numeros.Sum(n =>
        {
            if (n > 10)
                return n;
            else
                return 0;
        });

        Console.WriteLine(resultado2);
    }
}
#endregion
