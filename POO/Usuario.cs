using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Usuario
    {
        public string nome;
        public string email;
        public string senha;
        protected string teste;

        // CONSTRUTOR
        public Usuario(string nome, string email, string senha)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }

        public void Logar() // Assinatura -> Logar()
        {
            Console.WriteLine("Logando....");
        }

        // POLIMORFIMO DE SOBRECARGA -> Precisa de assinaturas diferentes 
        public void Logar(string email, string senha) // Assinatura -> Logar(string string)
        {
            Console.WriteLine("Logando....");
        }

        // MÉTODO ESTANDO COMO "VIRTUAL", PERMITE QUE SUAS CLASSES FILHAS POSSAM SOBREPOR (ACRESCENTANDO OU REMOVENDO PROPRIEDADES)
        public virtual void Exibir()
        {
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Senha: {senha}");

            Console.WriteLine("===============================================================");
        }
    }


}
