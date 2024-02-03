Console.WriteLine("## ESTRUTURA SWITCH CASE -> ANINHADO <- ##\n");

int cargo = 0;
int funcao = 0;


Console.WriteLine("Você é Gerente(1) ou Programador(2)\t");
cargo = Convert.ToInt32(Console.ReadLine());

if (cargo == 2)
{
    Console.WriteLine("Você é Junior(1) ou Senior (2)");
    funcao = Convert.ToInt32(Console.ReadLine());
}

switch (cargo)
{
    case 1:
        Console.WriteLine("\nBem vindo Gerente");
        break;
    case 2:
        Console.WriteLine("\n Bem vindo Programador");
        switch (funcao)
        {
            case 1:
                Console.WriteLine("\n Você é Junior");
                break;
            case 2:
                Console.WriteLine("\n Você é Senior");
                break;
            default:
                Console.WriteLine("\nFunção desconhecida");
                break;
        }
        break;
    default:
        Console.WriteLine("\n Não cocnsito te identificar");
        break;
}

Console.WriteLine("\nFim do processamento...");


Console.ReadKey();