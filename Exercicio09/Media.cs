public class Media
{
    public Aluno? Aluno { get; set; }
    public decimal ValorMedia { get => CalcularValorMedia(); }

    private decimal CalcularValorMedia()
    {
        decimal somaNotas = 0;

        Aluno!.Notas!.ForEach(nota => somaNotas += nota.Valor);

        return Math.Round(somaNotas / 4, 2);
    }
}