﻿

string a = "Paulo";
string b = "Paulo";

// IRÁ RETORNAR TRUE, PORQUE PARA TIPOS PRIMITIVOS, O EQUALS COMPARA O VALOR DO OBJETO!
int x = 100;
int y = 100;


Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());
Console.WriteLine(x.GetHashCode());
Console.WriteLine(y.GetHashCode());



//O RESULTADO SERÁ FALSE, PORQUE PESSOA 1 E PESSOA 2 NÃO SÃO O MESMO OBJETO, SÃO REFRENCIAS.

var pessoa1 = new Pessoa(1, "Gui");
var pessoa2 = new Pessoa(1, "Gui");

Console.WriteLine(pessoa1.GetHashCode());
Console.WriteLine(pessoa2.GetHashCode());

Console.ReadKey();


public class Pessoa
{
    public Pessoa(int id, string? nome)
    {
        Id = id;
        Nome = nome;
    }
    public int Id { get; set; }
    public string? Nome { get; set; }
}