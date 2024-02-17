
string[] nomes = { "Guilherme", "Gui", "Guiguis", "Guilhermão", "Guizin", "Guizão", "Guigui", "Mr. G", "SAG", "Bencici" };

Console.WriteLine("\n\n Exibindo o Array original...");
ExibeArray(nomes);

Console.WriteLine("\n\n Invertendo a ordem Array...");
Array.Reverse(nomes);
ExibeArray(nomes);


Console.WriteLine("\n\n Ordenando Array...");
Array.Sort(nomes);
ExibeArray(nomes);

Console.WriteLine("\n\n Localizando um item no array");
Console.WriteLine("Informe o nome");
string nome = Console.ReadLine();

var indice = Array.BinarySearch(nomes, nome);

if (indice >= 0)
{
    Console.WriteLine($"\n{nome} foi encontrado com índice = {indice}");
}
else
{
    Console.WriteLine($"\n{nome} não foi encontrado");
}

Console.ReadKey();

static void ExibeArray(string[] nomes)
{
    foreach (var nome in nomes)
    {
        Console.WriteLine($"{nome} ");
    }
}