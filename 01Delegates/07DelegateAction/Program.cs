using System;

Console.WriteLine("Informe um número inteiro :");
int numero = Convert.ToInt32(Console.ReadLine());

//delegateACtion + método Anônimo + operador lambda
Action<int> dobra = x => Console.WriteLine(x * 2);
dobra(numero);

Console.ReadKey();

