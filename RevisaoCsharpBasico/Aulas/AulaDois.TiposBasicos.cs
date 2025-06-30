using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloUm.Aulas
{
    public class AulaDois
    {
        public void TiposBasicos()
        {
            /***
             * ========== AULA 2 ============
             * Tipos básicos de dados em C#
             * (TIPOS NUMÉRICOS DECIMAIS, TIPOS DE TEXTO, TIPO BOOLEANO E TIPO OBJECT)
             * ==============================
            ***/

            // 1. TIPOS NUMÉRICOS DECIMAIS

            float tipoFloat = 1.5555555555555555555555555555555555555555F;      // Considera até 7 caracteres depois da vírgula
            double tipoDouble = 1.7777777777777777777777777777777777777777;     // Considera até 15 ou 16 caracteres depois da vírgula
            decimal tipoDecimal = 1.9999999999999999999999999999999999999999M;  // Considera até 28 ou 29 caracteres depois da vírgula

            Console.WriteLine($"Tipo float: {tipoFloat}");
            Console.WriteLine($"Tipo double: {tipoDouble}");
            Console.WriteLine($"Tipo decimal: {tipoDecimal}");

            // 2. TIPOS DE TEXTO

            char tipoChar = 'F';                        // Áspas simples
            string tipoString = "Cadeia de caracteres"; // Áspas duplas

            Console.WriteLine($"Tipo char: {tipoChar}");
            Console.WriteLine($"Tipo string: {tipoString}");

            // 3. TIPO BOOLEANO

            bool tipoBoolean1 = false;
            bool tipoBoolean2 = true;

            Console.WriteLine($"Tipo bool: {tipoBoolean1}");
            Console.WriteLine($"Tipo bool: {tipoBoolean2}");

            // 4. TIPO OBJECT
            
            // Todos os tipos básicos derivam do tipo object,
            // portanto object pode receber qualquer valor

            object tipoObject1 = "Outra cadeia de caracteres";
            object tipoObject2 = 10;
            object tipoObject3 = 20.20;

            Console.WriteLine($"Tipo object: {tipoObject1}");
            Console.WriteLine($"Tipo object: {tipoObject2}");
            Console.WriteLine($"Tipo object: {tipoObject3}");
        }
    }
}
