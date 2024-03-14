var lista = new List<int>() { 9, 5, 4, 1, 7, 8, 3, 6, 9, 0 };

// REMOVE O ELEMENTO 7
lista.Remove(7);

// REMOVE O ELEMENTO INDICADO PELO INDICE
lista.RemoveAt(4);

// REMOVE O ELEMENTO A PARTIR DE UM INDICE
// NESTE EXEMPLO, QUERO REMOVER 2 ELEMENTOS SEGUDOS, A PARTIR DO INDICE 0
lista.RemoveRange(0, 2);

Console.ReadKey();