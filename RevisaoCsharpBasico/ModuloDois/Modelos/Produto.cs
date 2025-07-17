using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDois.Modelos
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, decimal preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public decimal CalcularValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            if (quantidade < 0)
            {
                throw new ArgumentException("A quantidade a ser adicionada não pode ser negativa.");
            }

            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            if (quantidade < 0)
            {
                throw new ArgumentException("A quantidade a ser removida não pode ser negativa.");
            }
            if (Quantidade < quantidade)
            {
                throw new InvalidOperationException("Não há quantidade suficiente em estoque para remover.");
            }

            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"{Nome}, $ {Preco:F2}, {Quantidade} unidades, Valor Total em Estoque: $ {CalcularValorTotalEmEstoque():F2}";
        }
    }
}
