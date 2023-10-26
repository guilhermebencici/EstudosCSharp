using System;
using System.Collections.Generic; // Listas, Dicionários, Sets (estrutura de dados)
using System.Linq; // Filtragem, remover, busca// Linq -> Filtragem, remover, busca
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dentro do <TipoDeDadoQueAListaVaiArmazenar>
            List<string> clientes = new List<string>();

            // adicionando cliente a lista
            clientes.Add("Gui");
            clientes.Add("GAbi");
            clientes.Add("Amélia");
            clientes.Add("Binho");

            foreach(string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }

            //Removando um item
            clientes.RemoveAt(2);

            // Removendo através do Linq
            clientes.RemoveAll( cliente => cliente == "Binho" );

            //Filtro utilizando linq
            clientes.Find( cliente => cliente == "Gui");

            //Acessando elemento da Lista
            Console.WriteLine(clientes[1]);
            Console.ReadLine();
        }
    }
}
