using _8List_t_Exercicio;

//RETORNANDO UMA LISTA DE ALUNOS, ONDE A VARIAVEL aluno É DO TIPO lIST<ALUNO>
List<Aluno> alunos = FonteDados.GetAlunos();

ExibirAlunos(alunos);

// INSTANCIANDO NOVOS ALUNOS
Aluno bia = new Aluno() { Nome = "Bia", Nota = 9.92 };
Aluno mario = new Aluno() { Nome = "Mario", Nota = 4.92 };

// ADICIONANDO ALUNOS
alunos.Add(bia);
alunos.Add(mario);

ExibirAlunos(alunos);

// ENCONTRANDO UM ALUNO ESPECIFICO
var aluno1 = alunos.Find(n => n.Nome.Equals("Amanda"));

// removendo aluno encontrado
alunos.Remove(aluno1);

ExibirAlunos(alunos);

//ORDENANDO OS ALUNOS
//NÃO DA PRA USAR O SORT(), PORQUE NESTE CASO ESTOU ANALISANDO COM UM TIPO COMPLEXO.

var listaOrdenada = alunos.OrderBy(n => n.Nome).ToList();
ExibirAlunos(listaOrdenada);

// EXIBINDO ALUNOS COM NOTA MAIOR QUE 8

var notaOito = alunos.FindAll(n => n.Nota >= 8);
Console.Write("\n Alunos com nota igual ou maior que 8\n");

// percorrendo pra encontrar todos os alunos com a nota maior ou igual a 8
foreach (var item in notaOito)
{
    Console.WriteLine($"{item.Nome} \t{item.Nota}");
}

Console.ReadKey();

static void ExibirAlunos(List<Aluno> alunos)
{
    Console.WriteLine("\nRelação de Alunos");
    Console.WriteLine("\nNome\tNota");

    var somaNotas = 0.0;
    foreach (var item in alunos)
    {
        Console.WriteLine($"{item.Nome} \t{item.Nota}");
        somaNotas += item.Nota;
    }

    var mediaNotas = somaNotas / alunos.Count();

    Console.WriteLine($"\nMédia das notas: {Math.Round(mediaNotas, 2)}");
    Console.WriteLine($"\nTotal de Alunos: {alunos.Count()}");
}