using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GestorEstoque
{
     class Program
     {
        static List<IEstoque> produtos = new List<IEstoque>();
        enum Menu { Listar = 1, Adicionar, Remover, Entrada, Saida, Sair}
        static void Main(string[] args)
        {
            Carregar();
            bool escolheuSair = false;

            while (!escolheuSair)
            {
                Console.WriteLine("Sistema de Estoque");
                Console.WriteLine("1-Listar\n2-Adicionar\n3-Remover\n4-Registrar Entrada\n5-Registrar Saida\n6-Sair");
                string opStr = Console.ReadLine();
                int opInt= int.Parse(opStr);
                Menu escolha = (Menu)opInt; //realizando o cast

                if(opInt > 0 && opInt < 7)
                {
                    switch (escolha)
                    {
                        case Menu.Listar:
                            Listagem();
                            break;
                        case Menu.Adicionar:
                            Cadastro();
                            break;
                        case Menu.Remover:
                            Remover();
                            break;
                        case Menu.Entrada:
                            Entrada();
                            break;
                        case Menu.Saida:
                            Saida();
                            break;
                        case Menu.Sair:
                            escolheuSair = true;
                            break;
                    }
                }
                else
                {
                    escolheuSair = true;
                }
                Console.Clear();
            }
        }

        static void Listagem()
        {
            Console.WriteLine("Lista de produtos");
            int i = 0;

            foreach(IEstoque produto in produtos)
            {
                Console.WriteLine("ID: " + i);
                produto.Exibir();
                i++;
            }
            Console.ReadLine();
        }

        static void Remover()
        {
            Listagem();
            Console.WriteLine("Digiteo ID do elemento que sera removido: ");
            int id = int.Parse(Console.ReadLine());

            if(id >= 0 && id < produtos.Count)
            {
                produtos.RemoveAt(id);
                Console.WriteLine($"O {id} foi removido!");
                Console.ReadLine();
                Salvar();
            }
        }

        static void Entrada()
        {
            Listagem();
            Console.WriteLine("Digiteo ID do elemento para entrada: ");
            int id = int.Parse(Console.ReadLine());

            if (id >= 0 && id < produtos.Count)
            {
                produtos[id].AdicionarEntrada();
                Console.ReadLine();
                Salvar();
            }
        }

        static void Saida()
        {
            Listagem();
            Console.WriteLine("Digiteo ID do elemento para baixa: ");
            int id = int.Parse(Console.ReadLine());

            if (id >= 0 && id < produtos.Count)
            {
                produtos[id].AdicionarSaida();
                Console.ReadLine();
                Salvar();
            }
        }

        static void Cadastro()
        {
            Console.WriteLine("Cadastro de Produto");
            Console.WriteLine("1-Produto Físico\n2-Ebook\n3-Curso");
            string opStr = Console.ReadLine();
            int escolhaInt = int.Parse(opStr);

            switch (escolhaInt)
            {
                case 1:
                    CadastrarProdutoFisico();
                    break;
                case 2:
                    CadastrarEbook();
                    break;
                case 3:
                    CadastrarCurso();
                    break;
            }
        }

        static void CadastrarProdutoFisico()
        {
            Console.WriteLine("Cadastrando produto físico: ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Frete: ");
            float frete = float.Parse(Console.ReadLine());

            ProdutoFisico pf = new ProdutoFisico(nome, preco, frete);
            produtos.Add(pf);
            Salvar();
        }

        static void CadastrarEbook()
        {
            Console.WriteLine("Cadastrando produto físico: ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Autor: ");
            string autor = Console.ReadLine();

            Ebook eb = new Ebook(nome, preco, autor);
            produtos.Add(eb);
            Salvar();
        }

        static void CadastrarCurso()
        {
            Console.WriteLine("Cadastrando produto físico: ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Autor: ");
            string autor = Console.ReadLine();

            Curso cs = new Curso(nome, preco, autor);
            produtos.Add(cs);
            Salvar();
        }

        static void Salvar()
        {
            FileStream stream = new FileStream("produtos.dat",FileMode.OpenOrCreate);// tenta abrir o arquivo, senão existir, ele cria!

            //responsável por pegar os dados e salvar em binário
            BinaryFormatter enconder = new BinaryFormatter();

            enconder.Serialize(stream, produtos);
            stream.Close();
        }

        static void Carregar()
        {
            FileStream stream = new FileStream("produtos.dat", FileMode.OpenOrCreate);// tenta abrir o arquivo, senão existir, ele cria!
            //responsável por pegar os dados e salvar em binário
            BinaryFormatter enconder = new BinaryFormatter();

            try
            {
                produtos = (List<IEstoque>)enconder.Deserialize(stream);

                if(produtos == null)
                {
                    produtos = new List<IEstoque>(); //se for nulo, eu começo uma lista nova
                }

            }
            catch (Exception e)
            {
                produtos = new List<IEstoque>(); //se houver erro, eu começo uma lista nova

            }
            stream.Close();
        }
    }
}
