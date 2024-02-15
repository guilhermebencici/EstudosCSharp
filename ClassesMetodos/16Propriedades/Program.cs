Console.WriteLine("## PROPRIEDADES ##\n");

Produto p1 = new();
p1.Nome = "Caderno";
p1.Preco = 4.00;
//p1.Desconto = 0.05;
//p1.PrecoFinal = p1.Preco - p1.Preco * p1.Desconto;
p1.EstoqueMinimo = 10;

p1.Exibir();


Console.ReadKey();

public class Produto
{
    private string? nome; //campo de apoio
    public string? Nome
    {
        get { return nome.ToUpper(); }
        set { nome = value; }
    }
    private double preco; //campo de apoio
    public double Preco
    {
        get { return preco; }
        set
        {
            if (value < 5.00)
            {
                preco = 5.00;
            }
            else
            {
                preco = value;
            }
        }
    }
    private double desconto = 0.05; //campo de apoio
    public double Desconto // utilizada apenas para leitura
    {
        get { return desconto; }
    }


    public double PrecoFinal
    {
        get { return Preco - (Preco * Desconto); }
    }
    public int EstoqueMinimo { get; set; }


    public void Exibir()
    {
        Console.WriteLine($"{Nome} \n{Preco.ToString("C")} \n{Desconto}\n{PrecoFinal.ToString("C")} \n{EstoqueMinimo}");
    }
}