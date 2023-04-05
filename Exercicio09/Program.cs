Aluno aluno = new Aluno();
aluno.Nome = "Algum nome";

aluno.Notas = new List<Nota>();

aluno.Notas.Add(new Nota() { Valor = 7, bimestre = Nota.Bimestre.PRIMEIRO });
aluno.Notas.Add(new Nota() { Valor = 8, bimestre = Nota.Bimestre.SEGUNDO });
aluno.Notas.Add(new Nota() { Valor = 9, bimestre = Nota.Bimestre.TERCEIRO });
aluno.Notas.Add(new Nota() { Valor = 10, bimestre = Nota.Bimestre.QUARTO });

Console.Clear();
Console.WriteLine($"O valor da média do aluno {aluno.Nome} é de {aluno.Media} ");
