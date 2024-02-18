// declarei e aloquei memória para o array
string[,] alunos = new string[2, 5];

Console.WriteLine("\nAtribuindo dados ao array: strings com 2 linhas e 5 colunas[2,5]\n");
Console.WriteLine("{Maria, Paulo, Marta, Pedro, Carlos}");
Console.WriteLine("{Silvia, Pedro, Alicia, Manoel, Paula}\n");

// montando os for
// o primeiro para a primeira dimensão (linhas)
// o segundo para  a segunda dimensão (colunas)

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"Informe o valor para o elemento na posição [{i},{j}]");
        alunos[i, j] = Console.ReadLine();
    }
}

Console.WriteLine("\nConteúdo do Array alunos\n");

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.Write($"[{i},{j}] = {alunos[i, j]}\t ");
    }
    Console.WriteLine();
}

Console.ReadKey();