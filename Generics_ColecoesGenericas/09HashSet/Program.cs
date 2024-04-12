

// criação colação hashset com itens

// utilizando contrutores vazios, onde já crio a instancia atribuindo valor
var numeros = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var frutas = new HashSet<string> { "Morango", "Limão", "Mamão", "Uva" };

//pode-se também instanciar primeiro de pois atribuir valores

HashSet<int> pares = new HashSet<int>();
for (int i = 0; i < 10; i++)
{
    pares.Add(i * 2);
}

// construtor usando IEnurable
var lista1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var conjunto = new HashSet<int>(lista1);