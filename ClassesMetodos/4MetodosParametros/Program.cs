Console.WriteLine("## MÉTODOS COM PARÂMETROS ##\n");

var aluno = new Aluno();

Console.WriteLine("Nome: ");
aluno.Nome = Console.ReadLine();

Console.WriteLine("Idade: ");
aluno.Idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sexo: ");
aluno.Sexo = Console.ReadLine();

Console.WriteLine("Aprovado (S) ou Reprovado(N): ");
aluno.Aprovado = Console.ReadLine();


Curso curso = new();
curso.Resultado(aluno.Nome, aluno.Idade, aluno.Sexo, aluno.Aprovado);



Console.ReadKey();

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}

public class Curso
{
    //public void Resultado(string nome, int idade, string sexo, string aprovado)
    //{
    //    Console.WriteLine($"\nO aluno {nome}, do sexo {sexo} e com a {idade} anos.");
    //    if (aprovado == "S")
    //    {
    //        Console.WriteLine($"\n Foi Aprovado!");

    //    }
    //    else
    //    {
    //        Console.WriteLine($"\n Foi Reprovado!");

    //    }
    //}

    // MÉTODO ESPERA RECEBER APENAS UM PARÂMETRO:  um objeto aluno do TIPO Aluno
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"\nO aluno {aluno.Nome}, do sexo {aluno.Sexo} e com a {aluno.Idade} anos.");
        if (aluno.Aprovado == "S")
        {
            Console.WriteLine($"\n Foi Aprovado!");

        }
        else
        {
            Console.WriteLine($"\n Foi Reprovado!");

        }
    }
}