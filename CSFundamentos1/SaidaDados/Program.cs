Console.WriteLine("Saída de dados : Formatação");
Console.WriteLine();

int idade = 25;
string nome = "Guilherme";
Console.WriteLine(nome);
Console.WriteLine(idade);
Console.WriteLine();

Console.ReadLine();

// usando a concatenação ( operador + )

Console.WriteLine("(estou concatenando) " + nome + " tem "+ idade + " anos");
Console.ReadLine();

// usando a interpolação de strings ( $$ -> interpola;áo {} )

Console.WriteLine("(estou interpolando) " + $"{nome} tem  {idade} anos");
