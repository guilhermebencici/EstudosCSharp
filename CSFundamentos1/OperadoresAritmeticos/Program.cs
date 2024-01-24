Console.WriteLine("## Operadores aritméticos ## \n");

Console.WriteLine("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\n Raiz quadrada de {x} = {Math.Sqrt(x)}");
Console.WriteLine($"\n Ptência de {x} elevado a {y} = {Math.Pow(x,y)}");
Console.WriteLine($"\n O mínimo entr {x} e {y} = {Math.Min(x,y)}");
Console.WriteLine($"\n O máximo entr {x} e {y} = {Math.Max(x,y)}");



Console.ReadKey();

//Console.WriteLine($"Soma de {x} + {y} = {x + y}");
//Console.WriteLine($"Subtração de {x} - {y} = {x - y}");
//Console.WriteLine($"Multiplicação de {x} * {y}= {x * y}");
//Console.WriteLine($"Divisão de {x} / {y}= {x / y}");
//Console.WriteLine($"Módulo de {x} % {y} = {x % y}");