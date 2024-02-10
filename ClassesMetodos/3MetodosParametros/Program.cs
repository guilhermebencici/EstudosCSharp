Console.WriteLine("## MÉTODOS COM PARÂMETROS ##\n");

MinhaClasse mc = new MinhaClasse();

var nome = "Guilherme";
var dataAtual = DateTime.Now.ToShortDateString();

// VALORES DOS ARGUMENTOS
mc.Saudacao(nome, dataAtual);

Console.ReadKey();

class MinhaClasse
{
    // PARÂMETROS DO MÉTODO
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}