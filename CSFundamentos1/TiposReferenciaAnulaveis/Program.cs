Console.WriteLine("## TIPOS DE REFERÊNCIA ANULÁVEIS ##\n");


// DEIXANDO DESTA FORMA, VAI ESTOURAR UM EXCEPTION
//string nome = null;

//Console.WriteLine(nome.ToUpper());

// CORRIGINDO

string? nome = null;

// acrescentei operrado null (?)
Console.WriteLine(nome?.ToUpper()); // SE NOME FOR NULL, ELE VAI ATRIBUIR E EXIBIRÁ. SE NOME NÃO FOR NULL, ELE CHAMA O MÉTODO
Console.ReadKey();