// DECLARANDO A COLEÇÃO DO TIPO LIST<T>
List<string> lista;

// INICIALIZANDO
lista = new List<string>();

// DECLARANDO E INICIALIZANDO NA MESMA LINHA
List<int> lista1 = new List<int>();
var lista2 = new List<float>();
List<double> lista3 = new();


// INCLUINDO ELEMENTOS

List<string> nomes = new();
nomes.Add("Paulo");
nomes.Add("Gui");

// INICIALIZADOR DE COLEÇÃO 

var lista4 = new List<string>()
{
    "Otto", "Tutti", "Nala", "Chokito"
};


Console.ReadKey();