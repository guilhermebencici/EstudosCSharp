using Heranca_Exercicio1;

Console.WriteLine("\n Conta Corrente : Número: 111 Titular: Maria");
// instanciando uma conta
ContaCorrente conta = new();
conta.Numero = 111;
conta.Titular = "Maria";

// depositando valores na conta
Console.WriteLine("Depositando R$ 1.000,00");
conta.Depositar(1000);

//Sacando valores
Console.WriteLine("Sacando R$ 100,00");
conta.Sacar(100);

//informando saldo atual da conta
Console.WriteLine($"Saldo da Conta: {conta.Saldo.ToString("c")}");// ToString("c") formata pra moeda local

Console.WriteLine("Sacando R$ 2.000,00");
conta.Sacar(2000);
Console.WriteLine($"Saldo da Conta: {conta.Saldo.ToString("c")}");// ToString("c") formata pra moeda local


Console.ReadKey();

Console.WriteLine("\n Conta Poupança : Número: 222 Titular: José");

// instanciando uma conta poupança
ContaPoupanca poupanca = new();
conta.Numero = 222;
conta.Titular = "José";

// depositando valores na conta
Console.WriteLine("Depositando R$ 1.000,00");
poupanca.Depositar(1000);

//Sacando valores
Console.WriteLine("Sacando R$ 100,00");
poupanca.Sacar(100);

//informando saldo atual da conta
Console.WriteLine($"Saldo da Conta Poupança: {poupanca.Saldo.ToString("c")}");// ToString("c") formata pra moeda local

// tentando sacar valor maior que o saldo atual da conta poupança
Console.WriteLine("Sacando R$ 2.000,00");
poupanca.Sacar(2000);
Console.WriteLine($"Saldo da Conta Poupança: {poupanca.Saldo.ToString("c")}");// ToString("c") formata pra moeda local
Console.ReadKey();

Console.WriteLine("\n###   Conta Investimento :  Numero: 333 Titular: Ana   ###");
ContaInvestimento containvestimento = new();
containvestimento.Numero = 333;
containvestimento.Titular = "Ana";

Console.WriteLine("Depositando R$ 1.000,00");
containvestimento.Depositar(1000);
Console.WriteLine($"Saldo da conta investimento: " + containvestimento.Saldo.ToString("c"));
Console.WriteLine("Sacando R$ 100,00");
containvestimento.Sacar(100);
Console.WriteLine($"Saldo da conta investimento: " + containvestimento.Saldo.ToString("c"));

Console.WriteLine("\nSacando R$ 2.000,00");
containvestimento.Sacar(2000);
Console.WriteLine($"Saldo da conta investimento: " + containvestimento.Saldo.ToString("c"));

Console.ReadKey();