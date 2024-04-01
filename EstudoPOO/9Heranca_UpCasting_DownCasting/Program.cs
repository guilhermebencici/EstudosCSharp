using _9Heranca_UpCasting_DownCasting;

Circulo circulo = new Circulo(20, 20);
Forma f = circulo; // upcasting

Circulo c = (Circulo)f; // downcasting

c.Desenhar();
c.PintarCirculo();

Console.WriteLine(c == f);
Console.WriteLine(c == circulo);

Console.ReadKey();