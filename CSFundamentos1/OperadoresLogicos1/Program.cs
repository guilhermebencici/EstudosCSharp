Console.WriteLine("## OPERADORES LÓGICOS ##\n");

bool c1 = 5 >= 7;// FALSE
bool c2 = 9 != 8;//TRUE
bool resultado;

Console.WriteLine($"c1 = {c1}");
Console.WriteLine($"c2 = {c2}");

// OPERADOR AND -> &&
resultado = c1 && c2;
Console.WriteLine($"Operador AND(&&) : {resultado}");

// OPERADOR OR -> ||
resultado = c1 || c2;
Console.WriteLine($"Operador OR(||) : {resultado}");

// OPERADOR NOT-> !
resultado = !c1; //c1 é false, essa lógica deve retornar TRUE
Console.WriteLine($"Operador NOT(!) : {resultado}");

Console.ReadKey();