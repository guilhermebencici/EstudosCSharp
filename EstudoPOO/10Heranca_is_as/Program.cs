using _10Heranca_is_as;

Circulo circulo = new Circulo();
Forma forma = circulo; // upcasting -> É uma atribuição de um objeto, de uma classe filha para uma referência de uma classe base.

//Circulo c = (Circulo)forma; // gera uma exceção

Circulo c = forma as Circulo; // downCasting -> É uma atribuição de um objeto da classe base para um objeto da classe derivada.

if(c != null)
{
    c.PintarCirculo();
}
else
{
    Console.WriteLine("Operação de downcasting é inválida");
}

Console.ReadKey();