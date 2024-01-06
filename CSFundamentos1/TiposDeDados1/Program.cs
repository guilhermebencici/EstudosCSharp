Console.WriteLine("Declarando variáveis numéricas");
Console.WriteLine();

// declarando variáveis

byte valor1 = 255;
sbyte valor2 = -127;
int valor3 = -2143232;
uint valor4 = 2134232;
long valor5 = -21494394;

// caso seja constante, o compilador informa erro se tentarmos mudar a atribuição

const int valor6 = 10;
//valor6 = 11;

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);
Console.WriteLine(valor5);
Console.WriteLine(valor6);

Console.Read();