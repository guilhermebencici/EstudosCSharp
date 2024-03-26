Aluno a = new();
a.Nome = "Guilherme";
a.Curso = "ADS";

Console.WriteLine(a.Saudacao());

Console.ReadKey();

class Pessoa
{
    public string? Nome { get; set; }
    public string Saudacao() => $"Oi, eu sou o(a) {Nome}";
}

class Aluno : Pessoa
{
    public string? Curso { set; get; }
    // O modificador NEW, reforça a minha intenção de usar o método da classe derivada, mesmo que ele exista na classe Base
    public new string Saudacao() => $"Oi, eu sou o (a) {Nome}, do curso {Curso}";
}