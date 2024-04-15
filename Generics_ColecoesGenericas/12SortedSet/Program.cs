var numeros = new SortedSet<int> { 1, 5, 3, 4, 2 };
ExibirColecao(numeros);

var frutas = new SortedSet<string> { "uva", "banana", "Morango", "laranja" };
ExibirColecao(frutas);

SortedSet<int> pares = new SortedSet<int>();
for (int i = 6; i > 0; i--)
{
    pares.Add(i * 2);
}
ExibirColecao(pares);

Console.ReadKey();

// DESTA FORMA, EU RESTRINJO A TIPAGEM
//static void ExibirColecao(SortedSet<int> numeros)
//{
//    foreach (var item in numeros)
//    {
//        Console.WriteLine(item);
//    }
//}

// DESTA FORMA, EU DEIXO DE MODO GENÉRICO
static void ExibirColecao<T>(IEnumerable<T> numeros)
{
    Console.WriteLine();
    foreach (var item in numeros)
    {
        Console.WriteLine(item);
    }
}