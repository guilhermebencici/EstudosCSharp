﻿var lista = new List<string>() { "Maria", "Ana", "Marcos", "Pedro" };

// ACESSANDO ELEMENTO USANDO  O INDICE DELE.

var primeiroElemento = lista[0];
var quartoElemento = lista[3];

Console.WriteLine(primeiroElemento);
Console.WriteLine(quartoElemento);

// DETERMINO O INDICE E O NOVO VALOR 
lista[0] = "Zé";
lista[3] = "Silvia";


Console.WriteLine(lista[0]);
Console.WriteLine(lista[3]);

Console.ReadKey();