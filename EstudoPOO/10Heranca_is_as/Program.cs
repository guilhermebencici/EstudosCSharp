
Object carroObj = new Carro();

// fazendo a conversão explícita, sem usar o operador 'as'

try
{
	var x = (string)carroObj; // exception
}
catch (Exception ex)
{

	Console.WriteLine("\nA Conversão falhou...\n");
	Console.WriteLine(ex.Message);
}

Console.ReadKey();

class Carro { }