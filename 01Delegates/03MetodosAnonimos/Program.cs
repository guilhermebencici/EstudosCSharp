List<string> nomes = new List<string>();
nomes.Add("Maria");
nomes.Add("Maria 2");
nomes.Add("Maria 3");
nomes.Add("Maria 4");




string resultado = nomes.Find(delegate (string nome)
{
    return nome.Equals("Maria");
});


Console.WriteLine(resultado);

Console.ReadKey();
