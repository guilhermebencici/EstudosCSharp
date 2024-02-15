Console.WriteLine("## CONSTRUTOR ESTÁTICO ##\n");

// INVOCA O CONSTRUTOR PARAMETRIZADO E  O ESTÁTICO
Pessoa p1 = new(19, "Maria");

Console.WriteLine($"{p1.Nome} - {p1.Idade}");
Console.WriteLine($"Idade Minima: {Pessoa.IdadeMinima}");

// INVOCA SOMENTE O CONSTRUTOR PARAMETRIZADO ( O ESTÁTICO É INVOCADO APENAS UMA VEZ)
Pessoa p2 = new(20, "João");

Console.WriteLine($"{p2.Nome} - {p2.Idade}");
Console.WriteLine($"Idade Minima: {Pessoa.IdadeMinima}");

Console.ReadKey();
