public class Media
{
    public Aluno? Aluno { get; set; }
    public decimal ValorMedia { get => CalcularValorMedia(); }


    private decimal CalcularValorMedia()
    {
        decimal notaComPeso = 0;
        int somaPesos = 0;

        Aluno!.Provas!.ForEach(prova =>
        {
            notaComPeso += prova.Nota * prova.Peso;
            somaPesos += prova.Peso;
        });

        return Math.Round(notaComPeso / somaPesos, 1);
    }
}