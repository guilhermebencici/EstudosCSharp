var lista = new List<string>() { "Maria", "Ana", "Marcos", "Pedro" };

// for para percorrer todos os elementos da minha lista
//caso eu queira uma quantidade especifica, eu altero a condição, ex: i < 3 (ele irá mostrar os 3 elementos
for(int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}

Console.ReadKey();