Console.WriteLine("## CONSTANTES ##\n");

// CALCULANDO A ÁREA E O PERÍMETRO DE UM CÍRCULO

double raio, perimetro, area;
const double PI = 3.14;

Console.WriteLine("Informe o raio do círculo");

// CONVERTENDO A ENTRADA DE UMA STRING PARA DOUBLE
 raio = Convert.ToDouble(Console.ReadLine());

// MODO SIMPLES DE REALIZAR O CÁLCULO.
//perimetro = 2 * PI * raio;
//area = PI * raio * raio;

// MODO INTERESSSANTE DE REALIZAR O CÁLCULO.
perimetro = 2 * Math.PI * raio;
area = Math.PI * Math.Pow(raio, 2);

Console.WriteLine($"Perímetro = {perimetro}");
Console.WriteLine($"Área = {area}");

Console.ReadKey();