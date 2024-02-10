Console.WriteLine("## MÉTODOS COM PARÂMETROS ##\n");

Aluno aluno = new Aluno("Guilherme", 31, "Masculino", "S");

// TERNÁRIO: CONDIÇÃO ? EXPRESSÃO1 (SE TRUE) : EXPRESSÃO 2 ( SE FALSE)

Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? "Zero" : aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);


Console.ReadKey();

public class Aluno
{
    //CONSTRUTOR

    public Aluno(string nome) => Nome = nome;
    public Aluno(string nome,int idade, string sexo, string aprovado) : this(nome) //this(nome) chama o construtor que traz apenas o nome
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}

