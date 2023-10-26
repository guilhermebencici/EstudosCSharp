using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Filme filme = new Filme("Ta dando onda", "Filme top", 2010,"Universal");

            //utilizando método encapsulador
            //filme.AddAtor("Brad Pitt");
            //filme.ExibirAtores();


            //Console.ReadLine();

            Aluno aluno1 = new Aluno("matutino","Gui", "gui@gmail.com", "1234");

            // ANTES DE CRIAR O CONSTRUTOR, O OS ATRIBUTOS FORAM SETADOS ASSIM:

            //aluno1.nome = "Gui";
            //aluno1.email = "guilherme@gmail.com";
            //aluno1.senha = "1234";
            //aluno1.turno = "Vespertino";
            aluno1.Logar();
            

            aluno1.Exibir();


            Zelador zelador1 = new Zelador("Bencici", "zela@gmail.com", "1234" );

            // ANTES DE CRIAR O CONSTRUTOR, O OS ATRIBUTOS FORAM SETADOS ASSIM:

            //zelador1.nome = "Bencici";
            //zelador1.email = "zela@gmail.com";
            //zelador1.senha = "123232";

            zelador1.Exibir();

            // POR CAUSA DO POLIMORFISMO, PODEMOS ALTERAR SEUS TIPOS

            //criei o tipo "usuario", que aceita instanciar os tipos Aluno e Zelador
            Usuario u = new Aluno("matutino", "Gui", "gui@gmail.com", "1234");
            Usuario u2 = new Zelador("Bencici", "zela@gmail.com", "1234");

            //Entretanto, não é possível acessar as propriedades deles, para tal, é preciso fazer um CAST

            Console.WriteLine(((Aluno)u).turno);

            Console.ReadLine();

        }
    }
}
