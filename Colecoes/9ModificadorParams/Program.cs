Console.WriteLine("## \n SOMA DE NUMEROS INTEIROS ##");

// passando os numeros que queremos somar

int[] valores = { 1, 2, 3 };

var resultado = Calcular.Soma(valores);
Console.WriteLine(resultado);

var resultado2 = Calcular.Soma(10, 20, 30);
Console.WriteLine(resultado2);


Console.ReadKey();

public class Calcular
{
    //criando como static pra não precisar criar uma instancia da classe calcular para acesasr o método soma
    public static int Soma(params int[] numeros) // recebendo um array de inteiros chamado de numeros
    {
        int total = 0;
        foreach (var numero in numeros)
        {
            total += numero;
        }
        return total;
    }
}