Aluno aluno = new Aluno();
aluno.Nome = "Bruno";

aluno.Notas = new List<Nota>();

aluno.Notas.Add(new Nota() { Valor = 9, bimestre = Nota.Bimestre.PRIMEIRO });
aluno.Notas.Add(new Nota() { Valor = 9, bimestre = Nota.Bimestre.SEGUNDO });
aluno.Notas.Add(new Nota() { Valor = 10, bimestre = Nota.Bimestre.TERCEIRO });
aluno.Notas.Add(new Nota() { Valor = 9, bimestre = Nota.Bimestre.QUARTO });

Media media = new Media();
media.Aluno = aluno;

decimal valorMedia = media.ValorMedia;

Console.Clear();
Console.WriteLine($"O valor da média do aluno {media.Aluno.Nome} é de {valorMedia} ");
