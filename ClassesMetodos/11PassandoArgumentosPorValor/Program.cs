Console.WriteLine("## PASSANDO ARGUMENTOS POR VALOR ##\n");

int x = 20;

Console.WriteLine("\n Valor do argumento x antes de passar por valor: " + x);

Calculo calc = new Calculo();
calc.Dobrar(x);

Console.WriteLine("\n Valor do Argumento x depois de passar por valor " + x);

Console.ReadKey();


public class Calculo
{
    public void Dobrar(int y)
    {
        y *= 2;

        Console.WriteLine("\n Valor do parâmetro Y no método Dobrar: " + y);
    }
}
    