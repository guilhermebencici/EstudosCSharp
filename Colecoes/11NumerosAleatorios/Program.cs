//INSTANCIANDO O RANDOM
Random random = new Random();

// sem "limite", retornando um numero x
Console.WriteLine(random.Next());

// retorna um numero entre 0 e 20
Console.WriteLine(random.Next(20));

// retorna um numero entre 10 e 20
Console.WriteLine(random.Next(10,20));

// retorna um numero com virgula
Console.WriteLine(random.NextDouble());

// para gerar 'n' numeros, usa-se o for

Console.WriteLine("Usando FOR");
for (int i = 0; i < 10; i++)
{
    
    Console.WriteLine(random.Next(10,20));
}

Console.ReadKey();