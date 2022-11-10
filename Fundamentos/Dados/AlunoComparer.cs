namespace Fundamentos.Dados
{
    public class AlunoComparer : IEqualityComparer<Aluno>
    {
        //Aluno são iguais se o nomes e idades forem iguais
        public bool Equals(Aluno x, Aluno y)
        {
            //Se ambas referências dos objetos forem iguais retorna true
            if (object.ReferenceEquals(x, y))
                return true;

            //Se uma das referências for null, retorna false
            if (x is null || y is null)
                return false;

            return x.Nome == y.Nome && x.Idade == y.Idade;
        }


        public int GetHashCode(Aluno obj)
        {
            if (obj == null)
                return 0;

            int NomeHashCode = obj.Nome == null ? 0 : obj.Nome.GetHashCode();
            int IdadeHashCode = obj.Idade.GetHashCode();

            return NomeHashCode ^ IdadeHashCode;
        }
    }
}
