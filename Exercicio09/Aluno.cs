public class Aluno
{
    public List<Nota>? Notas { get; set; }
    public decimal Media { get => Gestao.CalcularValorMedia(this); }
}
