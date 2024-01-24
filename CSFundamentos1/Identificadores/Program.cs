Console.WriteLine("DEFININDO IDENTIFICADORES");
Console.WriteLine();

// IDENTIFICADORES VÁLIDOS

string nome;
string nomeCompleto;
int idade;
int _valor;
int idade1;

// IDENTIFICADORES INVÁLIDOS

//int 5idade;
//int $valor;
// valor#total;
//string nome Completo;


// para variáveis: Camel Case
string descontoTotal;
string desconto_Total;

// Para constantes: Maiúsculas

double PI = 3.14;
string NOME_PESSOA = "Gui";

// para classes e métodos: Pascal Case
class ImprimirTexto
{
    public void ImprimeNome()
    {
        Console.WriteLine("Imprimindo nome");
    }
}