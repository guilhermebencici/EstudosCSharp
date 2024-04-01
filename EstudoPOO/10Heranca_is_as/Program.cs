using _10Heranca_is_as;

Circulo circulo = new Circulo();
Forma forma = circulo; // upcasting -> É uma atribuição de um objeto, de uma classe filha para uma referência de uma classe base.

if (forma is Circulo) // verificando se o downCasting é possível
{
    Console.WriteLine("Convertendo Forma para Circulo\n");
    //((Circulo)forma).PintarCirculo(); // FORMA EXPLÍCITA
    var tipo = forma as Circulo; // FORMA IMPLÍCITA
    tipo?.PintarCirculo();
}
else
{
    Console.WriteLine("Operação de downcasting não é possível");
}
Console.ReadKey();