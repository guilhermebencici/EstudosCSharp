Console.WriteLine("Definindo variáveis do tipo string, object e dtnamic");
Console.WriteLine();

// variaveis do tipo string, são IMUTAVEIS, não podendendo ser atelradas na memória
Console.WriteLine("======== STRING ========");
string nome = "Curso C#";

// Object, aceita todos os tipos de dados
Console.WriteLine("======== OBJECT ========");

object nota = 10;
object valor = 8.55;
object nome1 = "Gui";
object ativa = true;
object letra = 'G';

Console.WriteLine("object assumindo o tipo - int - " + nota);
Console.WriteLine("object assumindo o tipo - double - " + valor);
Console.WriteLine("object assumindo o tipo - string - " + nome1);
Console.WriteLine("object assumindo o tipo - bool - " + ativa);
Console.WriteLine("object assumindo o tipo - char - " + letra);