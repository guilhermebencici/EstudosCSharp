// implementando as classes
Gato gatinho = new Gato() { Nome = "Miaau" };
gatinho.ExibirNome();// nota-se que o método utilizado vem da classe derivada e passou por um override

Cachorro cachorrinho = new Cachorro() { Nome = "Dogão" };
cachorrinho.ExibirNome(); // nota-se que o método utilizado vem da clase Base.


Console.ReadKey();

// CLASE BASE
class Animal
{
    public string? Nome { get; set; }
    public virtual void ExibirNome()
    {
        Console.WriteLine($"\nMeu nome é {Nome}");
    }
}

// CLASSE DERIVADA
class Gato : Animal
{
    public override void ExibirNome()
    {
        Console.WriteLine($"\nEu sou um gato. Meu nome é {Nome}");
    }
}

// CLASSE DERIVADA
class Cachorro : Animal
{
    // NÃO ESTOU IMPLEMENTANDO NADA, DESTA FORMA, ELE IRÁ EXIBIR O MÉTODO DA CLASSE PAI.
}