using _11Heranca_abstract;

Quadrado q = new();
Console.WriteLine(q.Descricao());

Console.WriteLine("\n Informe a cor da figura");
q.Cor = Console.ReadLine();

Console.WriteLine("\n Informe o valor do lado do quadrado");
q.Lado = Convert.ToInt32(Console.ReadLine());

q.CalcularArea();
q.CalcularPerimetro();

Console.WriteLine($"\nÁrea do quadrado: {q.Area} m2");
Console.WriteLine($"\nPerímetro do quadrado: {q.Perimetro} m");


Console.WriteLine($"\nO quadrado tem a cor : {q.Cor} ");

Console.ReadKey();