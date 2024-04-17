// instanciando o delegate apontando pro método1 (como se fosse single)
MeuDelegate delegateMulticast = new MeuDelegate(Metodo1);

//registrando mais méotodos, transoformando o delegate em MULTICAST
delegateMulticast += Metodo2;
delegateMulticast += Metodo3;

delegateMulticast("Olá, multicasta delegate!");

// excluindo método
delegateMulticast -= Metodo3;
delegateMulticast("O Metodo3 foi removido...");

Console.ReadKey();
static void Metodo1(string mensagem)
{
    Console.WriteLine("Método 1: " + mensagem);
}
static void Metodo2(string mensagem)
{
    Console.WriteLine("Método 2: " + mensagem);
}
static void Metodo3(string mensagem)
{
    Console.WriteLine("Método 3: " + mensagem);
}

// Delegate criado
public delegate void MeuDelegate(string mensagem);

