// instanciando classe aluno (que é a classe derivada) e assim observando o comportamento da ORDEM de chamada dos construtores

Aluno aluno = new("Gui");


Console.ReadKey();

class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Primeio é chamado o Construtor da Classe Base ( Pessoa )");
    }
    public Pessoa(string nome)
    {
        Console.WriteLine("Construtor da Classe Base ( Pessoa ) COM parâmetro!");
    }
}

class Aluno : Pessoa
{
    public Aluno() : base() // ao colocar o ": base() " o construtor chamado será o da classe base e não da derivada
    {
        Console.WriteLine("Segundo é chamado o Construtor da Classe Derivada ( Aluno )");
    }

    public Aluno(string nome) : base(nome) // ao colocar o ": base() " o construtor chamado será o da classe base e não da derivada
    {
        Console.WriteLine("Construtor da Classe Derivada ( Aluno ) COM parâmetro!");
    }
}