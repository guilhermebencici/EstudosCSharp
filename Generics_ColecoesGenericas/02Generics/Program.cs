ClasseGenerica<int> objInt = new ClasseGenerica<int>();
objInt.Adicionar(10);
objInt.Adicionar(20);
objInt.Adicionar(30);
objInt.Adicionar(40);
objInt.Adicionar(50);

Console.WriteLine("Classe ClasseGenerica<T> de objetos int \n");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(objInt[i]);
}

Console.ReadKey();

public class ClasseGenerica<T>
{
    //criando uma instancia de um arry de 5 elementos
    T[] obj = new T[5];

    // criando um contador para controlar a posição dos índices.
    int contador = 0;

    // metodo responsavel por adicionar qualquer tipo de objeto ao array
    public void Adicionar(T item)
    {
        if (contador < 5)
        {
            obj[contador] = item;
        }
        contador++;
    }

    // declarando um indexador -> permite que um tipo seja acessada da mesma forma que um array

    public T this[int index]
    {
        get { return obj[index]; }
        set { obj[index] = value; }
    }
}