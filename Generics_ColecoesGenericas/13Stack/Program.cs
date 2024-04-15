Stack<int> numeros = new Stack<int>();
numeros.Push(10);
numeros.Push(20);
numeros.Push(30);
numeros.Push(10);

Console.WriteLine($"-A pilha original contém {numeros.Count} itens");

ExibirPilha(numeros);

// retorna sem remover
Console.WriteLine($"\n-Item obtido da pilha (Peek) : {numeros.Peek()}");

// remove e retorna
Console.WriteLine($"\n-Item Removido da pilha (Pop) : {numeros.Pop()}");


Console.WriteLine($"-A pilha agora contém {numeros.Count} itens");
ExibirPilha(numeros);


// verificando se existe na pilha
if (numeros.Contains(20))
{
    Console.WriteLine("\n-Item 20 está na pilha");
}
else
{
    Console.WriteLine("\n-Item 20 não está na pilha");
}

// copiando a pilha!
var copia = new Stack<int>(numeros.ToArray());

// deletando todos
numeros.Clear();


Console.ReadKey();

static void ExibirPilha<T>(IEnumerable<T> numeros)
{
    foreach (var item in numeros)
    {
        Console.WriteLine(item);
    }
}

/*

    MÉTODOS

PUSH() -> Inclui eleento no topo da pilha
POP() -> Remove e retornar um elemento do topo da pilha
PEEK() -> Retorna o elemento do topo da pilhar sem removê-lo
CONTAINS() -> Verifica se existe um elemento na pilha (true or false)
CLEAR() -> Remove todos os elementos da pilha.
TOARRAY() -> Copia a pilha em um novo array unidimensional

*/