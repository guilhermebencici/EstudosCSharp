Console.WriteLine("## PALAVRA-CHAVE THIS##\n");

Teste t1 = new Teste(999);

Console.ReadKey();

public class Teste
{
    public Teste(int num1, int num2)
    {
        Console.WriteLine($"\n Construtor com dois parâmetros {num1} e {num2}");
    }

    public Teste(int num) : this(777, 888)
    {
        Console.WriteLine($"\n Construtor com um parâmetro {num}");

    }
}
