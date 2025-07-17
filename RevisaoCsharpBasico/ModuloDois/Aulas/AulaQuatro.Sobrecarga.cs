using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloDois.Modelos;

namespace ModuloDois.Aulas
{
    public class AulaQuatro
    {
        /***
         * ========== AULA 4 ==============
         * Sobrecarga de Métodos
         * ================================
        ***/
        public void ExemploSobrecarga()
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

            // Criando uma instância da classe Produto a partir dos parâmetros fornecidos
            Produto produto = new Produto(nome, preco);

            Console.WriteLine();
            // Exibindo as informações do produto
            Console.WriteLine("Produto criado com sucesso! \nDados do produto: " + produto);
        }
    }
}
