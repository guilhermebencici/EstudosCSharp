List<string> frutas = new()
{
    "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango"
};

var fruta1 = frutas.Find(Procura);
Console.WriteLine(fruta1);


Console.ReadKey();

// predicado
static bool Procura(string item)
{
    return item.Contains('n');
}