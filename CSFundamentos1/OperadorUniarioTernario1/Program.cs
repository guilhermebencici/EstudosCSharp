Console.WriteLine("## OPERADOR UNIÁRIO E TERNÁRIO ##\n");

//// COM O OPERADOR +, O VALOR RETORNADO É O PRÓPRIO OPERANDO
//int positivo = 1;
//int resultado;
//resultado = +positivo; // OPERADOR +

//Console.WriteLine(resultado); // O RETORNO SERÁ O OPERANDO, NESTE CASO, 1

// OPERADOR NEGATIVO (-)

Console.WriteLine("Informe um numero: \n");

var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O negavito de {n} é {-n}");
Console.ReadKey();