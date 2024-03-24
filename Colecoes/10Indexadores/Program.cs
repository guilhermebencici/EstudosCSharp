using _10Indexadores;

Time time = new Time();

//atribuindo time
time[1] = "Corinthians";
time[2] = "Palmeiras";
time[3] = "São Paulo";

//recuperando time
string timeUm = time[1];

Console.WriteLine($"O time recuperado é o {timeUm}");

Console.ReadKey();