// meu diretório
var caminhoDiretorio = @"d:\dados\";


Console.WriteLine("\nObtendo todos os arquivos em um diretório");

try
{   //sempre validar se o tal diretório existe!
    if (Directory.Exists(caminhoDiretorio))
    {
        string[] arquivos = Directory.GetFiles(caminhoDiretorio);

        foreach (var arquivo in arquivos)
        {
            Console.WriteLine(arquivo);
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