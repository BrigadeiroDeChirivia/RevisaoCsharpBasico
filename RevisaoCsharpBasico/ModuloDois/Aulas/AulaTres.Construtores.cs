using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloDois.Modelos;

namespace ModuloDois.Aulas
{
    public class AulaTres
    {
        /***
         * ========== AULA 2 ==============
         * Construtores
         * ================================
        ***/

        public void ExemploConstrutores()
        {
            // Solicitando ao usuário os parâmetros necessários para criar um produto
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine() ?? "Produto Padrão";
            
            Console.Write("Digite o preço do produto: ");
            decimal preco;
            while (!decimal.TryParse(Console.ReadLine(), out preco))
            {
                Console.Write("Valor inválido. Digite o preço do produto: ");
            }

            Console.Write("Digite a quantidade do produto: ");
            int quantidade;
            while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade < 0)
            {
                Console.Write("Valor inválido. Digite a quantidade do produto: ");
            }

            // Criando uma instância da classe Produto a partir dos parâmetros fornecidos
            Produto produto = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            // Exibindo as informações do produto
            Console.WriteLine("Produto criado com sucesso! \nDados do produto: " + produto);

            Console.WriteLine();
            // Exemplo de adição de produtos
            Console.WriteLine("Digite a quantidade de produtos a serem adicionados ao estoque: ");
            int quantidadeAdicionar;
            while (!int.TryParse(Console.ReadLine(), out quantidadeAdicionar) || quantidadeAdicionar < 0)
            {
                Console.Write("Valor inválido. Digite a quantidade a ser adicionada: ");
            }
            produto.AdicionarProdutos(quantidadeAdicionar);

            Console.WriteLine();
            Console.WriteLine("Produto após adição: " + produto);

            Console.WriteLine();
            // Exemplo de remoção de produtos
            Console.WriteLine("Digite a quantidade de produtos a serem removidos do estoque: ");
            int quantidadeRemover;
            while (!int.TryParse(Console.ReadLine(), out quantidadeRemover) || quantidadeRemover < 0)
            {
                Console.Write("Valor inválido. Digite a quantidade a ser removida: ");
            }
            produto.RemoverProdutos(quantidadeRemover);

            Console.WriteLine();
            Console.WriteLine("Produto após remoção: " + produto);
        }
    }
}
