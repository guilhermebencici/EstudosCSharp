// instanciando classe aluno (que é a classe derivada) e assim observando o comportamento da ORDEM de chamada dos construtores

Aluno aluno = new("Gui");


Console.ReadKey();

class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Primeio é chamado o Construtor da Classe Base ( Pessoa )");
    }
}

class Aluno : Pessoa
{
    public Aluno()
    {
        Console.WriteLine("Segundo é chamado o Construtor da Classe Derivada ( Aluno )");
    }

    public Aluno(string nome)
    {
        Console.WriteLine("Construtor da Classe Base ( Aluno ) COM parâmetro!");
    }
}