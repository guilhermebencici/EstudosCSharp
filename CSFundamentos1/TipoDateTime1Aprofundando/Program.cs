Console.WriteLine("## Struct DateTime ##\n");

DateTime hoje = DateTime.Now;

//EXTRAINDO INFORMAÇÕES DA DATA ATUAL

Console.WriteLine("Extraindo o Ano: " + hoje.Year);
Console.WriteLine("Extraindo o Mês: " + hoje.Month);
Console.WriteLine("Extraindo o Dia: " + hoje.Day);
Console.WriteLine("Extraindo o Hora: " + hoje.Hour);
Console.WriteLine("Extraindo o Minutos: " + hoje.Minute);
Console.WriteLine("Extraindo o Segundos: " + hoje.Second);
Console.WriteLine("Extraindo o MiliSgundo: " + hoje.Millisecond);

Console.WriteLine("Aperte Enter para adicionar valores!");
Console.ReadLine();

//ADICIONANDO VALORES
Console.WriteLine("Estou adicionando 30 dias "+ hoje.AddDays(30));
Console.WriteLine("Estou adicionando 1 mês " + hoje.AddMonths(1));
Console.WriteLine("Estou adicionando 2 horas " + hoje.AddHours(2));
Console.WriteLine("Estou adicionando 5 anos " + hoje.AddYears(5));



Console.WriteLine("Aperte Enter obter dia da semana e do ano!");
Console.ReadLine();

Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

Console.WriteLine("Aperte Enter obter data e e hora nos formatos LONGO e CURTO");
Console.ReadLine();

// data, longa e curta
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());

// hora, formato longo e curto
Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());


