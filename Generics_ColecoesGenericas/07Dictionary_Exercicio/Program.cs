Console.WriteLine("### Alunos e Notas ###\n");

var alunos = new Dictionary<int, Aluno>()
{
    { 1, new Aluno("Maria", 7)},
    { 2, new Aluno("Eric", 8)},
    { 3, new Aluno("Ana", 9)},
    { 4, new Aluno("Alex", 6)},
    { 5, new Aluno("Diná", 5)}
};

ExibirColecao(alunos);

do
{
    Console.WriteLine("\nInforme o código do Aluno a localizar (00 para sair)");
    int codigo = Convert.ToInt32(Console.ReadLine());

    if (codigo == 00)
        break;

    var resultado = alunos.ContainsKey(codigo);
    if (resultado)
    {
        Console.WriteLine("Informe a nota (1 a 10) ");
        var nota = Convert.ToInt32(Console.ReadLine());
        alunos[codigo].Nota = nota;
    }
    else
    {
        Console.WriteLine("Aluno não localizado!!");
    }
}
while (true);
ExibirColecao(alunos);

// REMOVENDO UM ALUNO
Console.WriteLine("\nInforme o código do Aluno a REMOVER ");
int cod = Convert.ToInt32(Console.ReadLine());

if (alunos.ContainsKey(cod))
{
    alunos.Remove(cod);
    Console.WriteLine("\nAluno removido com sucesso");
}
else
{
    Console.WriteLine("\nCódigo não encontrado!");
}
ExibirColecao(alunos);

// INCLUINDO UM NOVO ALUNO!
Console.WriteLine("### Incluindo um novo Aluno ###");

Console.WriteLine("\nInforme o nome do Aluno");
string novoNome = Console.ReadLine();

Console.WriteLine("\nInforme o nome do Aluno");
int novaNota = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nInforme o código do Aluno");
int novoCodgo = Convert.ToInt32(Console.ReadLine());

if (!alunos.ContainsKey(novoCodgo))
{
    alunos.Add(novoCodgo, new Aluno(novoNome, novaNota));
    Console.WriteLine($"Aluno incluido com sucesso");
}
else
{
    Console.WriteLine("\nCódigo não encontrado!");
}
ExibirColecao(alunos);

// ORDENANDO OS ALUNOS PELO NOME!!

var alunosOrdenados = alunos.OrderBy(x => x.Value.Nome);
foreach (var item in alunosOrdenados)
{
    Console.WriteLine($"{item.Key} {item.Value.Nome} {item.Value.Nota} ");
}

// REMOVENDO TODOS OS ALUNOS
alunos.Clear();
ExibirColecao(alunos);
Console.WriteLine("Fim do exercício");

Console.ReadKey();

static void ExibirColecao(Dictionary<int, Aluno> alunos)
{
    foreach (var item in alunos)
    {
        Console.WriteLine($"{item.Key} {item.Value.Nome} {item.Value.Nota} ");
    }
}

public class Aluno
{
    public Aluno(string? nome, int nota)
    {
        Nome = nome;
        Nota = nota;
    }
    public string? Nome { get; set; }
    public int Nota { get; set; }
}