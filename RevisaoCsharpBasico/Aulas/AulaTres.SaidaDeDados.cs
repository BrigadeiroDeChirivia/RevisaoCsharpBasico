using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloUm.Aulas
{
    internal class AulaTres
    {
        public void SaidaDeDados()
        {
            /***
             * ========== AULA 3 ============
             * Saída de dados em C#
             * ToString() para delimitar casas decimais e CultureInfo
             * ==============================
            ***/

            // 1. ToString()
            decimal valorDecimal = 12.3456789M;

            Console.WriteLine(valorDecimal);                                                // Sem delimitador de casas decimais e sem CultureInfo
            Console.WriteLine(valorDecimal.ToString("F2"));                                 // Com delimitador F2, ou seja, 2 casas decimais
            Console.WriteLine(valorDecimal.ToString("F2", CultureInfo.InvariantCulture));   // Com CultureInfo para padronizar o ponto como separador de casas decimais

            // 2. Placeholders, Concatenação e Interpolação de strings
            string nome = "Jeff";
            int idade = 300;
            double altura = 1.2548;

            Console.WriteLine("Nome: {0}, Idade: {1}, Altura: {2:F2}", nome, idade, altura);                    // Placeholders
            Console.WriteLine("Nome: " + nome + ", Idade: " + idade + ", Altura: " + altura.ToString("F2"));    // Concatenação
            Console.WriteLine($"Nome: {nome}, Idade: {idade}, Altura: {altura:F2}");                            // Interpolação
        }
    }
}
