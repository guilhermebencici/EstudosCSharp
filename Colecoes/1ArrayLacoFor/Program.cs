// declaração do Array
int[] numeros;

//alocando na memória e inicializando
numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// modo padrão
//string[] nomes = new string[2] { "Guilherme", "Bencici" };

// simplificando a construção de um array
string[] nomes = { "Guilherme", "Bencici" };

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Elementos de índice {i}: {numeros[i]}");
}

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Elementos de índice {i}: {nomes[i]}");

}

Console.ReadKey();