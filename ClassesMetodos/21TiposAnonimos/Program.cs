Console.WriteLine("## TIPOS ANÔNIMOS ##");

var aluno = new
{
    Nome = "Gui",
    Idade = 31
};

Console.WriteLine(aluno.Nome + " - " + aluno.Idade + " anos");


Console.ReadKey();