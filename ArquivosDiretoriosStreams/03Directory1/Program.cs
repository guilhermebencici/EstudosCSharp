// meu diretório
var caminhoDiretorio = @"d:\";


Console.WriteLine("\nObtendo os ubdiretórios de um diretório");

try
{   //sempre validar se o tal diretório existe!
    if (Directory.Exists(caminhoDiretorio))
    {
        string[] subdiretorios = Directory.GetDirectories(caminhoDiretorio, "p*"); // GetDirectories(caminhoDiretorio,"p*") definindo critério de busca (Vai me mostrar os diretórios que iniciam com a letra P)
        foreach (var subdiretorio in subdiretorios)
        {
            Console.WriteLine(subdiretorio);
        }
    }
    else
    {
        Console.WriteLine($"O diretório {caminhoDiretorio} não existe!");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    //Console.WriteLine(ex.StackTrace);
}

Console.ReadKey();