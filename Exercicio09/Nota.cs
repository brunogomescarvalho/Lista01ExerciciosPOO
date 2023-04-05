public class Nota
{
    public decimal Valor { get; set; }
    public Bimestre bimestre { get; set; }


    public enum Bimestre
    {
        PRIMEIRO,
        SEGUNDO,
        TERCEIRO,
        QUARTO
    }
}
