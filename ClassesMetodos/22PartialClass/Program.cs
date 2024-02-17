using _22PartialClass;
using System.Runtime.ConstrainedExecution;
using System;

Console.WriteLine("## PARTIAL CLASS ##");

MinhaPartialClass minhaPartialClass = new MinhaPartialClass();

Console.WriteLine("Idade para nascidos em : 07/08/2003\n");

var idade = minhaPartialClass.CalculaIdade(new DateTime(2003, 8, 7));
Console.WriteLine($"{Math.Round(idade.TotalDays / 365)} anos");

Console.WriteLine("\nIdade para os nascidos em : 02/06/2005\n");

var data1 = DateTime.Now;
var data2 = new DateTime(2005, 06, 02);
var diferenca = minhaPartialClass.DiferencaEntreDatas(data1, data2);
Console.WriteLine($"{Math.Round(diferenca.TotalDays / 365)} anos");


Console.ReadKey();



  //  ==> REGRAS <==


  //      ->Todas as definições das classes parciais devem estar no mesmo assembly e no mesmo namespace.
		//-> Todas as partes devem possuira mesma acessibilidade, como: public ou private, etc.
		//-> Se qualquer parte for declarada abstract, então toda a classe será declarada do mesmo tipo.
		//-> O modificador partial somente pode ser usado antes da palavra-chave: class, struct ou interface.
		//-> Tipos parciais aninhados são permitidos.
		//-> Os atributs se aplicam a todas as partes da classe.
		//-> As características definidas em qualquer parte estão disponíveis para todas as partes das classes.