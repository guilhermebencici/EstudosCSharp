using System.Collections;

// ADIÇÃO DE UM ELMENTO

var lista = new ArrayList() { "Maria", 5, true, " ", null };
//indice       0      1   2     3    4

// método add: Inclui o elemento ao FINAL
lista.Add(3.5);

// método insert: Inclui o elmento na posição escolhida
lista.Insert(2, "Paulo");


// ADIÇÃO DE UMA COLEÇÃO

var colecao = new ArrayList() { "Pedro", 5, true };

// coleção a qual quero incluir no meu arrayList
int[] array1 = { 1,2,3};

//método AddRange: Inclui a COLEÇÃO ao FINAL
colecao.AddRange(array1);

// método InsertRange: Inclui a COLEÇÃO na posição escolhida
colecao.InsertRange(2, array1);


Console.ReadKey();