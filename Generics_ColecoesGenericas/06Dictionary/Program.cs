Dictionary<int, int> dic1 = new Dictionary<int, int>();
var dic2 = new Dictionary<int, int>();

// a chave (TKEY) não pode repitir, os valores podem
dic2.Add(2, 100);
dic2.Add(4, 400);
dic2.Add(3, 300);

var dic3 = new Dictionary<int, int>()
{
    { 1,100},
    { 2,200},
    { 3 ,300}
};

Console.WriteLine("\nTentando incluir elemento com chacve(3), duplicando-a");

try
{
    dic3.Add(3, 333);
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ToString());
}

Console.WriteLine("\nUsando o método TryAdd para a chave 3");

// TRYADD VAI TENTAR INCLUIR O ELEMENTO, COMO JÁ EXSTE, PRECISA RETORNAR FALSE.
var resultado = dic3.TryAdd(3, 333);
Console.WriteLine("Elemento foi incluido? " + resultado);

if (!dic3.ContainsKey(7))
{
    Console.WriteLine("\nIncluindo o elemento comc chave 7 e e valor 7000 ");
    dic3.Add(7, 7000);
}
Console.WriteLine(dic3[7]);

Console.WriteLine("\nUsando ContainsValue");
if (dic3.ContainsValue(7000))
{
    Console.WriteLine("O valor existe no dicionario: " + dic3[7]);
    Console.WriteLine("O valor atual: " + dic3[7]);

}


Console.WriteLine("\nAlterando o valor do elemento com chave 7");
if (dic3.ContainsKey(7))
{
    dic3[7] = 7777;
    Console.WriteLine("O valor alterado do item " + dic3[7]);
}

try
{
    Console.WriteLine(dic3[5]); ;
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ToString());
}

Console.WriteLine("\nUsando TryGetValue() para a chave 5");

if (dic3.TryGetValue(5, out int valor))
{
    Console.WriteLine("Valor para chave 5 = " + valor);
}
else
{
    Console.WriteLine("Chave não encontrada");
};

dic3.Add(6, 6666);
dic3.Add(4, 4444);

Console.WriteLine("\nPercorrendo o dicionário e exibindo os itens (foreach) ");
foreach (var item in dic3)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

Console.WriteLine("\nOrdenando os elementos do dicionário (SortedDictionary/LINQ) ");

//var dic3Ordenado = new SortedDictionary<int, int>(dic3);

//ORDENANDO ATRAVÉS DO LINQ
var dic3Ordenado = dic3.OrderBy(x => x.Key);
foreach (var item in dic3Ordenado)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}
Console.ReadKey();