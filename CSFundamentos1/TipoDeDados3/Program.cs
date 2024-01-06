Console.WriteLine("Atribuiindo valores para Bool e Char");

bool ativo = true;
bool inativo = false;

Console.WriteLine(ativo);
Console.WriteLine(inativo);

Console.WriteLine("Recebendo bool através do comparativo");
Console.ReadLine();

Console.WriteLine("O int 10 é igual ao int 15? " +(10 == 15));
Console.WriteLine("O int 10 é igual ao int 10? " + (10 == 10));

Console.ReadLine();
Console.WriteLine("=======================================================");

Console.WriteLine("Comparando variáveis");

int x = 100;
int y = 10;

Console.WriteLine(x > y);


Console.WriteLine("=======================================================");

Console.WriteLine("Comparando CHAR");

char l1 = 'A'; // char precisa estar contido entre aspas simples
char l2 = '\u0041'; // UNICODE

Console.WriteLine("Este é um char normal: " + l1);
Console.WriteLine("Este é um char do tipo UNICODE: " + l2);