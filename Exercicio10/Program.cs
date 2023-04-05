namespace Exercicio10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "Bruno";

            aluno.Provas = new List<Prova>();

            aluno.Provas.Add(new Prova() { Nota = 7.75M, Peso = 8 });
            aluno.Provas.Add(new Prova() { Nota = 8.75M, Peso = 9 });


            Console.Clear();
            Console.WriteLine($"O valor da média ponderada de {aluno.Provas.Count} provas do aluno {aluno.Nome} é de {aluno.Media} ");

        }
    }

}