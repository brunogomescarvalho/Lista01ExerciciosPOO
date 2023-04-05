public class Aluno
{
    public List<Nota>? Notas { get; set; }
    public decimal Media { get => GestaoDeAlunos.CalcularValorMedia(this); }
}
