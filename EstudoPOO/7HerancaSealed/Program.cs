
Cliente c = new();

//c.Nome = "José"; //Não vai mais funcioar, pois a herança foi perdida

Console.ReadKey();

class Pessoa
{
    public string? Nome { get; set; }
    public void ExibeNome()
    {
        Console.WriteLine($"Meu nome é {Nome}");
    }
}

class Cliente
{
    public new void ExibeNome()
    {
        // por causa do SEALED, a classe Cliente não pode mais herdar da classe Pessoa.
        //Console.WriteLine($"\n Nome do Cliente: {Nome}");
    }
}