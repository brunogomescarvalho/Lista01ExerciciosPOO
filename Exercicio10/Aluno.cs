public class Aluno
{
    public List<Prova>? Provas { get; set; }
    public decimal Media { get => CalcularValorMedia(); }


    private decimal CalcularValorMedia()
    {
        decimal notaComPeso = 0;
        int somaPesos = 0;

        Provas!.ForEach(prova =>
           {
               notaComPeso += prova.Nota * prova.Peso;
               somaPesos += prova.Peso;
           });

        return Math.Round(notaComPeso / somaPesos, 2);
    }

}
