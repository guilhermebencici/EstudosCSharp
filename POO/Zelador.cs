using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Zelador : Usuario
    {
        public List<string> tarefas = new List<string>();

        // CONSTRUTOR
        public Zelador(string nome, string email, string senha) : base(nome, email, senha) //base referencia ao construtor do pai
        {
        }
    }
}
