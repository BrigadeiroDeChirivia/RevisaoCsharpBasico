using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDois.Modelos
{
    public class ProdutoNovo
    {
        private string _nome;
        public decimal Preco { get; private set; }
        public int Quantidade { get; private set; }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length > 1)
                    _nome = value;
            }
        }

        public ProdutoNovo(string nome, decimal preco)
        {
            _nome = nome;
            Preco = preco;
        }

        public ProdutoNovo(string nome, decimal preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Método privado para calcular o valor total em estoque
        private decimal CalcularValorTotalEmEstoque()
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
