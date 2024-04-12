Console.WriteLine("\n### CRIANDO O SORTEDDICTIONARY ###");

// inicializando uma coleção
var brics = new SortedDictionary<int, string>()
{
    { 20,"Brasil"},
    { 10,"China"},
    { 40,"India"},
    { 30,"Russia"}
};

// incluindo um novo elemento
Console.WriteLine("\n-Incluindo o elemento de chave = 70 e valor = África do Sul");

if (brics.ContainsKey(70))
{
    Console.WriteLine("A chave já exxiste");
}
else
{
    brics.Add(70, "África do Sul");
}

Console.WriteLine($"\n-Número de pares de chaves (elementos) no dicionário: {brics.Count}");

// acessando um elemento pela chave!
Console.WriteLine($"Chave 20 -> {brics[20]}");

// removendo elemento
brics.Remove(10);


Console.WriteLine($"\n-Verificando se uma chave existe com ContainsKey");
Console.WriteLine($"Existe a chave: 30 ? -> {brics.ContainsKey(30)}");

Console.WriteLine($"\n-Verificando se um valor existe com ContainsValue");
Console.WriteLine($"Existe o valor: 'Russia' ? -> {brics.ContainsValue("Russia")}");
Console.WriteLine($"Existe o valor: 'Chile' ? -> {brics.ContainsValue("Chile")}");


Console.WriteLine($"\n-Obtendo o valor da chave 30 usando TryGetValue");

if (brics.TryGetValue(30, out string? valor))
{
    Console.WriteLine($"VAlor da chave 30 : {valor}");
}
else
{
    Console.WriteLine($"A chave não existe!!");
}


// percorrendo coleção
foreach (var pais in brics)
{
    Console.WriteLine($"Chave/Valor = {pais.Key} {pais.Value}");
}

Console.ReadKey();