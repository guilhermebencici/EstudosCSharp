Console.WriteLine(" ## INSTRUÇÃO WHILE => ANINHADO <= ##\n");

int x = 0;
while (x < 5)
{
    int y = 0;
    while(y < 5)
    {
        Console.Write($"({x},{y}) ");
        y++;
    }
    x++;
    Console.WriteLine();
}


Console.WriteLine("Fim do processamento...");
Console.ReadKey();
