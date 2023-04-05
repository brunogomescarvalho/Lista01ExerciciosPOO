namespace Exercicio10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = " Abelardo ";

            aluno.Provas = new List<Prova>();

            aluno.Provas.Add(new Prova() { Nota = 6.75M, Peso = 8 });
            aluno.Provas.Add(new Prova() { Nota = 8.75M, Peso = 9 });

            Media media = new Media();
            media.Aluno = aluno;

            decimal valorMedia = media.ValorMedia;

            Console.Clear();
            Console.WriteLine($"O valor da média ponderada de {aluno.Provas.Count} provas do aluno {media.Aluno.Nome} é de {valorMedia} ");

        }
    }

}