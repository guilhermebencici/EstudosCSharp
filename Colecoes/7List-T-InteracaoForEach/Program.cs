var lista = new List<string>() { "Maria", "Ana", "Marcos", "Pedro", "Soares" };

// Utilizando o FOREACH, não precisamos definir: INICIALIZAÇÃO E CONDIÇÃO
// "var" infere o tipo de cada um dos elementos
// "in" intera cada elemento da coleção
// o numero de interações é igual ao total de elementos da coleção

foreach(var item in lista)
{
    Console.WriteLine(lista);
}

Console.ReadKey();