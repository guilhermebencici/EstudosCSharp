Console.WriteLine("## CLASSES E MÉTODOS ##\n");


// CRIANDO UM OBJETO

int x = 100;

Pessoa p1 = new Pessoa();
p1.nome = "Guilherme";
p1.idade = 31;
p1.sexo = "Masculino";

Console.WriteLine($"{p1.nome} {p1.idade} {p1.sexo}");

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}