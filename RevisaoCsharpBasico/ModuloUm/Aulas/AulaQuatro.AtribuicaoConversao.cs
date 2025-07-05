using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloUm.Aulas
{
    public class AulaQuatro
    {
        /***
         * ========== AULA 4 ============
         * Operadores de Atribuição
         * Conversão implícita e Casting
         * ==============================
        ***/

        public void OperadoresDeAtribuicao()
        {
            // 1. Operadores de Atribuição

            int valor = 10;
            Console.WriteLine($"Valor inicial: {valor}");
            
            valor += 5; // Adiciona 5 ao valor
            Console.WriteLine($"Valor após += 5: {valor}");
            
            valor -= 3; // Subtrai 3 do valor
            Console.WriteLine($"Valor após -= 3: {valor}");
            
            valor *= 2; // Multiplica o valor por 2
            Console.WriteLine($"Valor após *= 2: {valor}");
            
            valor /= 4; // Divide o valor por 4
            Console.WriteLine($"Valor após /= 4: {valor}");
            
            valor %= 3; // Resto da divisão por 3
            Console.WriteLine($"Valor após %= 3: {valor}");

            valor++; // Incrementa o valor em 1
            Console.WriteLine($"Valor após ++: {valor}");
            
            valor--; // Decrementa o valor em 1
            Console.WriteLine($"Valor após --: {valor}");
            
        }

        public void ConversaoImplicita()
        {
            // 2. Conversão Implícita

            int numeroInteiro = 42;
            double numeroDouble = numeroInteiro; // Conversão implícita de int para double
            Console.WriteLine($"Número inteiro: {numeroInteiro}");
            Console.WriteLine($"Número double (após conversão implícita): {numeroDouble}");

            // Obs: A conversão implícita ocorre quando não há perda de dados, como de um tipo menor para um tipo maior
            // Caso contrário, é necessário usar casting explícito
        }

        public void ConversaoCasting()
        {
            // 3. Conversão Casting

            double numeroDouble = 42.5;
            int numeroInteiro = (int)numeroDouble; // Casting explícito de double para int
            Console.WriteLine($"Número double: {numeroDouble}");
            Console.WriteLine($"Número inteiro (após casting): {numeroInteiro}");

            // Obs: O casting pode resultar em perda de dados, como no exemplo acima, onde a parte decimal é descartada
            // É importante ter cuidado ao realizar casting para evitar erros ou perda de informações importantes
        }
    }
}
