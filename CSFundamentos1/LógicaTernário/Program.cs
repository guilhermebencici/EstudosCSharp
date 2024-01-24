Console.WriteLine("## OPERADOR TERNÁRIO ##\n");


Console.WriteLine("Informe a temperatura: \n");

var temp = Convert.ToDouble(Console.ReadLine());


// SE A CONDIÇÃO (TEMP > 27) FOR VERDADEIRA, ELE RETORNARÁ A PRIMEIRA EXPRESSÃO (QUENTE) SE FOR FALSA, ELE RETORNA A SEGUNDA EXPRESSÃO (NORMAL)
var resultado = temp > 27 ? "quente" : "Normal";

Console.WriteLine($"O tempo esta {resultado}");


Console.ReadKey();