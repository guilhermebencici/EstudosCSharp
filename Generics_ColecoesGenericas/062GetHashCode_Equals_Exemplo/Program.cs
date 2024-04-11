var pessoa1 = new Pessoa(123456, "Erica");
var pessoa2 = new Pessoa(123456, "Erica");
var pessoa3 = new Pessoa(987654, "Erica");

Console.WriteLine("pessoa1 -> CPF = 123456 Nome = Erica");
Console.WriteLine("pessoa2 -> CPF = 123456 Nome = Erica");
Console.WriteLine("pessoa3 -> CPF = 987654 Nome = Erica");



Console.WriteLine("\nComparando objetos PESSOA - GetHashCode");
Console.WriteLine("pessoa1 = " + pessoa1.GetHashCode());
Console.WriteLine("pessoa2 = " + pessoa2.GetHashCode());
Console.WriteLine("pessoa3 = " + pessoa3.GetHashCode());



Console.WriteLine("\nComparando objetos PESSOA - Equals");
Console.WriteLine("pessoa1.Equals(pessoa2) = " + pessoa1.Equals(pessoa2));
Console.WriteLine("pessoa2.Equals(pessoa3) = " + pessoa2.Equals(pessoa3));

Console.ReadKey();


public class Pessoa
{
    public Pessoa(int cpf, string? nome)
    {
        CPF = cpf;
        Nome = nome;
    }
    public int CPF { get; set; }
    public string? Nome { get; set; }

    // implementando a sobrescrita do método equals e do método GetHashCode

    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;

        if (obj is not Pessoa)
            return false;

        var other = (Pessoa)obj; // cast, tornando o other em tipo Pessoa

        return CPF.Equals(other.CPF);

    }

    public override int GetHashCode()
    {
        return CPF.GetHashCode();
    }
}
