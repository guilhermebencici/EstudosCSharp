Console.WriteLine(" ## INSTRUÇÃO WHILE => TABUADA <= ##");

int numero;
int contador = 1;

Console.WriteLine("\n Digite um numero maior que zero\t");

numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    // definindo o loop while
    Console.WriteLine($"\n## TABUADA DO {numero} ##\n");

    while(contador < 11)
    {
        Console.WriteLine($"{numero} X {contador} = {numero * contador}");
        contador++;
    }
}
else
{
    Console.WriteLine("\n O número deve ser maior que zero!!");
}


Console.WriteLine("Fim do processamento...");
Console.ReadKey();
