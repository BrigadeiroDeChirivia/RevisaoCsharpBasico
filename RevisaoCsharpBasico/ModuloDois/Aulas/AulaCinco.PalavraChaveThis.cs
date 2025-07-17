using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloDois.Modelos;

namespace ModuloDois.Aulas
{
    public class AulaCinco
    {
        /***
         * ========== AULA 5 ==============
         * Palavra-chave 'this'
         * 
         * Objetivo:
         * - Referenciar outro construtor em um construtor
         * - Passar o próprio objeto como parâmetro para métodos ou construtor
         * ================================
        ***/
        public void ExemploThis()
        {
            // Solicitando ao usuário os parâmetros necessários para criar um dragão
            Console.Write("Digite o nome do dragão: ");
            string nome = Console.ReadLine() ?? "Dragão Padrão";
            
            Console.Write("Digite a cor do dragão (Vermelho, Azul ou Verde): ");
            string cor = Console.ReadLine() ?? "Cor Padrão";
            while (cor != "Vermelho" && cor != "Azul" && cor != "Verde")
            {
                Console.Write("Cor inválida. Digite a cor do dragão (Vermelho, Azul ou Verde): ");
                cor = Console.ReadLine() ?? "Cor Padrão";
            }

            Console.Write("Digite a idade do dragão: ");
            int idade;
            while (!int.TryParse(Console.ReadLine(), out idade) || idade < 0)
            {
                Console.Write("Valor inválido. Digite a idade do dragão: ");
            }

            // Criando uma instância da classe Dragão a partir dos parâmetros fornecidos
            Dragao dragao = new Dragao(nome, cor, idade);

            Console.WriteLine();
            // Exibindo as informações do dragão
            Console.WriteLine("Dragão criado com sucesso! \nDados do dragão: " + dragao);

            Console.WriteLine();
            dragao.ImprimirRugido();
        }
    }
}
