using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloUm.Aulas
{
    internal class AulaSete
    {
        /***
         * ========== AULA 7 ============
         * Operadores Comparativos (== != > < >= <=)
         * Operadores Lógicos (&& || !)
         * ==============================
        ***/

        public void OperadoresComparativos()
        {
            // 1. Comparando números inteiros
            int numero1 = 10;
            int numero2 = 20;
            Console.WriteLine($"Número 1: {numero1}");
            Console.WriteLine($"Número 2: {numero2}");
            Console.WriteLine($"Número 1 é igual a Número 2? {numero1 == numero2}");
            Console.WriteLine($"Número 1 é diferente de Número 2? {numero1 != numero2}");
            Console.WriteLine($"Número 1 é maior que Número 2? {numero1 > numero2}");
            Console.WriteLine($"Número 1 é menor que Número 2? {numero1 < numero2}");
            Console.WriteLine($"Número 1 é maior ou igual a Número 2? {numero1 >= numero2}");
            Console.WriteLine($"Número 1 é menor ou igual a Número 2? {numero1 <= numero2}");

            // 2. Comparando strings
            string texto1 = "Aula";
            string texto2 = "Aula";
            Console.WriteLine($"\nTexto 1: {texto1}");
            Console.WriteLine($"Texto 2: {texto2}");
            Console.WriteLine($"Texto 1 é igual a Texto 2? {texto1 == texto2}");
            Console.WriteLine($"Texto 1 é diferente de Texto 2? {texto1 != texto2}");
        }

        public void OperadoresLogicos()
        {
            // 1. Operadores lógicos com números
            int numero1 = 10;
            int numero2 = 20;
            Console.WriteLine($"\nNúmero 1: {numero1}");
            Console.WriteLine($"Número 2: {numero2}");
            Console.WriteLine($"Número 1 é maior que 5 e Número 2 é menor que 30? {numero1 > 5 && numero2 < 30}");
            Console.WriteLine($"Número 1 é maior que 15 ou Número 2 é menor que 25? {numero1 > 15 || numero2 < 25}");
            Console.WriteLine($"Não é verdade que Número 1 é igual a Número 2? {! (numero1 == numero2)}");
            // 2. Operadores lógicos com strings
            string texto1 = "Aula";
            string texto2 = "Aula";
            Console.WriteLine($"\nTexto 1: {texto1}");
            Console.WriteLine($"Texto 2: {texto2}");
            Console.WriteLine($"Texto 1 é igual a Texto 2 e Texto 1 não é vazio? {texto1 == texto2 && !string.IsNullOrEmpty(texto1)}");

            // Tabelas verdade
            /***
             * Tabela Verdade do AND (&&):
             * A     B     A && B
             * V     V     V
             * V     F     F
             * F     V     F
             * F     F     F
             * 
             * Tabela Verdade do OR (||):
             * A     B     A || B
             * V     V     V
             * V     F     V
             * F     V     V
             * F     F     F
             * 
             * Tabela Verdade do NOT (!):
             * A     !A
             * V     F
             * F     V
             * 
             * Prioridade dos operadores lógicos:
             * ! > && > ||
            ***/
        }
    }
}
