
using System.Collections;

var list = new ArrayList() { 1, 9, 10, 2, 3, 5, 100 };

//CONTAINS -> VERIFICO SE O ELEMENTO EM QUESTÃO EXISTE NA COLEÇÃO
var res1 = list.Contains(1);

Console.WriteLine($"Verificando se o elemento do ínice 1 existe! {res1}");


Console.WriteLine($"\nArray List Original (sem ordenação) \n");

foreach(var item in list)
{
    Console.Write($"{item} ");
}

//MÉTODO PARA ORDENAR
list.Sort();

Console.WriteLine($"\nArray List ORDENADO \n");
foreach(var item in list)
{
    Console.Write($"{item} ");
}


Console.ReadKey();