
using System.Collections;

var lista = new ArrayList() { "Ana", 5, true, " ", null, 1.1, "zé", 3, 9, 0, null };

// este método eu estou removendo a primeira ocorrência de Null
lista.Remove(null);

// neste método, eu aponto o índice do elemento que quero remover
lista.RemoveAt(4);

// neste método, eu escolho o inicio da remoção, através do indice, e a quantidade de elementos que quero remover
lista.RemoveRange(0, 2);

Console.ReadKey();