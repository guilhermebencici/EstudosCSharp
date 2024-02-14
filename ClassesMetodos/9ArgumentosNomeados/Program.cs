Console.WriteLine("## ARGUMENTOS NOMEADOS - ##\n");

Email email = new();

//chamando de modo padrão
Console.WriteLine("chamando de modo padrão, respeitando a ordem dos parâmetro");
email.Enviar("teste@email.com", "Urgente", "Reunião");

// ARGUMENTOS NOMEADOS
Console.WriteLine("\n utilizando ARGUMENTOS NOMEADOS");
email.Enviar(titulo: "Urgente", destino:"Teste@email.com", assunto:"Reunião de orçamento");


Console.ReadKey();


public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\n Para {destino} - {titulo} \n Assunto: {assunto}");
    }
}