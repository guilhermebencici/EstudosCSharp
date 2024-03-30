
Console.ReadKey();

class Pessoa
{
    public string? Nome { get; set; }
    public void ExibeNome()
    {
        Console.WriteLine($"Meu nome é {Nome}");
    }
}

class Cliente : Pessoa
{
    public new void ExibeNome()
    {
        Console.WriteLine($"\n Nome do Cliente: {Nome}");
    }
}