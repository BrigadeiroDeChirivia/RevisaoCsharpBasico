using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloUm.Aulas
{
    public class AulaCinco
    {
        /***
         * ========== AULA 5 ============
         * Operadores Aritméticos
         * ==============================
        ***/

        public void OperadoresAritmeticos()
        {
            // 1. Operadores Aritméticos Básicos
            
            int a = 10;
            int b = 5;
            
            Console.WriteLine($"Soma: {a + b}");          // Adição
            Console.WriteLine($"Subtração: {a - b}");     // Subtração
            Console.WriteLine($"Multiplicação: {a * b}"); // Multiplicação
            Console.WriteLine($"Divisão: {a / b}");       // Divisão
            Console.WriteLine($"Módulo: {a % b}");        // Módulo (resto da divisão)
            
            // 2. Incremento e Decremento
            
            a++; // Incremento
            Console.WriteLine($"Incremento: {a}");
            b--; // Decremento
            Console.WriteLine($"Decremento: {b}");

            // 3. Exemplo com fórmula de Bhaskara

            double aBhaskara = 1;
            double bBhaskara = -3;
            double cBhaskara = 2;

            double delta = Math.Pow(bBhaskara, 2) - (4 * aBhaskara * cBhaskara);
            
            double raiz1 = (-bBhaskara + Math.Sqrt(delta)) / (2 * aBhaskara);
            double raiz2 = (-bBhaskara - Math.Sqrt(delta)) / (2 * aBhaskara);
            
            Console.WriteLine($"Raiz 1: {raiz1}");
            Console.WriteLine($"Raiz 2: {raiz2}");
            
        }
    }
}
