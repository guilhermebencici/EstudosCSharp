﻿// meu diretório
var caminhoDiretorio = @"d:\dados\MeuDiretorio";
string caminhoDestino = @"d:\dados\MeuDiretorioNovo";

Console.WriteLine("\nObtendo os ubdiretórios de um diretório");

try
{   //sempre validar se o tal diretório existe!
    if (Directory.Exists(caminhoDiretorio))
    {
        string[] subdiretorios = Directory.GetDirectories(caminhoDiretorio);
        foreach(var subdiretorio in subdiretorios)
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