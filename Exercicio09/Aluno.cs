public class Aluno
{
    public List<Nota>? Notas { get; set; }
    public decimal Media { get => CalcularValorMedia(); }

    private decimal CalcularValorMedia()
    {
        var media = Notas!.Average(x => x.Valor);

        return Math.Round(media, 2);
    }

}
