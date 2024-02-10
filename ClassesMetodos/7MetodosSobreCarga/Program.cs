Console.WriteLine("## ASSINATURA DE MÉTODO - SOBRECARGA - ##\n");

Email EnviarEmail = new Email();

EnviarEmail.Enviar("empresa.com.br");
EnviarEmail.Enviar("empresa.com.br","Proposta Comercial");
EnviarEmail.Enviar("empresa.com.br", 2000);
EnviarEmail.Enviar(2000,"empresa.com.br");


Console.ReadKey();

public class Email
{
    public void Enviar(string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Assunto Padrão");
    }

    public void Enviar(string endereco, string assunto)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}");
    }

    public void Enviar(string endereco, decimal valor)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Proposta Comercial");
        Console.WriteLine($"{valor}");
    }

    public void Enviar(decimal valor, string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Pagamento Fornecedor");
        Console.WriteLine($"{valor}");
    }

}