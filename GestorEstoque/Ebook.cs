using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEstoque
{
    [System.Serializable]

    class Ebook : Produto, IEstoque
    {
        public string autor;
        private int vendas;

        public Ebook(string nome, float preco,string autor)
        {   this.nome = nome; 
            this.preco = preco;
            this.autor = autor;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine("Não há como adicionar ebooks");
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar vendas no E-book {nome}");
            Console.WriteLine("Digite a quantidade de vendas que você quer dar entrada: ");

            int quantidadeVenda = int.Parse(Console.ReadLine());
            vendas += quantidadeVenda;
            Console.WriteLine("Saída Registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vedas: {vendas}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine("================================================================");
        }
    }
}
