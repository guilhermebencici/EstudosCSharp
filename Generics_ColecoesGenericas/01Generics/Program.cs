Teste teste = new Teste();

int i1 = 10;
int i2 = 10;

float f1 = 10;
float f2 = 10;

teste.Comparar(i1, f2);


Console.ReadKey();

public class Teste
{
    // ESSE MÉTODO TIPADO DEIXA O CÓDIGO ENGESSADO, POIS ELE SÓ ESPERA O TIPO INT. SE PRECISARMOS COMPARAR OUTRO TIPO, DARÁ ERRO.
    //public void Comparar(int p1, int p2)
    //{
    //    var resultado = p1.Equals(p2);// equals compara o conteúdo e o tipo dos dados
    //    Console.WriteLine($"{p1} e {p2} são iguais ? {resultado}");
    //}


    // UTILIZANDO O <T>, DEIXO O MÉTODO LIVRE PRA RECEBER QUALQUER TIPO
    public void Comparar<T>(T p1, T p2)
    {
        var resultado = p1.Equals(p2);// equals compara o conteúdo e o tipo dos dados
        Console.WriteLine($"{p1} e {p2} são iguais ? {resultado}");
    }

    // UTILIZANDO O <T>, DEIXO O MÉTODO LIVRE PRA RECEBER QUALQUER TIPO
    // TIPOS DIFERENTES
    public void Comparar<T1,T2>(T1 p1, T2 p2)
    {
        var resultado = p1.Equals(p2);// equals compara o conteúdo e o tipo dos dados
        Console.WriteLine($"{p1} e {p2} são iguais ? {resultado}");
    }
}