public class Aluno
{
    public List<Nota>? Notas { get; set; }
    public decimal Media { get => this.CalcularValorMedia(); }


    private decimal CalcularValorMedia()
    {
        decimal somaNotas = 0;

        this.Notas!.ForEach(nota => somaNotas += nota.Valor);

        return Math.Round(somaNotas / 4, 2);
    }

}
