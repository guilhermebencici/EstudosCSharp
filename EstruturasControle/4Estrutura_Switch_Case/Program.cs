Console.WriteLine("## ESTRUTURA SWITCH CASE ##\n");

int compra = 600;
Console.WriteLine("Valor da compra R$: 600, 00");
Console.WriteLine("Informe o numero de parcelas (1 a 3)");
var numeroParcelas = Convert.ToInt32(Console.ReadLine());

switch (numeroParcelas)
{
    case 1:
        Console.WriteLine($"\n Prestação R$ {compra / numeroParcelas}");
        break;
    case 2:
        Console.WriteLine($"\n Prestação R$ {compra / numeroParcelas}");
        break;
    case 3:
        Console.WriteLine($"\n Prestação R$ {compra / numeroParcelas}");
        break;
    default:
        Console.WriteLine("\nValor inválido, informe: 1, 2 ou 3");
        break;
}
Console.WriteLine("\nFim do processamento...");


Console.ReadKey();