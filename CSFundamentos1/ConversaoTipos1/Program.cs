Console.WriteLine("## Conversão de tipos ##\n");

// CONVERSÃO IMPLÍCITA

int varInt = 100; // int usa 4 bytes
double varDouble = varInt; // double usa 8 bytes

// Pelo fato de double utilizar mais bytes que int, a conversão implícita não acontece
double varDouble2 = 100;
int varInt2 = varDouble2;

Console.WriteLine(varDouble);