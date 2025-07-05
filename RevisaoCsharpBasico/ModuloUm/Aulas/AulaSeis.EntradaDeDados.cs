using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ModuloUm.Aulas
{
    public class AulaSeis
    {
        /***
         * ========== AULA 6 ============
         * Entrada de Dados
         * (texto, números inteiros e decimais)
         * ==============================
        ***/

        public void EntradaDeDados()
        {
            // 1. Entrada de dados em forma de texto
            Console.WriteLine("Digite alguma coisa: ");
            string frase = Console.ReadLine();
            Console.WriteLine($"Você digitou: {frase}");

            Console.WriteLine("Digite três palavras: ");
            string[] palavras = Console.ReadLine().Split(' ');

            Console.WriteLine($"Primeira: {palavras[0]}");
            Console.WriteLine($"Segunda: {palavras[1]}");
            Console.WriteLine($"Terceira: {palavras[2]}");

            // 2. Entrada de dados em forma de número inteiro
            Console.WriteLine("Digite um número inteiro: ");
            int numeroInteiro = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou o número inteiro: {numeroInteiro}");

            // 3. Entrada de dados em forma de números decimais
            Console.WriteLine("Digite um número decimal: ");
            double numeroDecimal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Você digitou o número decimal: {numeroDecimal}");

            Console.WriteLine("Digite outro número decimal: ");
            decimal outroNumeroDecimal = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Você digitou o outro número decimal: {outroNumeroDecimal}");
        }
    }
}
