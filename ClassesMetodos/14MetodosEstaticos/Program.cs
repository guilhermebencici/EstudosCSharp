Console.WriteLine("## MÉTODOS ESTÁTICOS ##\n");

Calculadora calc = new();

Console.WriteLine("\n Métodos de instancias (não estáticos) ");
var soma = calc.Somar(10, 10);
var subtrair = calc.Subtrair(10, 10);
var multiplicar = calc.Multiplicar(10, 10);
var dividir = calc.Dividir(10, 10);

Console.WriteLine(soma);
Console.WriteLine(subtrair);
Console.WriteLine(multiplicar);
Console.WriteLine(dividir);

Console.WriteLine("\n======================================================");


Console.WriteLine("\n Métodos estaticos ");
var staticSoma = CalculadoraStatic.Somar(20, 20);
var staticsSubtrair = CalculadoraStatic.Subtrair(20, 20);
var staticMultiplicar = CalculadoraStatic.Multiplicar(20, 20);
var staticDivisao = CalculadoraStatic.Dividir(20, 20);

Console.WriteLine(staticSoma);
Console.WriteLine(staticsSubtrair);
Console.WriteLine(staticMultiplicar);
Console.WriteLine(staticDivisao);

Console.ReadKey();

// MÉTODOS DE INSTANCIA, PRECISAM DO OBJETO PARA SEREM CHAMADOS
public class Calculadora
{
    public int Somar(int n1, int n2)
    {
        return n1 + n2;
    }

    public int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }

    public int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }

    public int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }
}

// MÉTODOS STATIC
public class CalculadoraStatic
{
    public static int Somar(int n1, int n2)
    {
        return n1 + n2;
    }

    public static int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }

    public static int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }

    public static int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }
}