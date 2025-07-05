using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ModuloUm.Aulas
{
    internal class AulaDez
    {
        /***
         * ========== AULA 10 ============
         * Estruturas de repetição são usadas para executar um bloco de código várias vezes.
         * Existem diferentes tipos de estruturas de repetição, como for, while e do-while.
         * Elas permitem iterar sobre coleções ou repetir ações até que uma condição seja atendida.
         * 
         * Sintaxe:
         * for (inicialização; condição; incremento)
         * {
         *     // corpo do loop
         * }
         * ==============================
        ***/

        public void ExemploWhile()
        {
            // Exemplo de estrutura de repetição 'while'
            Console.WriteLine($"Digite um número:");
            int numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (numero >= 0.0)
            {
                double raizQuadrada = Math.Sqrt(numero);
                Console.WriteLine($"Raiz quadrada: {raizQuadrada}");

                Console.WriteLine($"Digite um número:");
                numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            
            Console.WriteLine($"Raiz negativa!");
        }

        public void ExemploFor()
        {
            // Exemplo de estrutura de repetição 'for'
            Console.WriteLine($"Quantos números inteiros você vai digitar?");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int soma = 0;
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Valor #{i}: ");
                int valor = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += valor;
            }

            Console.WriteLine($"Soma: {soma}");
        }

        public void ExemploDoWhile()
        {
            // Exemplo de estrutura de repetição 'do-while'
            int numero = 0;
            do
            {
                Console.WriteLine($"Número: {numero}");
                numero++;
            } while (numero < 5);
        }
    }
}
