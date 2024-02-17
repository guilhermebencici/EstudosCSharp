using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Enumeration;

internal class MinhaClasse
{
    //COMO NÃO APONTEI NENHUM MODIFICADOR DE ACESSO, TODOS OS CAMPOS CITADOS ABAIXO SERÃO PRIVATE!
    int MeuCampo;
    string? MinhaPropriedade { get; set; }
    void MeuMetodo()
    {
        Console.WriteLine("Meu Metodo");
    }
}
