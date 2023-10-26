using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // módulo que permite gerar arquivos

namespace ManipulandoArquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////INICIANDO O FLUXO
            //StreamWriter escritor = File.AppendText("teste.txt");

            //escritor.WriteLine("Guilherme");
            //escritor.WriteLine("Bencici");

            //escritor.Close();// ENCERRANDO O FLUXO 

            StreamReader leitor = new StreamReader("teste.txt");
            //string conteudo = leitor.ReadToEnd();

            //lendo linha por linha
            string linha = "";

            while(linha != null)
            {
                linha = leitor.ReadLine();
                Console.WriteLine(linha);
            }

            Console.WriteLine("Arquivo gerado!");
            leitor.Close(); //encerrando o fluxo
            Console.ReadLine();
        }
    }
}
