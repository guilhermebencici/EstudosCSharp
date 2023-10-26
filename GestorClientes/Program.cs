using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GestorClientes
{
    internal class Program
    {
        [System.Serializable] // para conseguir salvar os clientes em um arquivo
        struct Cliente
        {
            public string nome;
            public string email;
            public string cpf;
        }
        // variavel global, permitindo acessa-la em qualquer função
        static List<Cliente> clientes = new List<Cliente>();

        //enumerando o MENU
        enum Menu { Listagem = 1, Adicionar = 2, Remover = 3, Sair = 4}
        static void Main(string[] args)
        {
            Carregar();
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Sistema de Clientes - Bem Vindo!");
                Console.WriteLine("1 - Listagem\n2 - Adicionar\n3 - Remover\n4 - Sair");
                int intOp = int.Parse(Console.ReadLine());

                Menu opcao = (Menu)intOp;

                switch (opcao)
                {
                    case Menu.Adicionar:
                        Adicionar();
                        break;
                    case Menu.Listagem:
                        Listagem();
                        break;
                    case Menu.Remover:
                        Remover();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;    
                        break;
                }
                Console.Clear();//limpando o console!
            }

        }

        static void Adicionar()
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Cadastro de Cliente: ");

            Console.WriteLine("Nome do Cliente: ");
            cliente.nome = Console.ReadLine();

            Console.WriteLine("Email do Cliente: ");
            cliente.email = Console.ReadLine();

            Console.WriteLine("CPF do Cliente: ");
            cliente.cpf = Console.ReadLine();

            // adicionando clientes ao arquivo
            clientes.Add(cliente);
            Salvar();

            Console.WriteLine("Cadastro Concluído! Aperte - Enter - para sair! :) ");
            Console.ReadLine();
        }

        // REMOVENDO CLIENTE
        static void Remover()
        {
            Listagem();
            Console.WriteLine("Digite o ID do cliente para remoção:");
            int id = int.Parse(Console.ReadLine());

            if(id >= 0 && id < clientes.Count)
            {
                clientes.RemoveAt(id);
                Salvar();
            }
            else
            {
                Console.WriteLine("Este ID não consta na lista! Tente de novo.");
                Console.ReadLine();
            }
        }

        static void Listagem()
        {
            if(clientes.Count > 0)
            {
                Console.WriteLine("Lista de Clientes: ");
                int i = 1;

                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine($"ID: {i}");
                    Console.WriteLine($"Nome: {cliente.nome}");
                    Console.WriteLine($"Email: {cliente.email}");
                    Console.WriteLine($"CPF: {cliente.cpf}");
                    Console.WriteLine("============================================");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Não há nenhum cliente na lista :/");
            }
           
            Console.WriteLine("Aperte -Enter- para sair!");
            Console.ReadLine();
        }

        //Salvando no arquivo
        static void Salvar()
        {
            FileStream stream = new FileStream("clients.dat", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, clientes);

            stream.Close();
        }

        //Lendo no arquivo
        static void Carregar()
        {
            FileStream stream = new FileStream("clients.dat", FileMode.OpenOrCreate);
            try
            {
                BinaryFormatter encoder = new BinaryFormatter();

                clientes = (List<Cliente>)encoder.Deserialize(stream);

                if(clientes == null)
                {
                    clientes = new List<Cliente>();
                }
            }
            catch(Exception e)
            {
                clientes = new List<Cliente>();
            }
            stream.Close();
        }
    }
}
