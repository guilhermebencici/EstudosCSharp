Console.WriteLine("## OPERADORES INCREMENTO E DECREMENTO ##\n");


//EXEMPLO DE INCREMENTO
//int X = 10;
//X++;
//Console.WriteLine(X);

// EXEMPLOS DE PRÉ-INCREMENTO / PÓS-INCREMENTO

int x = 0;
Console.WriteLine($"x = {x}");

// PÓS-INCREMENTO -> PRIMEIRO RESOLVE DEPOIS INCREMENTA
int resultado1 = x++ + 10;

Console.WriteLine($"pós-incrremento ==> {resultado1}");
Console.WriteLine($"Valor de x ==> {x}\n");



// PRÉ-INCREMENTO -> PRIMEIRO INCREMENTA DEPOIS RESOLVE
int y = 0;
Console.WriteLine($"y = {y}");
int resultado2 = ++y  + 10;

Console.WriteLine($"pré-incrremento ==> {resultado2}");
Console.WriteLine($"Valor de y ==> {y}\n");


Console.ReadKey();