Console.WriteLine("## PARÂMETROS OPCIONAIS- ##\n");


Console.WriteLine("Informe o destino");
var destino = Console.ReadLine();

Console.WriteLine("Informe o titulo");
var titulo = Console.ReadLine();

Console.WriteLine("Informe o assunto");
var assunto = Console.ReadLine();


Email email = new();

email.Enviar(destino);
email.Enviar(titulo);
email.Enviar(destino, titulo, assunto);

Console.ReadKey();


public class Email
{
    public void Enviar(string destino, string titulo = "Titulo Padrão", string assunto = "Assunto Padrão")
    {
        Console.WriteLine($"\n Para {destino} - {titulo} \n Assunto: {assunto}");
    }
}