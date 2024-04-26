// meu diretório
var caminhoDiretorio = @"d:\dados\MeuDiretorio";
string caminhoDestino = @"d:\dados\MeuDiretorioNovo";

Console.WriteLine("\nExcluindo um diretório");

try
{   //sempre validar se o tal diretório existe!
    if (Directory.Exists(caminhoDiretorio))
    {
        Directory.Delete(caminhoDiretorio);
        Console.WriteLine($"Diretório {caminhoDiretorio} excluido com sucesso!");
    }
    else
    {
        Console.WriteLine($"O diretório  {caminhoDiretorio} não existe!");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    //Console.WriteLine(ex.StackTrace);
}

Console.ReadKey();