Console.WriteLine(" ## INSTRUÇÃO WHILE => BREAK SAIDA <= ##");

while (true)
{
    Console.WriteLine("/n Informe um número inteiro (para sair tecle 0");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero == 0)
    {
        break;
    }
    if (numero % 2 == 0)
    {
        Console.WriteLine($"O {numero} é PAR...");
    }
    else
    {
        Console.WriteLine($"O {numero} é IMPAR...");
    }
}


Console.WriteLine("Fim do processamento...");
Console.ReadKey();
