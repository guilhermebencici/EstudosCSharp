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
 
// findIndex retorna o indice e não o elemento em si
var fruta3 = frutas.FindIndex(i => i.Contains('n'));
Console.WriteLine($"\n Utilizando o FindIndex: indice: {fruta3} o que equivale ao item = {frutas[fruta3]}");

// FindLastIndex retorna o ultimo indice e não o elemento em si
var fruta4 = frutas.FindLastIndex(i => i.Contains('n'));
Console.WriteLine($"\n Utilizando o FindLastIndex: indice: {fruta4} o que equivale ao item = {frutas[fruta4]}");


Console.ReadKey();