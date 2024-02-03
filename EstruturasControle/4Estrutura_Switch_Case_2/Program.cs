Console.WriteLine("## ESTRUTURA SWITCH CASE ##\n");


Console.WriteLine("Informe o nome do Mês\t");

var mes = Console.ReadLine().ToLower(); // O método ToLower() transforma a string em minúscula

switch (mes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine($"{mes} tem 31 dias!");
        break;
    case "fevereiro":
        Console.WriteLine($"{mes} pode ter 28 ou 29 duas.");
        break;
    default:
        Console.WriteLine($"{mes} tem 30 dias!");
        break;
}




Console.WriteLine("\nFim do processamento...");


Console.ReadKey();