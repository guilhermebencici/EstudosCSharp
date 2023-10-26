using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEstoque
{
     class ProdutoFisco : Produto
    {
        public float frete;
        private int estoque;

        public ProdutoFisco(string nome, float preco, float frete)
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;
        }
    }
}
