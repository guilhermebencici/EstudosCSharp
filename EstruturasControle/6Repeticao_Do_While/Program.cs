Console.WriteLine(" ## INSTRUÇÃO  DO WHILE ##\n");

var i = 1;

do
{
    Console.WriteLine($"i ={i}");
    i++;

    // CONDIÇÃO DE SAÍDA DO LOOP
    if (i > 7)
        break;
}
while (i <= 10);

Console.WriteLine("Fim do processamento...");
Console.ReadKey();
