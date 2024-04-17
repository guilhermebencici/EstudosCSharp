
Imprimir imprimir = delegate (int valor)
{
    Console.WriteLine($"Método Anônimo : {valor}");
};

imprimir(100);
imprimir(200);
imprimir(300);

Console.ReadKey();

// declarando o delegate
public delegate void Imprimir(int valor);