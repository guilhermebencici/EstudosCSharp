using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Filme
    {
        public string nome;
        public string desc;
        public int ano;
        public string studio;

        // atributo privado, só consego utilziar nesta class. Para utilizar em outra, é preciso utilizar através de métodos publicos
        private List<string> atores = new List<string>(); 

        // CONSTRUTOR
        public Filme(string nome, string desc, int ano, string studio)
        {
            this.nome = nome;
            this.desc = desc;
            this.ano = ano;
            this.studio = studio;
            
        }

        public void Executar()
        {
            Console.WriteLine("Rodando o filme: " + nome);
        }

        public void Pausar()
        {
            Console.WriteLine("||");
        }

        // MÉTODO ENCAPSULADOR, FAZ COM QUE EU POSSA USAR VARIAVEL PRIVADA EM OUTRAS CLASSES
        public void AddAtor(string nome)
        {
            if(nome != null)
            {
                atores.Add(nome);
            }
            
        }

        //EXIBINDO A LISTA DE ATORES (MÉTODO ENCAPSULADO)
        public void ExibirAtores()
        {
            foreach(string ator in atores)
            {
                Console.WriteLine(ator);
            }
        }
    }
}
