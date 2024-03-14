
var lista = new List<string>() { "Maria", "Ana", "Pedro", "Carlos", "Zé", "Paulo" };

// INCLUINDO UM NOVO ELEMENTO ATRAVÉS DO MÉTODO ADD();
// ESSE MÉTODO, INCLUI O ELEMENTO AO FINAL DA LISTA.
lista.Add("Marta");

// O MÉTODO INSERT, ADICIONA  DADO NO ELEMENTO QUE EU ESCOLHER
lista.Insert(2, "Bia");

// INSERINDO UMA COLEÇÃO NA MINHA LISTA

// coleção a ser inscerida
string[] array1 = { "Diná", "Gui", "Gabi" };

// COM O ADDRANGE, OS DADOS DA COLEÇÃO SERÃO ADICIONADOS AO FINAL DA MINHA LISTA
lista.AddRange(array1);

// O MÉTODO INSERT, ADICIONA  DADO NO ELEMENTO QUE EU ESCOLHER
lista.InsertRange(1, array1);

Console.WriteLine(lista.Count + " itens ");

Console.ReadKey();