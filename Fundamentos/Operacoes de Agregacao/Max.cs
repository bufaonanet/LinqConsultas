using Fundamentos.Dados;

public class Max
{
    static void UsandoMax()
    {
        var funcionarios = FonteDeDados.GetFuncionarios();

        var maiorIdade = funcionarios.Max(f => f.Idade);

        var maiorSalarioFiltrado = funcionarios.Max(f =>
        {
            if (f.Idade > 30)
                return f.Salario;
            else
                return 0;
        });

        Console.WriteLine($"Maior Idade: {maiorIdade}");
        Console.WriteLine($"Maior Salário Funcionário a cima de 30: {maiorSalarioFiltrado}");
    }
}


