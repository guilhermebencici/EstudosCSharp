
List<string> nomes = new List<string>()
{
    "Ana", "Maria", "Pedro", "Lair", "Hugo"
};

//LINQ -> SINTAXE DE CONSULTA
var resultado = (from m in nomes
                 where m.Contains('o')
                 select m).ToArray();

ExibirResultado(resultado);

// LINQ -> SINTAXE DE MÉTODO 

// ToList() -> Converte um IEnumerable<T> para um List<T>
// ToArray() -> Converte um IEnumerable<T> para um Array<T>
var resultado1 = nomes.Where(n => n.Contains('a')).ToList();

ExibirResultado(resultado1);

Console.ReadKey();

static void ExibirResultado(IEnumerable<string> resultado)
{
    foreach (var item in resultado)
        Console.WriteLine(item);
}