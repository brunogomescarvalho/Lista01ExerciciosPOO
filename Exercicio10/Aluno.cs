public class Aluno
{
    public List<Prova>? Provas { get; set; }
    public decimal Media { get => GestaoDeAlunos.CalcularValorMedia(this); } 

}
