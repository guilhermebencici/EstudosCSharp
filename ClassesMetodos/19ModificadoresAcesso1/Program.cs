using _18Enumeration;

Console.WriteLine("## MODIFICADORES DE ACESSO ##");


// MESMO INSTANCIANDO, NÃO CONSIGO CHAMAR NENHUM MEMBRO, POIS TODOS ESTÃO COMO PRIVATES(PADRÃO)
MinhaClasse minhaClasse = new MinhaClasse();
// minhaClasse...

MinhaStruct minhaStruct = new MinhaStruct();
// minhaStruct...

MinhaEnum minhaEnum = new MinhaEnum();
// minhaEnum...


Console.ReadKey();
