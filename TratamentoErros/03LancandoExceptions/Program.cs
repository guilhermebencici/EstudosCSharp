// Ao lançar apenas throw, estou repassadno a mesma exceção para frente. ( importante utilizar apenas o throw, porque assim, consigo manter a hierarquia de exceções no rastreamento.
// Ao lançar throw ex, paro a exceção e após fazer alguma operação, lanço outra exceção a partir dali.

try
{
    A.ProcessarA();
}
catch (Exception ex)
{
    Console.WriteLine("\nTratando o erro em Main\n");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}

Console.ReadKey();

class A
{
    public static void ProcessarA()
    {
        try
        {
            B.ProcessarB();
        }
        catch (Exception ex)
        {
            throw ex;
            Console.WriteLine("Tratando o erro em A");
        }
    }
}
class B
{
    public static void ProcessarB()
    {

        try
        {
            C.ProcessarC();
        }
        catch (Exception ex)
        {
            throw ex;
            Console.WriteLine("Tratando o erro em B");
        }

    }
}
class C
{
    public static void ProcessarC()
    {
        throw new NotImplementedException("Método não implementado");
    }
}
