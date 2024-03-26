// INSTANCIANDO A CLASSE

ClasseDerivada cd = new ClasseDerivada();
cd.VerificaAcesso();

Console.ReadKey();

public class ClasseDerivada : ClasseBase
{
    public void VerificaAcesso()
    {
        Public_Membro();
        Protected_Membro();
        Internal_Membro();
        Protected_Internal_Membro();

        // ESTE NÃO PODE SER ACESSADO FORA DE SUA PRÓPRIA CLASSE ( consigo acessar através do encapsulamento)
        //Private_Membro();

        Console.WriteLine("\nAcesso ao Campo private : private_Var, usando uma propriedade GET");

        int soma = public_var + protected_var + internal_var + Private_var;
        Console.WriteLine("\nTotal da soma: " + soma);

    }
}
public class ClasseBase
{
    // CAMPOS para auxiliar no encapsulamento do private
    public int public_var = 1;
    protected int protected_var = 2;
    internal int internal_var = 3;
    private int private_var = 4;

    // PROPRIEDADE
    public int Private_var
    {
        get { return public_var; }
        set {private_var = value; }
    }
    public void Public_Membro()
    {
        Console.WriteLine("ClasseBase - Método Publico");
    }
    protected void Protected_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected");
    }
    internal void Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método Internal");
    }
    protected internal void Protected_Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected_Internal");
    }
    private void Private_Membro()
    {
        Console.WriteLine("ClasseBase - Método Private");
    }
}