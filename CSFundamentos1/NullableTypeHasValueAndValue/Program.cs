Console.WriteLine("## NULLABLE TYPES\n");

//aqui declarei a variavel 'b' como nullable type
int? b = 100;

// propriedade HasValue retorna TRUE, caso a variável tenha valor
if (b.HasValue)
{
    Console.WriteLine($"b = {b.Value}");
}
else
{
    Console.WriteLine("b não possui um valor (null)");
}
