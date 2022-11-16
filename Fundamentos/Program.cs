using Fundamentos.Join.Context;

//PopulaDatabase();
//UsandoInnerJoin();
ExemploLeftJoin();

Console.ReadKey();

static void UsandoInnerJoin()
{
    using var contexto = new AppDbContext();

    //var innerJoin1 = contexto.Funcionarios //Outer Data Source
    //    .Join(
    //        contexto.Setores, //Inner Data Source
    //        funcionario => funcionario.FuncionarioId, //Inner Key Selector
    //        setor => setor.SetorId, //Ouuter Key Selector
    //        (funcionario, setor) => new
    //        {
    //            NomeFuncionario = funcionario.FuncionarioNome,
    //            NomeSetor = setor.SetorNome,
    //            CargoFuncionario = funcionario.FuncionarioCargo
    //        })
    //    .ToList();

    var innerJoin2 = (from f in contexto.Funcionarios
                      join s in contexto.Setores 
                      on f.FuncionarioId equals s.SetorId
                      select new
                      {
                          NomeFuncionario = f.FuncionarioNome,
                          NomeSetor = s.SetorNome,
                          CargoFuncionario = f.FuncionarioCargo
                      }).ToList();



    Console.WriteLine("Funcionario\t\tCargo\t\t\tSetor");

    foreach (var funcionario in innerJoin2)
    {
        Console.WriteLine($"{funcionario.NomeFuncionario}" +
                          $"\t\t{funcionario.CargoFuncionario}" +
                          $"\t\t{funcionario.NomeSetor}");
    }   
}

static void ExemploLeftJoin()
{
    using var contexto = new AppDbContext();


    var leftJoin = from f in contexto.Funcionarios
                   join s in contexto.Setores
                   on f.FuncionarioId equals s.SetorId
                   into funciSetorGrupo
                   from setor in funciSetorGrupo.DefaultIfEmpty()
                   select new
                   {
                       NomeFuncionario = f.FuncionarioNome,
                       NomeSetor = setor.SetorNome,
                       CargoFuncionario = f.FuncionarioCargo
                   };

    Console.WriteLine("Funcionario\t\tCargo\t\t\tSetor");

    foreach (var funcionario in leftJoin)
    {
        Console.WriteLine($"{funcionario.NomeFuncionario}" +
                          $"\t\t{funcionario.CargoFuncionario}" +
                          $"\t\t{funcionario.NomeSetor}");
    }  
}

static void PopulaDatabase()
{
    using (var contexto = new AppDbContext())
    {
        try
        {
            SeedDatabase.PopulaDB(contexto);
            Console.WriteLine("Concluído com sucesso");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro : " + ex.Message);
        }
    }
}