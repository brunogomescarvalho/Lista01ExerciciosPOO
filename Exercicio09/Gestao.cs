public static class GestaoDeAlunos
{
    public static decimal CalcularValorMedia(Aluno aluno)
    {
        decimal somaNotas = 0;

        aluno.Notas!.ForEach(nota => somaNotas += nota.Valor);

        return Math.Round(somaNotas / 4, 2);
    }
}
