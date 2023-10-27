using System;
using System.IO;
using System.Net; // NECESSARIO PARA REALIZAR REQUISIÇÕES VIA WEB!!!!

namespace HTTP
{
    class Program
    {
        static void Main(string[] args)
        {
            var req = WebRequest.Create("https://jsonplaceholder.typicode.com/todos/");
            req.Method = "GET";


            //iniciando a requisição (WEB REQUEST)
            using (var resp = req.GetResponse())
            {
                var stream = resp.GetResponseStream();//pegando a resposta do site e decodificando
                StreamReader leitor = new StreamReader(stream);// lendo os dados

                object dados = leitor.ReadToEnd();
                Console.WriteLine(dados.ToString());

                stream.Close();
                resp.Close();
            }
            Console.ReadLine();
        }
    }
}
