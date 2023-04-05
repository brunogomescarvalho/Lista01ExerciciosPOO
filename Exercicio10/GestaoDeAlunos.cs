public static class GestaoDeAlunos
{
    public static decimal CalcularValorMedia(Aluno aluno)
    {
        decimal notaComPeso = 0;
        int somaPesos = 0;

        aluno.Provas!.ForEach(prova =>
         {
             notaComPeso += prova.Nota * prova.Peso;
             somaPesos += prova.Peso;
         });

        return Math.Round(notaComPeso / somaPesos, 2);
    }

}
