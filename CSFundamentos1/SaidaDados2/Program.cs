Console.WriteLine("Saída de dados : Usando sequencia de escapes");
Console.WriteLine();

// o compilador não aceita a \ dentro de uma string. Para funcionar, é preciso utilizar o Sequencias Escape
// neste caso, acrescentando mais uma barra.

// forma errada:
string local = "c:\dados\poesias.txt";

//forma correta:
string local2 = "c:\\dados\\poesias.txt";
