using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Aluno : Usuario // aluno herda de Usuario
    {
        public List<string> turmas = new List<string>();
        public string turno = "Matutino"

        // construtor
        public Aluno(string turno, string nome, string email, string senha) : base(nome, email, senha) //base referencia ao construtor do pai
        {
            this.turno = turno;
        }

        //POLIMORFISMO DE SOBREPOSIÇÃO -> OVERRIDE: SOBRESCREVE MÉTODO DA CLASSE PAI (USUARIO)
        public override void Exibir()
        {
            //base.Exibir(); O BASE.EXIBIR(), ESTÁ CHAMANDO O MÉTODO DA CLASSE PAI
            base.Exibir();
            Console.WriteLine("Turno: " + turno);
        }
    }
}
