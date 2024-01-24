Console.WriteLine("## NULLABLE TYPES\n");

// Se "a" for igual a null, ele vai atribuir 0.
int? a = null;
int b = a ?? 0;


// Se "x" for diferente de null, irá atribuir x
int? x = 10;
int y = x ?? 0;

Console.WriteLine(b);
Console.WriteLine(y);

