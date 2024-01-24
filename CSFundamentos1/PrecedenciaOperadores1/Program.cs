Console.WriteLine("## PRECEDÊNCIA DE OPERDAORES ##\n");

// PELA ORDEM DE PRECEDÊNCIA, O COMPILADOR FARÁ PRIMEIRO A * E DEPOIS A -
int x = 10 - 2 * 3;
Console.WriteLine(x);

Console.WriteLine("==================");
Console.WriteLine("Alterando a precedência com ()");

// PELA ORDEM DE PRECEDÊNCIA, AO UTILIZAR O (), O COMPILADOR FARÁ PRIMEIRO A - E DEPOIS A *
int Y = (10 - 2) * 3;
Console.WriteLine(Y);

Console.ReadKey();