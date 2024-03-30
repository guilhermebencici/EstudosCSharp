Console.ReadKey();

// modificador protected, faz com que seus métodos sejam utilizados apenas por classes derivadas da classe Base
// Modificador virtual, permite que o método seja subscrito (Override)
class ClasseBase
{
    protected virtual void Metodo1()
    {
        Console.WriteLine("ClasseBase.Metodo1()");
    }
    protected virtual void Metodo2()
    {
        Console.WriteLine("ClasseBase.Metodo2()");
    }

}

class Derivada : ClasseBase
{ 
    protected sealed override void Metodo1()// sealed aqui, impede que este métodos seja utilizado
    {
        Console.WriteLine("Classe1.Metodo()");
    }

    protected override void Metodo2()
    {
        Console.WriteLine("Classe2.Metodo()");
    }
}

class Derivada2 : Derivada
{// Tentar Sobrescrever Método1() causa o erro CS0239
    protected override void Metodo1()
    {
        Console.WriteLine("Classe1.Metodo()");
    }

    protected override void Metodo2()
    {
        Console.WriteLine("Classe2.Metodo()");
    }
}