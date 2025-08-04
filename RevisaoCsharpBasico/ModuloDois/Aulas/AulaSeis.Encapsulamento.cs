using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloDois.Modelos;

namespace ModuloDois.Aulas
{
    public class AulaSeis
    {
        /***
         * ========== AULA 6 ==============
         * Encapsulamento é o conceito de esconder os detalhes de implementação de uma classe,
         * expondo apenas o que é necessário para o uso da classe.
         * 
         * Em C#, podemos usar modificadores de acesso para controlar a visibilidade dos membros da classe.
         * Os modificadores de acesso mais comuns são:
         * - public: acessível de qualquer lugar
         * - private: acessível apenas dentro da própria classe
         * - protected: acessível dentro da própria classe e em classes derivadas
         * - internal: acessível dentro do mesmo assembly
         * - protected internal: acessível dentro do mesmo assembly e em classes derivadas
         * ================================
        ***/

        public void ExemploEncapsulamento()
        {
            // Obtendo dados de um produto novo
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine() ?? "Produto Padrão";

            Console.Write("Digite o preço do produto: ");
            decimal preco;
            while (!decimal.TryParse(Console.ReadLine(), out preco))
            {
                Console.WriteLine("Preço inválido. Por favor, digite um valor numérico válido.");
            }

            Console.Write("Digite a quantidade do produto: ");
            int quantidade;
            while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade < 0)
            {
                Console.WriteLine("Quantidade inválida. Por favor, digite um número inteiro não negativo.");
            }

            // Exemplo de encapsulamento com a classe ProdutoNovo
            var produto = new ProdutoNovo(nome, preco, quantidade);

            Console.WriteLine();
            // Imprimindo os detalhes do produto
            Console.WriteLine(produto);
        }
    }
}
