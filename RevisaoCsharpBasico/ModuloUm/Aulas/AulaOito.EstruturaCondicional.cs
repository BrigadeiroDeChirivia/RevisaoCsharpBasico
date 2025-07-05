using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloUm.Aulas
{
    public class AulaOito
    {
        /***
         * ========== AULA 8 ============
         * Estrutura Condicional (if, else if, else)
         * Switch Case
         * ==============================
        ***/

        public void EstruturaCondicional()
        {
            // 1. Estrutura condicional if, else if, else
            int numero = 15;
            Console.WriteLine($"Número: {numero}");

            if (numero < 10)
                Console.WriteLine("O número é menor que 10.");
            else if (numero >= 10 && numero < 20)
                Console.WriteLine("O número está entre 10 e 20.");
            else
                Console.WriteLine("O número é maior ou igual a 20.");

            // 2. Estrutura switch case
            string diaDaSemana = "Segunda";
            Console.WriteLine($"\nDia da semana: {diaDaSemana}");

            switch (diaDaSemana)
            {
                case "Segunda":
                    Console.WriteLine("Hoje é segunda-feira.");
                    break;
                case "Terça":
                    Console.WriteLine("Hoje é terça-feira.");
                    break;
                case "Quarta":
                    Console.WriteLine("Hoje é quarta-feira.");
                    break;
                case "Quinta":
                    Console.WriteLine("Hoje é quinta-feira.");
                    break;
                case "Sexta":
                    Console.WriteLine("Hoje é sexta-feira.");
                    break;
                default:
                    Console.WriteLine("Dia inválido.");
                    break;
            }
        }
    }
}
