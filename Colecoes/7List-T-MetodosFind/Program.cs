List<string> frutas = new()
{
    "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango"
};

//expressão Lambda
var fruta1 = frutas.Find(i => i.Contains('n'));
Console.WriteLine($"\n Utilizando o Find: {fruta1}");

// findlast, vai me mostrar a ultima ocorrência
var fruta2 = frutas.FindLast(i => i.Contains('n'));
Console.WriteLine($"\n Utilizando o FindLast: {fruta2}");
 

Console.ReadKey();