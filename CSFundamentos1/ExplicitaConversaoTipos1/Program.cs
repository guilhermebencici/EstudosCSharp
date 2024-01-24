using System;

Console.WriteLine("## Conversão de tipos ##\n");

// CONVERSÃO EXMPLÍCITA

// não consigo converter um tipo de 8 bytes em um de 5 bytes
// por isso, utilizo o CAST, forçando a conversão
double varDouble = 12.456; // 8bytes
//int varInt = varDouble; {maneira errada} // 4 byes

int varInt = (int)varDouble;// maneira correta

Console.WriteLine(varInt);

Console.ReadLine();

