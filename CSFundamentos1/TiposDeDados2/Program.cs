Console.WriteLine("Atribuindo valores a double, float e decimal");
Console.WriteLine();

double n1 = 1.234;
float n2 = 1.234f;
decimal n3 = 1.234m;

Console.WriteLine("Este é double - posso ou não acrescentar um d ao final da atribuição " + n1);
Console.WriteLine("Este é um float - acrescentei f ao final da atribuição - " + n2);
Console.WriteLine("Este é o decimal - acrescentei o m ao final da atribuição - " + n3);
Console.ReadLine();

Console.WriteLine("===================================================================================");

Console.WriteLine("Comparando a precisão de float, double e decimal");

float x = 1f / 3f;
double y = 1d / 3d;
decimal z = 1m / 3m;

Console.WriteLine("Este é float e sua precisão: " + x);
Console.WriteLine("Este é um double e sua precisão:  " + y);
Console.WriteLine("Este é o decimal e sua precisão: " + z);

Console.ReadLine();