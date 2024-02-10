Console.WriteLine("## MÉTODOS ##\n");

MinhaClasse mc = new MinhaClasse();
mc.Saudacao();

Console.ReadKey();

class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Teste!!");
    }
}