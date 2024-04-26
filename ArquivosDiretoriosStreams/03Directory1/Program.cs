// meu diretório
var caminhoDiretorio = @"d:\dados\MeuDiretorio";
string caminhoDestino = @"d:\dados\MeuDiretorioNovo";

Console.WriteLine("\nCriando um novo diretório");

try
{   //sempre validar se o tal diretório existe!
    if (Directory.Exists(caminhoDiretorio))
    {
        Directory.CreateDirectory(caminhoDiretorio);
        Console.WriteLine($"Diretório {caminhoDiretorio} criado com sucesso!");
    }
    else
    {
        Console.WriteLine($"O diretório  {caminhoDiretorio} já existe!");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    //Console.WriteLine(ex.StackTrace);
}

Console.ReadKey();