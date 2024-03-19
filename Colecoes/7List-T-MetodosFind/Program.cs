List<string> frutas = new()
{
    "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango"
};

//expressão Lambda
var fruta1 = frutas.Find(i => i.Contains('n'));
Console.WriteLine(fruta1);

Console.ReadKey();